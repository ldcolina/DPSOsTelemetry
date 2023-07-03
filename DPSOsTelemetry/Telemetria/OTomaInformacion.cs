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
            //[JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime time { get; set; }

            public string token { set; get; } = string.Empty;

            public string pozoId { set; get; } = string.Empty;

            public CTomaBasica datosOperativos { set; get; } = new CTomaBasica();
        }

        public class CTomaBasica
        {
            public decimal presionTuberiaProduccion { get; set; } = 0;

            public decimal presionTuberiaRevestimiento { get; set; } = 0;

            public decimal presionAperturaCampo { get; set; } = 0;

            public decimal presionLineaDescarga { get; set; } = 0;

            public decimal temperaturaSuperficie { get; set; } = 0;

            public decimal sumergenciaEfectivaBomba { get; set; } = 0;

            public decimal nivelFluidoPozoTp { get; set; } = 0;

            public decimal nivelFluidoPozoTr { get; set; } = 0;

            public decimal presionEntradaBomba { get; set; } = 0;

            public decimal velocidadBomba { get; set; } = 0;

            public decimal velocidadUnidadBombeo { get; set; } = 0;

            public decimal frecuenciaOperacionBomba { get; set; } = 0;

            public decimal velocidadMotor { get; set; } = 0;

            public decimal longitudCarrera { get; set; } = 0;

            public decimal presionDisponible { get; set; } = 0;

            public decimal gastoInyeccionFluidoPotencia { get; set; } = 0;

            public decimal gravedadEspecificaFluidoPotencia { get; set; } = 0;

            public decimal gastoGasInyeccion { get; set; } = 0;

            public decimal gravedadEspecificaGasInyeccion { get; set; } = 0;

            public decimal torque { get; set; } = 0;

            public decimal corriente { get; set; } = 0;

            public decimal diametroEstrangulador { get; set; } = 0;

            public decimal tiempoCiclo { get; set; } = 0;

            public decimal tiempoRecuperacion { get; set; } = 0;

            public decimal tiempoInyeccion { get; set; } = 0;

            public decimal tiempoDesplazamientoTapon { get; set; } = 0;

            public decimal eficienciaLlenado { get; set; } = 0;
        }
    }
}
