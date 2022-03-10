using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace Telemetria
{
    public class OCartaDinagrafica
    {
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset Time { get; set; }

        public string Token { set; get; } = string.Empty;
        public CCartaDinagrafica CartaDinagrafica = new CCartaDinagrafica();

        public class CResult
        {
            public bool Success { set; get; } = false;
            public string Message { set; get; } = "N/D";
        }

        public class CCartaDinagrafica
        {
            public List<decimal> SurfaceCardPosition { get; set; } = new List<decimal>();
            public List<decimal> SurfaceCardLoad { get; set; } = new List<decimal>();
        }
    }
}