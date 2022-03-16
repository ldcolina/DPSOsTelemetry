using System.Resources;

namespace DPSOsTelemetria
{
    public partial class Novedades : Form
    {
        private readonly Setup setup;
        private static readonly ResourceManager resource = new(typeof(Resources));

        public Novedades()
        {
            InitializeComponent();
            
        }

        public Novedades(Setup _setup) : this() => setup = _setup;
        private void button1_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        private void Novedades_Load(object sender, EventArgs e)
        {
            button1.Text = Languages.General.Aceptar;
            Text = Languages.Setups.ActualizacionPrograma;
            MainLabel.Text = Languages.Setups.MainLabel.Replace("{0}", Languages.DPSOsTelemetria.DPSOsTelemetry);
            VersionNotes.Text = Languages.Setups.VersionNotes2.Replace("{0}", Languages.DPSOsTelemetria.DPSOsTelemetry).Replace("{1}", setup.Version); 
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
    }
}