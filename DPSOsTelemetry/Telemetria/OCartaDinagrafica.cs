using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Telemetria
{
    public class OCartaDinagrafica
    {
        [JsonProperty("fecha")]
        public DateTime Fecha { get; set; }

        [JsonProperty("token")]
        public string Token { set; get; } = string.Empty;

        [JsonProperty("pozoId")]
        public string PozoId { set; get; } = string.Empty;

        [JsonProperty("cartaDinagrafica")]
        public CCartaDinagrafica CartaDinagrafica { set; get; } = new CCartaDinagrafica();

        public class CResult
        {
            public bool Success { set; get; } = false;

            public string Message { set; get; } = "N/D";
        }

        public class CCartaDinagrafica
        {
            [JsonProperty("SurfaceCardPosition")]
            public List<decimal> SurfaceCardPosition { get; set; } = new List<decimal>();

            [JsonProperty("SurfaceCardLoad")]
            public List<decimal> SurfaceCardLoad { get; set; } = new List<decimal>();
        }
    }
}
