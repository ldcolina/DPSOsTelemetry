using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DPSOsTelemetria2.Configuraciones
{
    public partial class Novedades : Form
    {
        private readonly Setup setup;

        private readonly bool select;

        private static readonly ResourceManager resource = new ResourceManager(typeof(Properties.Resources));

        public Novedades()
        {
            InitializeComponent();
        }

        public Novedades(Setup _setup, bool _select) : this()
        {
            setup = _setup;
            select = _select;
        }

        private void button1_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        private void Novedades_Load(object sender, EventArgs e)
        {
            button1.Text = Languages.General.Aceptar;
            Text = Languages.Setups.ActualizacionPrograma;
            MainLabel.Text = (select ? "{0}" : Languages.Setups.MainLabel).Replace("{0}", Languages.DPSOsTelemetria.DPSOsTelemetry);
            VersionNotes.Text = (select ? Languages.Setups.VersionNotes1 : Languages.Setups.VersionNotes2).Replace("{0}", Languages.DPSOsTelemetria.DPSOsTelemetry).Replace("{1}", setup.Version);
            ReleaseNotes.Text = Languages.Setups.ReleaseNotes;

            List<string> mensajes = new List<string>();
            int i = 1;
            string txt = resource.GetString($"String{i}");
            while (!string.IsNullOrEmpty(txt))
            {
                mensajes.Add($"{txt}");
                i++;
                txt = resource.GetString($"String{i}");
            }

            mensajes.Add(Languages.Setups.News);

            if (mensajes.Count > 1)
            {
                for (i = mensajes.Count - 1; i >= 0; i--)
                {
                    if (i < mensajes.Count - 2)
                    {
                        txbNovedades.AppendText("-----------------------------------------");
                        txbNovedades.AppendText("-----------------------------------------");
                        txbNovedades.AppendText("-----------------------------------------");
                        txbNovedades.AppendText("------------------------------");
                        txbNovedades.AppendText(Environment.NewLine);
                    }
                    txbNovedades.AppendText(mensajes[i]);
                    txbNovedades.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
