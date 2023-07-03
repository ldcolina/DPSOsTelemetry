using System;
using System.Collections.Generic;

namespace Telemetria
{
    public class OCartaDinagrafica
    {
        //[JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime time { get; set; }

        public string token { set; get; } = string.Empty;

        public string pozoId { set; get; } = string.Empty;

        public CCartaDinagrafica cartaDinagrafica { set; get; } = new CCartaDinagrafica();

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
