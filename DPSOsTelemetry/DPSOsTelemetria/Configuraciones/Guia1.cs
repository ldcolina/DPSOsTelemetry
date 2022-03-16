using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPSOsTelemetria.Configuraciones
{
    public partial class Guia1 : UserControl
    {
        public Guia1()
        {
            InitializeComponent();
        }

        private void Guia1_Load(object sender, EventArgs e)
        {
            label1.Text = Languages.Setups.newPozo1.Replace("{0}", Languages.DPSOsTelemetria.Archivo).Replace("{1}", Languages.DPSOsTelemetria.Nuevo);

                        Bitmap Image = null;
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en":
                    {
                        Image = (Bitmap)Resources.new_well;
                        break;
                    }
                case "es":
                case "es-MX":
                    {
                        Image = (Bitmap)Resources.nuevo_pozo;
                        break;
                    }
            }

            pictureBox1.Image = Image;
            pictureBox1.Size = new Size(Image.Width, Image.Height);
            List<string> mensaje = new()
            {
                $"1.-\t{Languages.Setups.newPozo2}",
                $"2.-\t{Languages.Setups.newPozo3}",
                $"3.-\t{Languages.Setups.newPozo4}",
                $"4.-\t{Languages.Setups.newPozo5}",
            };
            label2.Text = string.Join("\n", mensaje.ToArray());
        }
    }
}