using Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria
{
    public partial class Main : Form
    {
        #region Directorio

        private readonly string configuracion;

        private readonly string file;

        private readonly string version = "2.0.2.13";

        private readonly string anio = "2024";

        #endregion Directorio

        public Main()
        {
            Introducction introducction = new Introducction(version, anio);
            introducction.ShowDialog();

            InitializeComponent();
            instance = this;

            file = $"{Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())}DPSOsTelemetria";
            Directory.CreateDirectory(file);

            configuracion = $"{file}/Configuracion.json";
            Setup datas = new Setup();
            try
            {
                string datos = File.ReadAllText(configuracion);
                datas = JsonConvert.DeserializeObject<Setup>(datos);
            }
            catch
            {
                File.WriteAllText(configuracion, JsonConvert.SerializeObject(datas, Formatting.Indented));
            }
            Idiomas(datas.Idioma);
            decimales = datas.Decimales;

            if (datas.Version != version)
            {
                datas.Version = version;
                File.WriteAllText(configuracion, JsonConvert.SerializeObject(datas, Formatting.Indented));

                Configuraciones.Novedades OpenForm = new Configuraciones.Novedades(datas, false);
                OpenForm.ShowDialog();
            }
        }

        #region Action

        private static Main instance;

        public static ReferenciasII Abrir
        {
            set
            {
                instance.Abrir_Pozo(value);
            }
        }

        public static string Anio
        {
            get
            {
                return instance.anio;
            }
        }

        public static string Carpeta
        {
            get
            {
                return instance.file;
            }
        }

        public static int Decimales
        {
            get
            {
                return instance.decimales;
            }
        }

        public static ReferenciasII Eliminar
        {
            set
            {
                instance.Eliminar_Pozo(value);
            }
        }

        public static ReferenciasII Modificar
        {
            set
            {
                instance.Modificar_Pozo(value);
            }
        }

        public static string Mostrar
        {
            set
            {
                instance.Mostrar_Pozo(value);
            }
        }

        #endregion Action

        #region Archivo

        #region Abrir_Eliminar

        private void Abrir_Pozo(ReferenciasII ReferenciasII)
        {
            Referencias Well = JsonConvert.DeserializeObject<Referencias>(File.ReadAllText(ReferenciasII.ID)) ?? new Referencias();

            Form OpenForm = MdiChildren.Where(val => val.Text.Contains($"{ReferenciasII.Name} ({SystemWell.GetString(ReferenciasII.Type)})")).FirstOrDefault();

            if (OpenForm == null)
            {
                OpenForm = new Pozo(ReferenciasII)
                {
                    MdiParent = this,
                    Text = ReferenciasII.Name,
                    StartPosition = FormStartPosition.CenterScreen
                };
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
                Text = Languages.Administration.Nuevo.Replace("{0}", i.ToString()),
                num = i
            };
            OpenForm.Show();
        }

        #endregion Nuevo

        private void Salir_Click(object sender, EventArgs e) => Close();

        #endregion Archivo

        #region Ventana

        private void ArrangeIcons_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.ArrangeIcons);

        private void Cascade_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

        private void CloseAll_Click(object sender, EventArgs e) => MdiChildren.ToList().ForEach(child => child.Close());

        private void MinimizedAll_Click(object sender, EventArgs e) => MdiChildren.ToList().ForEach(child => child.WindowState = FormWindowState.Minimized);

        private void TileHorizontal_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

        private void TileVertical_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

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

        private void Mostrar_Pozo(string Name)
        {
            Form OpenForm = MdiChildren.Where(val => val.Text.Contains(Name)).FirstOrDefault();

            if (OpenForm != null)
            {
                if (OpenForm.WindowState == FormWindowState.Minimized)
                    OpenForm.WindowState = FormWindowState.Normal;
                OpenForm.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.UtcNow.ToLocalTime().ToString("F");
            List<lt> list = new List<lt>();
            foreach (Form child in MdiChildren.Where(val => val.Name == "Pozo"))
            {
                Pozo form = (Pozo)child;

                ReferenciasI last = form._Telemetrias.LastOrDefault().Copy();
                if (form.select == "2")
                {
                    if (form._Telemetria.DatosOperativosTime.AddSeconds(form._Telemetria.Range.DatosOperativos.TotalSeconds) <= DateTime.UtcNow && form._Telemetria.Range.DatosOperativos.TotalSeconds != 0)
                        form._Telemetria.DatosOperativosTime = form._Telemetria.DatosOperativosTime.AddSeconds(form._Telemetria.Range.DatosOperativos.TotalSeconds);

                    if (form._Telemetria.CartaDinagraficaTime.AddSeconds(form._Telemetria.Range.CartaDinagrafica.TotalSeconds) <= DateTime.UtcNow && form._Telemetria.Range.CartaDinagrafica.TotalSeconds != 0)
                        form._Telemetria.CartaDinagraficaTime = form._Telemetria.CartaDinagraficaTime.AddSeconds(form._Telemetria.Range.CartaDinagrafica.TotalSeconds);

                    form.SendTelemetria();

                    lt l = form._Telemetria.Copy<ReferenciasI, lt>();

                    #region DatosOperativos

                    l.DatosOperativosSends = form._Telemetrias.Where(val => val.Sent.Contains("DatosOperativos")).Count();
                    l.DatosOperativosComplete = form._Telemetrias.Where(val => val.Sent.Contains("DatosOperativos") && val.DatosOperativosFinish && val.DatosOperativosBool).Count();
                    l.DatosOperativosFails = form._Telemetrias.Where(val => val.Sent.Contains("DatosOperativos") && val.DatosOperativosFinish && !val.DatosOperativosBool).Count();

                    l.DOPromedio = form._Telemetrias.Where(val => val.DatosOperativosFinish).Count() > 0 ? form._Telemetrias.Where(val => val.DatosOperativosFinish).Average(val => val.DatosOperativosPromedio.TotalSeconds) : 0;

                    #endregion DatosOperativos

                    #region CartaDinagrafica

                    l.CartaDinagraficaSends = form._Telemetrias.Where(val => val.Sent.Contains("CartaDinagrafica")).Count();
                    l.CartaDinagraficaComplete = form._Telemetrias.Where(val => val.Sent.Contains("CartaDinagrafica") && val.CartaDinagraficaFinish && val.CartaDinagraficaBool).Count();
                    l.CartaDinagraficaFails = form._Telemetrias.Where(val => val.Sent.Contains("CartaDinagrafica") && val.CartaDinagraficaFinish && !val.CartaDinagraficaBool).Count();

                    l.CDPromedio = form._Telemetrias.Where(val => val.CartaDinagraficaFinish).Count() > 0 ? form._Telemetrias.Where(val => val.CartaDinagraficaFinish).Average(val => val.CartaDinagraficaPromedio.TotalSeconds) : 0;

                    #endregion CartaDinagrafica

                    list.Add(l);
             
                    form.Refrescar();
                }
            }

            Ventanas.Enabled = MdiChildren.Length > 0;

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

        #region Configuración

        private void Config_Click(object sender, EventArgs e)
        {
            Config OpenForm = new Config(configuracion);
            OpenForm.ShowDialog();

            if (OpenForm.DialogResult == DialogResult.OK)
            {
                string datos = File.ReadAllText(configuracion);
                Setup datas = JsonConvert.DeserializeObject<Setup>(datos);

                if ((decimales == datas.Decimales) && (Thread.CurrentThread.CurrentCulture.Name == datas.Idioma))
                    return;

                if (decimales != datas.Decimales)
                    Numeros(datas.Decimales);

                if (Thread.CurrentThread.CurrentCulture.Name != datas.Idioma)
                    Idiomas(datas.Idioma);

                Refrescar();
            }
        }

        #region Idioma

        private static readonly ResourceManager resource = new ResourceManager(typeof(Languages.DPSOsTelemetria));

        private static readonly ResourceManager SystemWell = new ResourceManager(typeof(Languages.SystemWell));

        private void Idiomas(string Language)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == Language)
                return;

            Thread.CurrentThread.CurrentCulture = new CultureInfo(Language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);

            Main_Load(null, null);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Text = Languages.DPSOsTelemetria.DPSOsTelemetry;

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
        }

        #endregion Idioma

        #region Decimales

        private int decimales;

        private void Numeros(int Decimales) => decimales = Decimales;

        #endregion Decimales

        private void Refrescar()
        {
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
        }

        #endregion Configuración

        #endregion Ayuda
    }
}