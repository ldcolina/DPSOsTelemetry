using System.Resources;

namespace DPSOsTelemetria
{
    public partial class InfoVersion : Form
    {
        private static readonly ResourceManager resource = new ResourceManager(typeof(Languages.Mensaje_Actualizacion));

        public InfoVersion()
        {
            InitializeComponent();

            this.okButton.Text = $"&{Languages.General.Aceptar}";
            this.Text = $"{Languages.General.AcercaDe} {Languages.DPSOsTelemetria.DPSOsTelemetry}";
            this.labelProductName.Text = Languages.DPSOsTelemetria.DPSOsTelemetry;
            this.labelVersion.Text = Languages.General.Version.Replace("{0}", "1.0.0.0");
            this.labelCopyright.Text = Languages.General.Copyright.Replace("{0}", "2022");
            this.labelCompanyName.Text = $"EnTecPro";

            List<string> Textos = new List<string>()
            {
                $"{Languages.General.Cambios}:"
            };

            int i = 1;
            string text = resource.GetString($"String{i}");
            while (!string.IsNullOrEmpty(text))
            {
                Textos.Add($"{i}.-\t{text}");
                i++;
                text = resource.GetString($"String{i}");
            }

            this.textBoxDescription.Text = Textos.Count > 1 ? string.Join("\n", Textos.ToArray()) : "";
        }
    }
}