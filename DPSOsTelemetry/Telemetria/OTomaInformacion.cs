using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Telemetria
{
    public class OTomaInformacion
    {
        public class CResult
        {
            public bool Success { set; get; } = false;
            public string Message { set; get; } = "N/D";
        }

        public class CTomaInformacion
        {
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTimeOffset Time { get; set; }

            public string Token { set; get; } = string.Empty;
            public CTomaBasica DatosOperativos { set; get; } = new CTomaBasica();
        }

        public class CTomaBasica
        {
            public decimal DoPresionTuberiaProduccion { get; set; } = 0;
            public decimal DoPresionTuberiaRevestimiento { get; set; } = 0;
            public decimal DoPresionAperturaCampo { get; set; } = 0;
            public decimal DoPresionLineaDescarga { get; set; } = 0;
            public decimal DoTemperaturaSuperficie { get; set; } = 0;
            public decimal DoSumergenciaEfectivaBomba { get; set; } = 0;
            public decimal DoNivelFluidoPozoTp { get; set; } = 0;
            public decimal DoNivelFluidoPozoTr { get; set; } = 0;
            public decimal DoPresionEntradaBomba { get; set; } = 0;
            public decimal DoVelocidadBomba { get; set; } = 0;
            public decimal DoVelocidadUnidadBombeo { get; set; } = 0;
            public decimal DoFrecuenciaOperacionBomba { get; set; } = 0;
            public decimal DoVelocidadMotor { get; set; } = 0;
            public decimal DoLongitudCarrera { get; set; } = 0;
            public decimal DoPresionDisponible { get; set; } = 0;
            public decimal DoGastoInyeccionFluidoPotencia { get; set; } = 0;
            public decimal DoGravedadEspecificaFluidoPotencia { get; set; } = 0;
            public decimal DoGastoGasInyeccion { get; set; } = 0;
            public decimal DoGravedadEspecificaGasInyeccion { get; set; } = 0;
            public decimal DoTorque { get; set; } = 0;
            public decimal DoCorriente { get; set; } = 0;
            public decimal DoDiametroEstrangulador { get; set; } = 0;
            public decimal DoTiempoCiclo { get; set; } = 0;
            public decimal DoTiempoRecuperacion { get; set; } = 0;
            public decimal DoTiempoInyeccion { get; set; } = 0;
            public decimal DoTiempoDesplazamientoTapon { get; set; } = 0;
            public decimal DoEficienciaLlenado { get; set; } = 0;
        }
    }
}