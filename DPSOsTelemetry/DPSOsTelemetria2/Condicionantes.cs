using System;
using System.Windows.Forms;

namespace DPSOsTelemetria2
{
    public static class Condicionantes
    {
        public static string Wrote_Formating(string texto, int decimales = 0)
        {
            decimal number = decimal.Parse(texto);
            return number.ToString($"f{decimales}");
        }

        public static void Wrote_KeyPress(object sender, KeyPressEventArgs e)
        {
            string separadorDecimal = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (char.IsNumber(e.KeyChar) | e.KeyChar == (char)Keys.Escape | e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else if (e.KeyChar == Convert.ToChar(separadorDecimal))
            {
                switch (sender.GetType().Name)
                {
                    case "TextBox":
                        {
                            e.Handled = ((TextBox)sender).Text.Contains(separadorDecimal);
                            break;
                        }
                    case "DataGridViewTextBoxEditingControl":
                        {
                            e.Handled = ((DataGridViewTextBoxEditingControl)sender).Text.Contains(separadorDecimal);
                            break;
                        }
                }
            }
            else
                e.Handled = true;
        }
    }
}