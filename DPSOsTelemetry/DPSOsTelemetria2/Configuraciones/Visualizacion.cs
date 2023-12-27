using System;
using System.Collections.Generic;
using System.Linq;

namespace DPSOsTelemetria2.Configuraciones
{
    public partial class Visualizacion : System.Windows.Forms.UserControl
    {
        private readonly string idioma;

        private readonly int decimales;

        public Visualizacion()
        {
            InitializeComponent();
        }

        public Visualizacion(string _idioma, int _decimales) : this()
        {
            idioma = _idioma;
            decimales = _decimales;
        }

        private void Changed(object sender, EventArgs e)
        {
            List<string> texto = new List<string>();

            try
            {
                System.Globalization.CultureInfo Culture = new System.Globalization.CultureInfo(((Languages.ddl)ddlIdioma.SelectedItem).Value);

                string number = "0";
                if (nDecimales.Value > 0)
                {
                    string decimales = "";

                    while (decimales.Length < nDecimales.Value)
                        for (int i = 1; i <= 9; i++)
                            if (decimales.Length < nDecimales.Value)
                                decimales += i;
                            else
                                break;

                    number += Culture.NumberFormat.NumberDecimalSeparator;
                    number += decimales;
                }
                texto = new List<string>
                {
                    Languages.Setups.Ejemplo,
                    DateTime.Now.ToString("F", Culture),
                    number
                };
            }
            catch
            {
            }
            label4.Text = string.Join("\n", texto.ToArray());
        }

        private void Visualizacion_Load(object sender, EventArgs e)
        {
            label1.Text = Languages.Setups.Visualizacion;
            label2.Text = Languages.Setups.Idioma;
            List<Languages.ddl> Idioma = Languages.Fills.ddlIdioma();
            ddlIdioma.DataSource = Idioma;
            ddlIdioma.DisplayMember = "Text";
            try
            {
                ddlIdioma.SelectedItem = Idioma.Find(val => val.Value == idioma);
            }
            catch
            {
                ddlIdioma.SelectedItem = Idioma.First();
            }

            label3.Text = Languages.Setups.Decimales;
            nDecimales.Value = decimales;
        }
    }
}