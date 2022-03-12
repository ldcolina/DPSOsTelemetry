using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPSOsTelemetria
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

            Copyright.Text = Languages.General.Copyright.Replace("{0}", "2022");
            Visualizacion_Click(null, null);
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            string datos = File.ReadAllText(configuracion);
            var Configuracion = JsonConvert.SerializeObject(newConfiguracion);

            if (datos != Configuracion)
            {
                File.WriteAllText(configuracion, Configuracion);
                this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }

        #region Dinámica

        private void Item_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
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

        private void Actualizacion_Click(object sender, EventArgs e)
        {
        }

        private void Guia_Click(object sender, EventArgs e)
        {
        }

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

        private void Visualizacion_Click(object sender, EventArgs e)
        {
        }

        #endregion info
    }

    public class Setup
    {
        public int Decimales { get; set; } = 4;
        public string Idioma { get; set; } = Thread.CurrentThread.CurrentUICulture.ToString();
    }
}