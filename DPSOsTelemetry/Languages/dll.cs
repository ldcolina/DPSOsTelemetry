using System.Collections.Generic;

namespace Languages
{
    public static class Fills
    {
        public static List<ddl> ddlSistema_Unidades()
        {
            List<ddl> Lista = new List<ddl>
            {
                new ddl() { Value = "None", Text = General.SelectOption },
                new ddl() { Value = "0", Text = General.Oilfield },
                new ddl() { Value = "2", Text = General.Mexico },
                new ddl() { Value = "3", Text = General.English },
                new ddl() { Value = "4", Text = General.Latin_SI },
                new ddl() { Value = "1", Text = General.SI }
            };
            return Lista;
        }

        public static List<ddl> ddlMetodoQGI()
        {
            List<ddl> Lista = new List<ddl>
            {
                new ddl() { Value = "None", Text = General.SelectOption },
                new ddl() { Value = "3", Text = Languages.BN.User },
                new ddl() { Value = "0", Text = Languages.BN.ManualValveControl },
                new ddl() { Value = "2", Text = Languages.BN.MeteringValve },
                new ddl() { Value = "1", Text = Languages.BN.PlateOrifice },
            };
            return Lista;
        }

        public static List<ddl> ddlTipoPozo()
        {
            List<ddl> Lista = new List<ddl>
            {
                new ddl() { Value = "None", Text = General.SelectOption },
                new ddl() { Value = "FL", Text = SystemWell.FL },
                new ddl() { Value = "BM", Text = SystemWell.BM },
                new ddl() { Value = "BN", Text = SystemWell.BN },

                //new ddl() { Value = "FLG", Text = SystemWell.FLG },
                //new ddl() { Value = "BNI", Text = SystemWell.BNI },
                //new ddl() { Value = "BCP", Text = SystemWell.BCP },
                //new ddl() { Value = "BEC", Text = SystemWell.BEC },
                //new ddl() { Value = "BJP", Text = SystemWell.BJP }
            };
            return Lista;
        }

        public static List<ddl> ddlIdioma()
        {
            List<ddl> Lista = new List<ddl>
            {
                new ddl() { Value = "es", Text = Setups.Es },
                new ddl() { Value = "es-MX", Text = Setups.EsMx },
                new ddl() { Value = "en", Text = Setups.En },
            };
            return Lista;
        }
    }

    public class ddl
    {
        public string Text { get; set; }

        public string Value { get; set; }
    }
}