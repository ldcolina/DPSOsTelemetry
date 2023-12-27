using DPSOsTelemetria2.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Administration
{
    public partial class Administracion_Pozo : Form
    {
        public string ID = string.Empty;

        public int num = 0;

        private static readonly ResourceManager SystemWell = new ResourceManager(typeof(Languages.SystemWell));

        private readonly string file;

        public Administracion_Pozo()
        {
            InitializeComponent();
            Refrescar();
        }

        public Administracion_Pozo(string _Id) : this()
        {
            ID = _Id;
            file = Main.Carpeta;
        }

        public void Refrescar()
        {
            if (string.IsNullOrEmpty(ID))
                Text = Languages.Administration.Nuevo.Replace("{0}", num.ToString());

            label1.Text = Languages.Administration.Main;
            label2.Text = Languages.Administration.Info;
            lblName.Text = Languages.Administration.Nombre;
            lblToken.Text = Languages.Administration.Token;
            lblUnidades.Text = Languages.Administration.Unidad;
            lblTipo.Text = Languages.Administration.Tipo;

            int SelectDdl = ddlTipoPozo.SelectedIndex;
            List<Languages.ddl> TipoPozo = Languages.Fills.ddlTipoPozo();
            ddlTipoPozo.DataSource = TipoPozo;
            ddlTipoPozo.DisplayMember = "Text";
            try
            {
                ddlTipoPozo.SelectedItem = TipoPozo[SelectDdl];
            }
            catch
            {
                ddlTipoPozo.SelectedItem = TipoPozo.First();
            }

            SelectDdl = ddlUnidades.SelectedIndex;
            List<Languages.ddl> Sistema_Unidades = Languages.Fills.ddlSistema_Unidades();
            ddlUnidades.DataSource = Sistema_Unidades;
            ddlUnidades.DisplayMember = "Text";
            try
            {
                ddlUnidades.SelectedItem = Sistema_Unidades[SelectDdl];
            }
            catch
            {
                ddlUnidades.SelectedItem = Sistema_Unidades.First();
            }
        }

        internal DialogResult Guardar_Info()
        {
            Referencias newWell = new Referencias()
            {
                Name = txtName.Text,
                Token = txtToken.Text,
                Unidades = ((Languages.ddl)ddlUnidades.SelectedItem).Value,
                Type = ((Languages.ddl)ddlTipoPozo.SelectedItem).Value,
            };
            Referencias ControlPozos = !string.IsNullOrEmpty(ID) ? JsonConvert.DeserializeObject<Referencias>(File.ReadAllText(ID)) : new Referencias();

            if (JsonConvert.SerializeObject(ControlPozos) == JsonConvert.SerializeObject(newWell))
                return DialogResult.No;

            DialogResult consultar = DialogResult.Yes;

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                consultar = MessageBox.Show(Languages.DPSOsTelemetria.Guardado, Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (consultar != DialogResult.Yes)
                    return consultar;

                MessageBox.Show(Languages.General.CompleteValue.Replace("{0}", Languages.Administration.Nombre), Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return DialogResult.Cancel;
            }

            if (string.IsNullOrEmpty(txtToken.Text) || string.IsNullOrWhiteSpace(txtToken.Text))
            {
                consultar = MessageBox.Show(Languages.DPSOsTelemetria.Guardado, Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (consultar != DialogResult.Yes)
                    return consultar;

                MessageBox.Show(Languages.General.CompleteValue.Replace("{0}", Languages.Administration.Token), Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return DialogResult.Cancel;
            }

            if (newWell.Type == "None")
            {
                consultar = MessageBox.Show(Languages.DPSOsTelemetria.Guardado, Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (consultar != DialogResult.Yes)
                    return consultar;

                MessageBox.Show(Languages.General.CompleteValue.Replace("{0}", Languages.Administration.Tipo), Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return DialogResult.Cancel;
            }

            if (newWell.Unidades == "None")
            {
                consultar = MessageBox.Show(Languages.DPSOsTelemetria.Guardado, Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (consultar != DialogResult.Yes)
                    return consultar;

                MessageBox.Show(Languages.General.CompleteValue.Replace("{0}", Languages.Administration.Unidad), Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return DialogResult.Cancel;
            }

            if (!string.IsNullOrEmpty(ID))
            {
                consultar = MessageBox.Show(Languages.DPSOsTelemetria.Guardado, Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (consultar != DialogResult.Yes)
                    return consultar;
            }

            List<string> datos = Directory.GetFiles(file).ToList();
            int cases = 0;
            if (txtName.Enabled)
                foreach (string val in datos)
                {
                    Referencias d = JsonConvert.DeserializeObject<Referencias>(File.ReadAllText(val));

                    if ((d.Name == newWell.Name) && (d.Token == newWell.Token) && (d.Type == newWell.Type))
                    {
                        cases = 3;
                        ID = val;
                        ControlPozos = d;
                        break;
                    }
                    else if ((d.Token == newWell.Token) && (d.Name == newWell.Type))
                    {
                        cases = 2;
                        ID = val;
                        ControlPozos = d;
                        break;
                    }
                    else if (d.Token == newWell.Token)
                    {
                        cases = 1;
                        ID = val;
                        ControlPozos = d;
                        break;
                    }
                };

            string _mensaje = string.Empty;
            switch (cases)
            {
                case 3:
                    _mensaje = Languages.Administration.GuardadoComo3;
                    break;

                case 2:
                    _mensaje = Languages.Administration.GuardadoComo2;
                    break;

                case 1:
                    _mensaje = Languages.Administration.GuardadoComo1;
                    break;
            }

            if (!string.IsNullOrEmpty(_mensaje))
            {
                _mensaje = _mensaje.Replace("{0}", newWell.Name).Replace("{1}", newWell.Token).Replace("{2}", SystemWell.GetString(newWell.Type));
                consultar = MessageBox.Show(_mensaje, Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (consultar == DialogResult.Cancel)
                    return consultar;

                if (consultar != DialogResult.Yes)
                {
                    consultar = MessageBox.Show(Languages.Administration.Sustituir, Languages.DPSOsTelemetria.Aviso, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (consultar == DialogResult.Yes)
                    {
                        Administracion_Pozo_Load(null, null);
                    }
                    else
                    {
                        ID = string.Empty;

                        switch (cases)
                        {
                            case 3:
                                {
                                    lblName.Text = $"{Languages.Administration.Nombre}*";
                                    lblToken.Text = $"{Languages.Administration.Token}*";
                                    lblTipo.Text = $"{Languages.Administration.Tipo}*";
                                    break;
                                }
                            case 2:
                                {
                                    lblToken.Text = $"{Languages.Administration.Token}*";
                                    lblTipo.Text = $"{Languages.Administration.Tipo}*";
                                    break;
                                }
                            case 1:
                                {
                                    lblToken.Text = $"{Languages.Administration.Token}*";
                                    break;
                                }
                        }
                    }

                    return DialogResult.Cancel;
                }
            }
            else if (string.IsNullOrEmpty(ID))
            {
                while (datos.Exists(val => val == ID) || string.IsNullOrEmpty(ID))
                {
                    while (ID.Length < 15)
                    {
                        Guid Guid = Guid.NewGuid();
                        ID += Convert.ToBase64String(Guid.ToByteArray());
                        string t = new string(ID.Where(c => Char.IsLetterOrDigit(c)).ToArray());
                        ID = t;
                    }
                    ID = ID.Substring(0, 15);
                }
            }

            Text = newWell.Name;

            string directorio = !ID.Contains(file) ? $"{file}/{ID}.json" : ID;
            File.WriteAllText(directorio, JsonConvert.SerializeObject(newWell, Formatting.Indented));
            ID = directorio;

            return consultar;
        }

        private void Administracion_Pozo_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = Guardar_Info() == DialogResult.Cancel;

        private void Administracion_Pozo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID))
            {
                Referencias ControlPozos = JsonConvert.DeserializeObject<Referencias>(File.ReadAllText(ID)) ?? new Referencias();

                Text = ControlPozos.Name;

                txtName.Text = ControlPozos.Name;
                txtToken.Text = ControlPozos.Token;

                ddlUnidades.SelectedItem = ((List<Languages.ddl>)ddlUnidades.DataSource).Find(val => val.Value == ControlPozos.Unidades.ToString());
                ddlUnidades.Enabled = false;
                ddlTipoPozo.SelectedItem = ((List<Languages.ddl>)ddlTipoPozo.DataSource).Find(val => val.Value == ControlPozos.Type.ToString());
                ddlTipoPozo.Enabled = false;
            }
        }

        private void Administracion_Pozo_Resize(object sender, EventArgs e)
        {
            int Size = pictureBox1.Size.Width;
            pictureBox1.Size = new Size(Size, Size);
        }

        private void ddlTipoPozo_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (((Languages.ddl)ddlTipoPozo.SelectedItem).Value)
            {
                case "FL":
                    {
                        pictureBox1.Image = Resources.Fluyente;
                        break;
                    }

                case "FLG":
                    {
                        pictureBox1.Image = null;
                        break;
                    }

                case "BN":
                    {
                        pictureBox1.Image = Resources.Neumatico;
                        break;
                    }

                case "BNI":
                    {
                        pictureBox1.Image = Resources.Neumatico_Intermitente;
                        break;
                    }

                case "BM":
                    {
                        pictureBox1.Image = Resources.Mecanico;
                        break;
                    }

                case "BCP":
                    {
                        pictureBox1.Image = Resources.Cavidad_Progresiva;
                        break;
                    }

                case "BEC":
                    {
                        pictureBox1.Image = Resources.Electrocentrífugo;
                        break;
                    }

                case "BJP":
                    {
                        pictureBox1.Image = Resources.Jet_Pump;
                        break;
                    }
                default:
                    {
                        pictureBox1.Image = Resources.oil_platform;
                        break;
                    }
            }
        }
    }
}