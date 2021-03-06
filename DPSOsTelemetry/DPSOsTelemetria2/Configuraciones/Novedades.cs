using System;
using System.Collections.Generic;
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

            List<string> mensajes = new List<string>()
            {
                Languages.Setups.News
            };

            int i = 1;
            string txt = resource.GetString($"String{i}");
            while (!string.IsNullOrEmpty(txt))
            {
                mensajes.Add($"- {txt}.");
                i++;
                txt = resource.GetString($"String{i}");
            }

            if (mensajes.Count > 1)
            {
                mensajes.ForEach(val =>
                {
                    txbNovedades.AppendText(val);
                    txbNovedades.AppendText(Environment.NewLine);
                });
            }
        }
    }
}