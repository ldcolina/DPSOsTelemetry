using DPSOsTelemetria2.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DPSOsTelemetria2.Configuraciones
{
    public partial class Guia : UserControl
    {
        public Guia()
        {
            InitializeComponent();
        }

        private int select;

        private void NuevoPozo_Click(object sender, EventArgs e)
        {
            select = select != 1 ? 1 : 0;
            Guia_Resize(null, null);
        }

        private void TransmisionDatos_Click(object sender, EventArgs e)
        {
            select = select != 2 ? 2 : 0;
            Guia_Resize(null, null);
        }

        private void ListaPozos_Click(object sender, EventArgs e)
        {
            select = select != 3 ? 3 : 0;
            Guia_Resize(null, null);
        }

        private void Guia_Resize(object sender, EventArgs e)
        {
            int _Width = tableLayoutPanel1.Width;
            int _Height = tableLayoutPanel1.Height;
            switch (select)
            {
                case 1:
                    {
                        #region splitContainer1

                        NuevoPozo.BackColor = SystemColors.ControlLightLight;
                        splitContainer1.Panel2Collapsed = false;
                        splitContainer1.Size = new Size(_Width, _Height - 100);

                        #endregion splitContainer1

                        #region splitContainer2

                        TransmisionDatos.BackColor = SystemColors.Control;
                        splitContainer2.Panel2Collapsed = true;
                        splitContainer2.Size = new Size(_Width, 50);

                        #endregion splitContainer2

                        #region splitContainer3

                        ListaPozos.BackColor = SystemColors.Control;
                        splitContainer3.Panel2Collapsed = true;
                        splitContainer3.Size = new Size(_Width, 50);

                        #endregion splitContainer3

                        break;
                    }
                case 2:
                    {
                        #region splitContainer1

                        NuevoPozo.BackColor = SystemColors.Control;
                        splitContainer1.Panel2Collapsed = true;
                        splitContainer1.Size = new Size(_Width, 50);

                        #endregion splitContainer1

                        #region splitContainer2

                        TransmisionDatos.BackColor = SystemColors.ControlLightLight;
                        splitContainer2.Panel2Collapsed = false;
                        splitContainer2.Size = new Size(_Width, _Height - 100);

                        #endregion splitContainer2

                        #region splitContainer3

                        ListaPozos.BackColor = SystemColors.Control;
                        splitContainer3.Panel2Collapsed = true;
                        splitContainer3.Size = new Size(_Width, 50);

                        #endregion splitContainer3

                        break;
                    }
                case 3:
                    {
                        #region splitContainer1

                        NuevoPozo.BackColor = SystemColors.Control;
                        splitContainer1.Panel2Collapsed = true;
                        splitContainer1.Size = new Size(_Width, 50);

                        #endregion splitContainer1

                        #region splitContainer2

                        TransmisionDatos.BackColor = SystemColors.Control;
                        splitContainer2.Panel2Collapsed = true;
                        splitContainer2.Size = new Size(_Width, 50);

                        #endregion splitContainer2

                        #region splitContainer3

                        ListaPozos.BackColor = SystemColors.ControlLightLight;
                        splitContainer3.Panel2Collapsed = false;
                        splitContainer3.Size = new Size(_Width, _Height - 100);

                        #endregion splitContainer3

                        break;
                    }
                default:
                    {
                        #region splitContainer1

                        NuevoPozo.BackColor = SystemColors.Control;
                        splitContainer1.Panel2Collapsed = true;
                        splitContainer1.Size = new Size(_Width, 50);

                        #endregion splitContainer1

                        #region splitContainer2

                        TransmisionDatos.BackColor = SystemColors.Control;
                        splitContainer2.Panel2Collapsed = true;
                        splitContainer2.Size = new Size(_Width, 50);

                        #endregion splitContainer2

                        #region splitContainer3

                        ListaPozos.BackColor = SystemColors.Control;
                        splitContainer3.Panel2Collapsed = true;
                        splitContainer3.Size = new Size(_Width, 50);

                        #endregion splitContainer3

                        break;
                    }
            }
        }

        private void Guia_Load(object sender, EventArgs e)
        {
            #region splitContainer1

            Guia1_Load();

            #endregion splitContainer1

            #region splitContainer2

            Guia2_Load();

            #endregion splitContainer2

            #region splitContainer3

            Guia3_Load();

            #endregion splitContainer3
        }

        private void Guia1_Load()
        {
            NuevoPozo.Text = Languages.Setups.newPozo;

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

            label1.Text = Languages.Setups.newPozo1.Replace("{0}", Languages.DPSOsTelemetria.Archivo).Replace("{1}", Languages.DPSOsTelemetria.Nuevo);

            pictureBox1.Image = Image;

            List<string> mensaje = new List<string>()
            {
                $"1.-\t{Languages.Setups.newPozo2}.",
                $"2.-\t{Languages.Setups.newPozo3}.",
                $"3.-\t{Languages.Setups.newPozo4}.",
                $"4.-\t{Languages.Setups.newPozo5}.",
            };
            label2.Text = string.Join("\n", mensaje.ToArray());
            splitContainer1.Panel2.AutoScroll = true;
        }

        private void Guia2_Load()
        {
            TransmisionDatos.Text = Languages.Setups.TransmisionDatos;

            Bitmap Image1 = null, Image2 = null, Image3 = null;
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en":
                    {
                        Image1 = (Bitmap)Resources.telemetry;
                        Image2 = (Bitmap)Resources.telemetry2;
                        Image3 = (Bitmap)Resources.telemetry3;
                        break;
                    }
                case "es":
                case "es-MX":
                    {
                        Image1 = (Bitmap)Resources.telemetria;
                        Image2 = (Bitmap)Resources.telemetria2;
                        Image3 = (Bitmap)Resources.telemetria3;
                        break;
                    }
            }

            label7.Text = Languages.Setups.TransmisionDatos1.Replace("{0}", Languages.DPSOsTelemetria.Archivo).Replace("{1}", Languages.DPSOsTelemetria.Abrir_Eliminar.Substring(0, Languages.DPSOsTelemetria.Abrir_Eliminar.IndexOf(" ")));

            pictureBox2.Image = Image1;

            List<string> mensaje1 = new List<string>()
            {
                $"1.-\t{Languages.Setups.TransmisionDatos2}.",
                $"2.-\t{Languages.Setups.TransmisionDatos3}.",
                $"3.-\t{Languages.Setups.TransmisionDatos4}.",
                $"4.-\t{Languages.Setups.TransmisionDatos5}.",
                $"5.-\t{Languages.Setups.TransmisionDatos6}.",
            };
            label8.Text = string.Join("\n", mensaje1.ToArray());

            label3.Text = Languages.Setups.TransmisionDatos7.Replace("{0}", Languages.DPSOsTelemetria.Abrir_Eliminar);

            pictureBox4.Image = Image2;

            List<string> mensaje2 = new List<string>()
            {
                $"1.-\t{Languages.Setups.TransmisionDatos8}.",
                $"2.-\t{Languages.Setups.TransmisionDatos9}.",
                $"3.-\t{Languages.Setups.TransmisionDatos10}.",
                $"4.-\t{Languages.Setups.TransmisionDatos11}.",
                $"5.-\t{Languages.Setups.TransmisionDatos12}.",
            };
            label4.Text = string.Join("\n", mensaje2.ToArray());

            label5.Text = Languages.Setups.TransmisionDatos13.Replace("{0}", Languages.DPSOsTelemetria.Archivo).Replace("{1}", Languages.DPSOsTelemetria.Abrir_Eliminar.Substring(0, Languages.DPSOsTelemetria.Abrir_Eliminar.IndexOf(" ")));

            pictureBox3.Image = Image3;

            List<string> mensaje3 = new List<string>()
            {
                $"1.-\t{Languages.Setups.TransmisionDatos8}.",
                $"2.-\t{Languages.Setups.TransmisionDatos14}.",
                $"3.-\t{Languages.Setups.TransmisionDatos15}.",
                $"4.-\t{Languages.Setups.TransmisionDatos16}.",
            };
            label6.Text = string.Join("\n", mensaje3.ToArray());
            splitContainer2.Panel2.AutoScroll = true;
        }

        private void Guia3_Load()
        {
            ListaPozos.Text = Languages.Setups.ListaPozos;

            Bitmap Image1 = null;
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en":
                    {
                        Image1 = (Bitmap)Resources.Transmission;
                        break;
                    }
                case "es":
                case "es-MX":
                    {
                        Image1 = (Bitmap)Resources.Transmisiones;
                        break;
                    }
            }

            label9.Text = Languages.Setups.ListaPozos1.Replace("{0}", Languages.DPSOsTelemetria.Ayuda).Replace("{1}", Languages.DPSOsTelemetria.listaTiempo);
            label10.Text = Languages.Setups.ListaPozos2;
            pictureBox5.Image = Image1;

            List<string> mensaje = new List<string>()
            {
                $"1.-\t{Languages.Setups.TransmisionDatos17}.",
                $"2.-\t{Languages.Setups.TransmisionDatos18}.",
            };
            label11.Text = string.Join("\n", mensaje.ToArray());
            splitContainer3.Panel2.AutoScroll = true;
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            int Width = ((PictureBox)sender).Width,
                Height = ((PictureBox)sender).Image.Height * ((PictureBox)sender).Width / ((PictureBox)sender).Image.Width;

            ((PictureBox)sender).Size = new Size(Width, Height);
        }
    }
}