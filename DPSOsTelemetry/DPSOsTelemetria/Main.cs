using Newtonsoft.Json;
using System.Globalization;
using System.Resources;
using Telemetria;

namespace DPSOsTelemetria
{
    public partial class Main : Form
    {
        #region Directorio

        //private string version => ApplicationDeployment.IsNetworkDeployed ? ApplicationDeployment.CurrentDeployment.CurrentVersion : Application.ProductVersion;
        private readonly string file;

        private readonly string configuracion;

        #endregion Directorio

        public Main()
        {
            InitializeComponent();
            instance = this;

            file = $"{Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())}DPSOsTelemetria";
            Directory.CreateDirectory(file);

            configuracion = $"{file}/Configuracion.json";
            try
            {
                string datos = File.ReadAllText(configuracion);
                Configuracion datas = JsonConvert.DeserializeObject<Configuracion>(datos);
                Idiomas(datas.Idioma);
            }
            catch
            {
                File.WriteAllText(configuracion, JsonConvert.SerializeObject(new Configuracion(), Formatting.Indented));
                idiomaToolStripMenuItem_Click(esMxToolStripMenuItem, null);
            }
        }

        #region Action

        private static Main instance;

        public static int Decimales
        {
            get
            {
                return string.IsNullOrEmpty(instance.txtNumeroDecimales.Text) ? 0 : Convert.ToInt32(instance.txtNumeroDecimales.Text);
            }
        }

        public static string _file
        {
            get
            {
                return instance.file;
            }
        }

        public static ReferenciasII Eliminar
        {
            set
            {
                instance.Eliminar_Pozo(value);
            }
        }

        public static ReferenciasII Abrir
        {
            set
            {
                instance.Abrir_Pozo(value);
            }
        }

        public static ReferenciasII Modificar
        {
            set
            {
                instance.Modificar_Pozo(value);
            }
        }

        #endregion Action

        #region Archivo

        #region Abrir_Eliminar

        private void Abrir_Pozo(ReferenciasII ReferenciasII)
        {
            Referencias Well = JsonConvert.DeserializeObject<Referencias>(File.ReadAllText(ReferenciasII.ID)) ?? new Referencias();

            Form OpenForm = MdiChildren.Where(val => val.Text.Contains(ReferenciasII.Name)).FirstOrDefault();

            if (OpenForm == null)
            {
                OpenForm = new Pozo(ReferenciasII)
                {
                    MdiParent = this,
                    Text = ReferenciasII.Name
                };
                OpenForm.StartPosition = FormStartPosition.CenterScreen;
                OpenForm.Show();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;

            Administration.Abrir_Eliminar childForm = new Administration.Abrir_Eliminar();
            childForm.ShowDialog();

            if (childForm.DialogResult == DialogResult.OK)
                Enabled = true;
        }

        private void Eliminar_Pozo(ReferenciasII ReferenciasII)
        {
            Form OpenForm = MdiChildren.Where(val => val.Text.Contains(ReferenciasII.Name)).FirstOrDefault();

            if (OpenForm == null)
            {
                if (MessageBox.Show(Languages.Administration.ConfirmarEliminacion.Replace("{0}", ReferenciasII.Name), Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;

                File.Delete(ReferenciasII.ID);
            }
            else
                MessageBox.Show(Languages.DPSOsTelemetria.CantEliminar.Replace("{0}", ReferenciasII.Name), Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Modificar_Pozo(ReferenciasII ReferenciasII)
        {
            Form OpenForm = MdiChildren.Where(val => val.Text.Contains(ReferenciasII.Name)).FirstOrDefault();

            if (OpenForm == null)
            {
                OpenForm = new Administration.Administracion_Pozo(ReferenciasII.ID)
                {
                    MdiParent = this,
                };
                OpenForm.Show();
            }
            else
                MessageBox.Show(Languages.DPSOsTelemetria.CantModify.Replace("{0}", ReferenciasII.Name), Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion Abrir_Eliminar

        #region Guardar

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                switch (ActiveMdiChild.Name)
                {
                    case "Administracion_Pozo":
                        {
                            Administration.Administracion_Pozo Form = (Administration.Administracion_Pozo)ActiveMdiChild;
                            Form.Guardar_Info();

                            break;
                        }
                    case "Pozo":
                        {
                            Pozo Form = (Pozo)ActiveMdiChild;
                            Form.Guardar_Info();

                            break;
                        }
                }
        }

        #endregion Guardar

        #region Nuevo

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (MdiChildren.Where(val => val.Text == Languages.Administration.Nuevo.Replace("{0}", i.ToString())).ToList().Count > 0)
                i++;

            Administration.Administracion_Pozo OpenForm = new Administration.Administracion_Pozo(string.Empty)
            {
                MdiParent = this,
                Text = Languages.Administration.Nuevo.Replace("{0}", i.ToString())
            };
            OpenForm.num = i;
            OpenForm.Show();
        }

        #endregion Nuevo

        private void Salir_Click(object sender, EventArgs e) => Close();

        #endregion Archivo

        #region Ventana

        private void Cascade_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

        private void ArrangeIcons_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.ArrangeIcons);

        private void TileVertical_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

        private void TileHorizontal_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

        private void CloseAll_Click(object sender, EventArgs e) => MdiChildren.ToList().ForEach(child => child.Close());

        private void MinimizedAll_Click(object sender, EventArgs e) => MdiChildren.ToList().ForEach(child => child.WindowState = FormWindowState.Minimized);

        #endregion Ventana

        #region Ayuda

        #region listTiempo

        private void listaTiempo_Click(object sender, EventArgs e)
        {
            Form OpenForm = MdiChildren.Where(val => val.Name == "listaTiempo").FirstOrDefault();

            if (OpenForm == null)
            {
                OpenForm = new listaTiempo()
                {
                    MdiParent = this,
                    Text = Languages.DPSOsTelemetria.listaTiempo
                };
                OpenForm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.UtcNow.ToLocalTime().ToString("F");
            List<ReferenciasI> list = new List<ReferenciasI>();
            foreach (Form child in MdiChildren.Where(val => val.Name == "Pozo"))
            {
                Pozo form = (Pozo)child;

                if (form.select == "2")
                {
                    ReferenciasI _Telemetria = form._Telemetria;
                    if ((_Telemetria.Range.DatosOperativos.TotalMilliseconds != 0) && (_Telemetria.Range.CartaDinagrafica.TotalMilliseconds != 0))
                    {
                        DateTime time1 = _Telemetria.Started.AddMilliseconds(_Telemetria.Range.DatosOperativos.TotalMilliseconds * _Telemetria.DatosOperativosSends);
                        DateTime time2 = _Telemetria.Started.AddMilliseconds(_Telemetria.Range.CartaDinagrafica.TotalMilliseconds * _Telemetria.CartaDinagraficaSends);
                        if ((time1 <= time2 ? time1 : time2) <= DateTime.UtcNow && form.status)
                            form.SendTelemetria();
                        else
                            form.Refrescar();
                    }
                    else if (_Telemetria.Range.DatosOperativos.TotalMilliseconds != 0)
                    {
                        DateTime time1 = _Telemetria.Started.AddMilliseconds(_Telemetria.Range.DatosOperativos.TotalMilliseconds * _Telemetria.DatosOperativosSends);
                        if (time1 <= DateTime.UtcNow && form.status)
                            form.SendTelemetria();
                        else
                            form.Refrescar();
                    }
                    else if (_Telemetria.Range.CartaDinagrafica.TotalMilliseconds != 0)
                    {
                        DateTime time2 = _Telemetria.Started.AddMilliseconds(_Telemetria.Range.CartaDinagrafica.TotalMilliseconds * _Telemetria.CartaDinagraficaSends);
                        if (time2 <= DateTime.UtcNow && form.status)
                            form.SendTelemetria();
                        else
                            form.Refrescar();
                    }
                    list.Add(form._Telemetria);
                }
            }

            listaTiempo.Enabled = list.Count > 0;
            Form OpenForm = MdiChildren.Where(val => val.Name == "listaTiempo").FirstOrDefault();
            if (OpenForm != null)
                if (listaTiempo.Enabled)
                {
                    listaTiempo form = (listaTiempo)OpenForm;
                    form.Recargar(list);
                }
                else
                    OpenForm.Close();
        }

        #endregion listTiempo

        private void txtNumeroDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & e.KeyChar != (char)Keys.Escape & e.KeyChar != (char)Keys.Back;
        }

        private void txtNumeroDecimales_TextChanged(object sender, EventArgs e)
        {
            string datos = File.ReadAllText(configuracion);
            Configuracion datas = JsonConvert.DeserializeObject<Configuracion>(datos);
            datas.Decimales = Decimales;
            File.WriteAllText(configuracion, JsonConvert.SerializeObject(datas, Formatting.Indented));

            #region MdiChildren

            foreach (Form child in MdiChildren.Where(val => val.Name == "Pozo"))
            {
                Pozo form = (Pozo)child;
                form.Refrescar();
            }

            #endregion MdiChildren
        }

        #endregion Ayuda

        #region Idioma

        private static readonly ResourceManager resource = new ResourceManager(typeof(Languages.DPSOsTelemetria));

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Language = "es-MX";
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "esToolStripMenuItem":
                    Language = "es";
                    break;

                case "esMxToolStripMenuItem":
                    Language = "es-MX";
                    break;

                case "enToolStripMenuItem":
                    Language = "en";
                    break;
            }

            if (Thread.CurrentThread.CurrentCulture.Name == Language)
                return;

            string datos = File.ReadAllText(configuracion);
            Configuracion datas = JsonConvert.DeserializeObject<Configuracion>(datos);
            datas.Idioma = Language;
            File.WriteAllText(configuracion, JsonConvert.SerializeObject(datas, Formatting.Indented));

            Idiomas(Language);
        }

        private void Idiomas(string Language)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);

            Main_Load(null, null);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region Main

            Text = $"{Languages.DPSOsTelemetria.DPSOsTelemetry}";
            esToolStripMenuItem.Text = $"&{Languages.DPSOsTelemetria.Es}";
            esMxToolStripMenuItem.Text = $"&{Languages.DPSOsTelemetria.EsMx}";
            enToolStripMenuItem.Text = $"&{Languages.DPSOsTelemetria.En}";

            foreach (ToolStripMenuItem ToolStrip in menuStrip1.Items.OfType<ToolStripMenuItem>())
            {
                string text = resource.GetString(ToolStrip.Name);
                if (!string.IsNullOrEmpty(text))
                    ToolStrip.Text = $"&{text}";

                foreach (ToolStripMenuItem ToolStrip1 in ToolStrip.DropDownItems.OfType<ToolStripMenuItem>())
                    try
                    {
                        text = resource.GetString(ToolStrip1.Name);
                        if (!string.IsNullOrEmpty(text))
                            ToolStrip1.Text = $"&{text}";

                        foreach (ToolStripMenuItem ToolStrip2 in ToolStrip1.DropDownItems.OfType<ToolStripMenuItem>())
                            try
                            {
                                text = resource.GetString(ToolStrip2.Name);
                                if (!string.IsNullOrEmpty(text))
                                    ToolStrip2.Text = $"&{text}";
                            }
                            catch { }
                    }
                    catch { }
            }

            #endregion Main

            #region MdiChildren

            foreach (Form child in MdiChildren)
            {
                switch (child.Name)
                {
                    case "Administracion_Pozo":
                        {
                            Administration.Administracion_Pozo form = (Administration.Administracion_Pozo)child;
                            form.Refrescar();
                            break;
                        }
                    case "Pozo":
                        {
                            Pozo form = (Pozo)child;
                            form.Refrescar();
                            break;
                        }
                    case "listaTiempo":
                        {
                            listaTiempo form = (listaTiempo)child;
                            form.Refrescar();
                            break;
                        }
                }
            }

            #endregion MdiChildren
        }

        #endregion Idioma

        internal class Configuracion
        {
            public string Idioma { get; set; } = Thread.CurrentThread.CurrentUICulture.ToString();
            public int Decimales { get; set; } = 4;
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            InfoVersion info = new InfoVersion();
            info.ShowDialog();
        }
    }
}