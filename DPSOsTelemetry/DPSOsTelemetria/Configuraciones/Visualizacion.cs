namespace DPSOsTelemetria.Configuraciones
{
    public partial class Visualizacion : UserControl
    {
        public Visualizacion()
        {
            InitializeComponent();
        }

        public void Refrescar(string idioma, int decimales)
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

        private void Changed(object sender, EventArgs e)
        {
            var texto = new List<string>();

            try
            {
                var Culture = new System.Globalization.CultureInfo(((Languages.ddl)ddlIdioma.SelectedItem).Value);

                var number = "0";
                if (nDecimales.Value > 0)
                {
                    var decimales = "";

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
                    new DateTime().ToString("F", Culture),
                    number
                };
            }
            catch
            {
            }
            label4.Text = string.Join("\n", texto.ToArray());
        }
    }
}