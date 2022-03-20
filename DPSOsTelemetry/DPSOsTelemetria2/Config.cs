using Newtonsoft.Json;
using System.Windows.Forms;

using System;
using System.IO;
using System.Linq;
using DPSOsTelemetria2.Configuraciones;
using System.Drawing;
using System.Threading;

namespace DPSOsTelemetria2
{
    public partial class Config : Form
    {
        private readonly string configuracion;
        private Setup newConfiguracion;

        public Config()
        {
            InitializeComponent();
        }

        public Config(string config) : this()
        {
            configuracion = config;
            string datos = File.ReadAllText(configuracion);
            newConfiguracion = JsonConvert.DeserializeObject<Setup>(datos);
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (select == 2)
            {
                Visualizacion _Visualizacion = splitContainer1.Panel2.Controls.OfType<Visualizacion>().FirstOrDefault();
                newConfiguracion.Decimales = (int)_Visualizacion.nDecimales.Value;
                newConfiguracion.Idioma = ((Languages.ddl)_Visualizacion.ddlIdioma.SelectedItem).Value;
            }

            string datos = File.ReadAllText(configuracion);
            var Configuracion = JsonConvert.SerializeObject(newConfiguracion);

            if (datos != Configuracion)
            {
                File.WriteAllText(configuracion, Configuracion);
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
        }

        #region Dinámica

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "Label":
                    {
                        Label _Label = (Label)sender;

                        TableLayoutPanel _TableLayoutPanel = (TableLayoutPanel)tableLayoutPanel3.Controls.Find($"tlp{_Label.Name.Replace("lb", "")}", true).First();

                        if (_TableLayoutPanel.BackColor == SystemColors.Control)
                        {
                            _TableLayoutPanel.BackColor = SystemColors.ControlLightLight;
                        }

                        break;
                    }
                case "TableLayoutPanel":
                    {
                        TableLayoutPanel _TableLayoutPanel = (TableLayoutPanel)sender;

                        if (_TableLayoutPanel.BackColor == SystemColors.Control)
                        {
                            _TableLayoutPanel.BackColor = SystemColors.ControlLightLight;
                        }
                        break;
                    }
                case "PictureBox":
                    {
                        PictureBox _PictureBox = (PictureBox)sender;

                        TableLayoutPanel _TableLayoutPanel = (TableLayoutPanel)tableLayoutPanel3.Controls.Find($"tlp{_PictureBox.Name.Replace("ptb", "")}", true).First();

                        if (_TableLayoutPanel.BackColor == SystemColors.Control)
                        {
                            _TableLayoutPanel.BackColor = SystemColors.ControlLightLight;
                        }

                        break;
                    }
            }
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "Label":
                    {
                        Label _Label = (Label)sender;

                        TableLayoutPanel _TableLayoutPanel = (TableLayoutPanel)tableLayoutPanel3.Controls.Find($"tlp{_Label.Name.Replace("lb", "")}", true).First();

                        if (_TableLayoutPanel.BackColor != SystemColors.Control)
                        {
                            _TableLayoutPanel.BackColor = SystemColors.Control;
                        }

                        break;
                    }
                case "TableLayoutPanel":
                    {
                        TableLayoutPanel _TableLayoutPanel = (TableLayoutPanel)sender;

                        if (_TableLayoutPanel.BackColor != SystemColors.Control)
                        {
                            _TableLayoutPanel.BackColor = SystemColors.Control;
                        }
                        break;
                    }
                case "PictureBox":
                    {
                        PictureBox _PictureBox = (PictureBox)sender;

                        TableLayoutPanel _TableLayoutPanel = (TableLayoutPanel)tableLayoutPanel3.Controls.Find($"tlp{_PictureBox.Name.Replace("ptb", "")}", true).First();

                        if (_TableLayoutPanel.BackColor != SystemColors.Control)
                        {
                            _TableLayoutPanel.BackColor = SystemColors.Control;
                        }

                        break;
                    }
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label obj = (Label)sender;
            obj.Font = new Font(obj.Font, FontStyle.Underline);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label obj = (Label)sender;
            obj.Font = new Font(obj.Font, FontStyle.Regular);
        }

        #endregion Dinámica

        #region info

        private int select = 0;

        private void Actualizacion_Click(object sender, EventArgs e)
        {
            Novedades OpenForm = new Novedades(newConfiguracion, true);
            OpenForm.ShowDialog();
        }

        private void Destino_Click(int _select)
        {
            if (select == 2)
            {
                Visualizacion _Visualizacion = splitContainer1.Panel2.Controls.OfType<Visualizacion>().FirstOrDefault();
                newConfiguracion.Decimales = (int)_Visualizacion.nDecimales.Value;
                newConfiguracion.Idioma = ((Languages.ddl)_Visualizacion.ddlIdioma.SelectedItem).Value;
            }

            if (_select == select)
                return;

            switch (_select)
            {
                case 1:
                    {
                        splitContainer1.Panel2.Controls.Clear();

                        Guia _Guia = new Guia() { Dock = DockStyle.Fill };
                        splitContainer1.Panel2.Controls.Add(_Guia);

                        break;
                    }
                case 2:
                    {
                        splitContainer1.Panel2.Controls.Clear();

                        Visualizacion _Visualizacion = new Visualizacion(_decimales: newConfiguracion.Decimales, _idioma: newConfiguracion.Idioma) { Dock = DockStyle.Fill };
                        splitContainer1.Panel2.Controls.Add(_Visualizacion);

                        break;
                    }
            }
            select = _select;
        }

        private void Guia_Click(object sender, EventArgs e) => Destino_Click(1);

        private void Visualizacion_Click(object sender, EventArgs e) => Destino_Click(2);

        #endregion info

        #region Licenses

        private void LicenseAgreement_Click(object sender, EventArgs e)
        {
        }

        private void Licenses_Click(object sender, EventArgs e)
        {
        }

        private void Privacy_Click(object sender, EventArgs e)
        {
        }

        private void Terms_Click(object sender, EventArgs e)
        {
        }

        #endregion Licenses

        private void Config_Shown(object sender, EventArgs e) => splitContainer1.SplitterDistance = tableLayoutPanel2.Width;

        private void Config_Load(object sender, EventArgs e)
        {
            Text = Languages.DPSOsTelemetria.Config;

            Visualizacion.Text = Languages.Setups.Visualizacion;
            Guia.Text = Languages.Setups.Guia;
            Actualizaciones.Text = Languages.Setups.Actualizaciones;

            Copyright.Text = Languages.Setups.Copyright.Replace("{0}", "2022");
            Terms.Text = Languages.Setups.Terms;
            Privacy.Text = Languages.Setups.Privacy;
            LicenseAgreement.Text = Languages.Setups.LicenseAgreement;
            Licenses.Text = Languages.Setups.Licenses;
            Version.Text = Languages.Setups.Version.Replace("{0}", newConfiguracion.Version);
            Visualizacion_Click(null, null);
        }
    }

    public class Setup
    {
        public int Decimales { get; set; } = 4;
        public string Idioma { get; set; } = Thread.CurrentThread.CurrentUICulture.ToString();
        public string Version { get; set; } = "";
    }
}