using System.Resources;

namespace DPSOsTelemetria
{
    public partial class Novedades : Form
    {
        private static readonly ResourceManager resource = new(typeof(Resources));

        public Novedades()
        {
            InitializeComponent();
            button1.Text = Languages.General.Aceptar;
            Text = Languages.Setups.ActualizacionPrograma;
            MainLabel.Text = Languages.Setups.MainLabel.Replace("{0}", Languages.DPSOsTelemetria.DPSOsTelemetry);
            ReleaseNotes.Text = Languages.Setups.ReleaseNotes;

            List<string> mensajes = new()
            {
                Languages.Setups.News
            };

            int i = 1;
            string txt = resource.GetString($"String{i}");
            while (!string.IsNullOrEmpty(txt))
            {
                mensajes.Add(txt);
                i++;
                txt = resource.GetString($"String{i}");
            }

            if (mensajes.Count > 1)
                txbNovedades.Text = String.Join("\n", mensajes.ToArray());
        }

        public Novedades(Setup setup) : this() => VersionNotes.Text = Languages.Setups.VersionNotes2.Replace("{0}", Languages.DPSOsTelemetria.DPSOsTelemetry).Replace("{1}", setup.Version);

        private void button1_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}