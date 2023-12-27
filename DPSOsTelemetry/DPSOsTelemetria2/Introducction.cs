using System;
using System.Windows.Forms;

namespace DPSOsTelemetria2
{
    public partial class Introducction : Form
    {
        public Introducction()
        {
            InitializeComponent();
        }

        private readonly string Version;

        private readonly string Anio;

        public Introducction(string _Version, string _Anio) : this()
        {
            Version = _Version;
            Anio = _Anio;
        }

        private void Introducction_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Introducction_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (Opacity > 0)
            {
                Opacity = (double)((decimal)Opacity - 0.1M);
                System.Threading.Thread.Sleep(10);
            }
        }

        private void Introducction_Load(object sender, EventArgs e)
        {
            Text = String.Format($"{Languages.General.AcercaDe} {Languages.DPSOsTelemetria.DPSOsTelemetry}");
            lblProductName.Text = Languages.DPSOsTelemetria.DPSOsTelemetry;
            lblProgress.Text = Languages.General.Informacion;
            lblVersion_CompanyName.Text = $"{Languages.Setups.Version.Replace("{0}", Version)}\nEnTecPro I-Services";
            lblCopyright.Text = Languages.Setups.Copyright.Replace("{0}", Anio);
            lblMoreInfo.Text = $"{Languages.General.MoreInfo} {Languages.DPSOsTelemetria.Ayuda}. {Languages.DPSOsTelemetria.Config}...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity = (double)((decimal)Opacity + 0.1M);
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value += 2;
            else
            {
                timer2.Enabled = false;
                Close();
            }
        }
    }
}