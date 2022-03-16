using System.Resources;

namespace DPSOsTelemetria.Configuraciones
{
    public partial class Actualizaciones : UserControl
    {
        private static readonly ResourceManager resource = new(typeof(Resources));

        public Actualizaciones()
        {
            InitializeComponent();
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

        public Actualizaciones(Setup setup) : this() => VersionNotes.Text = Languages.Setups.VersionNotes1.Replace("{0}", Languages.DPSOsTelemetria.DPSOsTelemetry).Replace("{1}", setup.Version);

        private void Actualizaciones_Load(object sender, EventArgs e)
        {

        }
    }
}