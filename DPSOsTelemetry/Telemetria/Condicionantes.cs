using System;
using System.Windows.Forms;

namespace Telemetria
{
    public static class Condicionantes
    {
        public static string Wrote_Formating(string texto, int decimales = 0)
        {
            string separadorDecimal = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string separadorMiles = separadorDecimal == "." ? "," : ".";

            if (!string.IsNullOrEmpty(texto))
            {
                int indDecimal = texto.IndexOf(separadorDecimal);
                int indMiles = texto.IndexOf(separadorMiles);

                if ((indMiles != -1) && (indMiles > indDecimal))
                {
                    texto = texto.Remove(indMiles, 1);
                    texto = texto.Insert(indMiles, separadorDecimal);

                    if (indDecimal != -1)
                        texto = texto.Remove(indDecimal, 1);
                }
            }
            else
                texto = "0";

            if (decimales == 0)
            {
                string value = Convert.ToDouble(texto).ToString();
                if (value.Contains(separadorDecimal))
                    decimales = value.Substring(value.IndexOf(separadorDecimal) + 1).Length;
            }

            return Convert.ToDecimal(texto).ToString($"n{decimales}");
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