using Newtonsoft.Json;
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
            [JsonProperty("fecha")]
            public DateTime Fecha { get; set; }

            [JsonProperty("token")]
            public string Token { set; get; } = string.Empty;

            [JsonProperty("pozoId")]
            public string PozoId { set; get; } = string.Empty;

            [JsonProperty("datosOperativos")]
            public CTomaBasica DatosOperativos { set; get; } = new CTomaBasica();
        }

        public class CTomaBasica
        {
            [JsonProperty("cargaSobreBarraPulida")]
            public decimal CargaSobreBarraPulida { set; get; } = 0;

            [JsonProperty("corriente")]
            public decimal Corriente { set; get; } = 0;

            [JsonProperty("diametroEstrangulador")]
            public decimal DiametroEstrangulador { set; get; } = 0;

            [JsonProperty("eficienciaLlenado")]
            public decimal EficienciaLlenado { set; get; } = 0;

            [JsonProperty("emulsion")]
            public decimal Emulsion { set; get; } = 0;

            [JsonProperty("frecuenciaOperacionBomba")]
            public decimal FrecuenciaOperacionBomba { set; get; } = 0;

            [JsonProperty("gastoAceite")]
            public decimal GastoAceite { set; get; } = 0;

            [JsonProperty("gastoGas")]
            public decimal GastoGas { set; get; } = 0;

            [JsonProperty("gastoGasInyeccion")]
            public decimal GastoGasInyeccion { set; get; } = 0;

            [JsonProperty("gastoInyeccionFluidoPotencia")]
            public decimal GastoInyeccionFluidoPotencia { set; get; } = 0;

            [JsonProperty("gastoLiquido")]
            public decimal GastoLiquido { set; get; } = 0;

            [JsonProperty("gastoLiquidoPruebaProduccion")]
            public decimal GastoLiquidoPruebaProduccion { set; get; } = 0;

            [JsonProperty("gravedadEspecificaFluidoPotencia")]
            public decimal GravedadEspecificaFluidoPotencia { set; get; } = 0;

            [JsonProperty("gravedadEspecificaGasInyeccion")]
            public decimal GravedadEspecificaGasInyeccion { set; get; } = 0;

            [JsonProperty("gravedadEspecificaGasProducido")]
            public decimal GravedadEspecificaGasProducido { set; get; } = 0;

            [JsonProperty("gravedadPetroleo")]
            public decimal GravedadPetroleo { set; get; } = 0;

            [JsonProperty("longitudCarrera")]
            public decimal LongitudCarrera { set; get; } = 0;

            [JsonProperty("nivelFluidoPozoTp")]
            public decimal NivelFluidoPozoTp { set; get; } = 0;

            [JsonProperty("nivelFluidoPozoTr")]
            public decimal NivelFluidoPozoTr { set; get; } = 0;

            [JsonProperty("porcentajeAguaSedimento")]
            public decimal PorcentajeAguaSedimento { set; get; } = 0;

            [JsonProperty("presionAperturaCampo")]
            public decimal PresionAperturaCampo { set; get; } = 0;

            [JsonProperty("presionDisponible")]
            public decimal PresionDisponible { set; get; } = 0;

            [JsonProperty("presionEntradaBomba")]
            public decimal PresionEntradaBomba { set; get; } = 0;

            [JsonProperty("presionLineaDescarga")]
            public decimal PresionLineaDescarga { set; get; } = 0;

            [JsonProperty("presionTuberiaProduccion")]
            public decimal PresionTuberiaProduccion { set; get; } = 0;

            [JsonProperty("presionTuberiaRevestimiento")]
            public decimal PresionTuberiaRevestimiento { set; get; } = 0;

            [JsonProperty("relacionGasAceite")]
            public decimal RelacionGasAceite { set; get; } = 0;

            [JsonProperty("salinidadAgua")]
            public decimal SalinidadAgua { set; get; } = 0;

            [JsonProperty("sumergenciaEfectivaBomba")]
            public decimal SumergenciaEfectivaBomba { set; get; } = 0;

            [JsonProperty("temperaturaSuperficie")]
            public decimal TemperaturaSuperficie { set; get; } = 0;

            [JsonProperty("tiempoCiclo")]
            public decimal TiempoCiclo { set; get; } = 0;

            [JsonProperty("tiempoDesplazamientoTapon")]
            public decimal TiempoDesplazamientoTapon { set; get; } = 0;

            [JsonProperty("tiempoInyeccion")]
            public decimal TiempoInyeccion { set; get; } = 0;

            [JsonProperty("tiempoRecuperacion")]
            public decimal TiempoRecuperacion { set; get; } = 0;

            [JsonProperty("torque")]
            public decimal Torque { set; get; } = 0;

            [JsonProperty("velocidadBomba")]
            public decimal VelocidadBomba { set; get; } = 0;

            [JsonProperty("velocidadMotor")]
            public decimal VelocidadMotor { set; get; } = 0;

            [JsonProperty("velocidadUnidadBombeo")]
            public decimal VelocidadUnidadBombeo { set; get; } = 0;
        }
    }
}
