using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static Telemetria.OTomaInformacion;

namespace Telemetria
{
    public class OCartaDinagrafica
    {
        public class CCartaDinagrafica
        {
            [JsonProperty("fecha")]
            public DateTime Fecha { get; set; }

            [JsonProperty("token")]
            public string Token { set; get; } = string.Empty;

            [JsonProperty("pozoId")]
            public string PozoId { set; get; } = string.Empty;

            [JsonProperty("datosOperativos")]
            public CTomaCarta DatosOperativos { set; get; } = new CTomaCarta();
        }

        public class CTomaCarta
        {
            [JsonProperty("CartaSuperficie")]
            public List<CartaSuperficie> CartaSuperficie { get; set; }
        }

        public class CartaSuperficie
        {
            public decimal Distancia { get; set; }

            public decimal Fuerza { get; set; }
        }
    }
}