namespace DPSOsTelemetria.Configuraciones
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
            select = 1;
            Guia_Resize(null, null);
        }

        private void TransmisionDatos_Click(object sender, EventArgs e)
        {
            select = 2;
            Guia_Resize(null, null);
        }

        private void ListaPozos_Click(object sender, EventArgs e)
        {
            select = 3;
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
            var Guia1 = new Guia1() { Dock=DockStyle.Top };
            splitContainer1.Panel2.Controls.Add(Guia1);

            var Guia2 = new Guia2() { Dock = DockStyle.Top };
            splitContainer2.Panel2.Controls.Add(Guia2);

            var Guia3 = new Guia3() { Dock = DockStyle.Top };
            splitContainer3.Panel2.Controls.Add(Guia3);
        }
    }
}