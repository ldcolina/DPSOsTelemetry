using System;
using System.Collections.Generic;

namespace Telemetria
{
    public class Referencias
    {
        public string Name { set; get; } = string.Empty;

        public TomaBasica Range { set; get; } = new TomaBasica();

        public string Token { set; get; } = string.Empty;

        public string Type { set; get; } = "None";

        public string Unidades { set; get; } = "None";
    }

    public class ReferenciasI : Referencias
    {
        public DateTime Started { get; set; }

        public OCartaDinagrafica.CCartaDinagrafica CartaDinagrafica { set; get; } = new OCartaDinagrafica.CCartaDinagrafica();

        public DateTime CartaDinagraficaTime { get; set; }

        public int CartaDinagraficaComplete { get; set; }

        public int CartaDinagraficaFails { get; set; }

        public int CartaDinagraficaSends { get; set; }

        public OTomaInformacion.CTomaBasica DatosOperativos { set; get; } = new OTomaInformacion.CTomaBasica();

        public DateTime DatosOperativosTime { get; set; }

        public int DatosOperativosComplete { get; set; }

        public int DatosOperativosFails { get; set; }

        public int DatosOperativosSends { get; set; }
    }

    public class ReferenciasII : Referencias
    {
        public DateTime Date { get; set; }

        public string ID { get; set; }
    }

    public class TomaBasica
    {
        #region OTomaInformacion

        #region CargaSobreBarraPulida

        public bool CargaSobreBarraPulida { set; get; } = false;

        public decimal CargaSobreBarraPulidaMax { set; get; } = 0;

        public decimal CargaSobreBarraPulidaMin { set; get; } = 0;

        #endregion CargaSobreBarraPulida

        #region Corriente

        public bool Corriente { set; get; } = false;

        public decimal CorrienteMax { set; get; } = 0;

        public decimal CorrienteMin { set; get; } = 0;

        #endregion Corriente

        #region DiametroEstrangulador

        public bool DiametroEstrangulador { set; get; } = false;

        public decimal DiametroEstranguladorMax { set; get; } = 0;

        public decimal DiametroEstranguladorMin { set; get; } = 0;

        #endregion DiametroEstrangulador

        #region EficienciaLlenado

        public bool EficienciaLlenado { set; get; } = false;

        public decimal EficienciaLlenadoMax { set; get; } = 0;

        public decimal EficienciaLlenadoMin { set; get; } = 0;

        #endregion EficienciaLlenado

        #region Emulsion

        public bool Emulsion { set; get; } = false;

        public decimal EmulsionMax { set; get; } = 0;

        public decimal EmulsionMin { set; get; } = 0;

        #endregion Emulsion

        #region FrecuenciaOperacionBomba

        public bool FrecuenciaOperacionBomba { set; get; } = false;

        public decimal FrecuenciaOperacionBombaMax { set; get; } = 0;

        public decimal FrecuenciaOperacionBombaMin { set; get; } = 0;

        #endregion FrecuenciaOperacionBomba

        #region GastoAceite

        public bool GastoAceite { set; get; } = false;

        public decimal GastoAceiteMax { set; get; } = 0;

        public decimal GastoAceiteMin { set; get; } = 0;

        #endregion GastoAceite

        #region GastoGas

        public bool GastoGas { set; get; } = false;

        public decimal GastoGasMax { set; get; } = 0;

        public decimal GastoGasMin { set; get; } = 0;

        #endregion GastoGas

        #region GastoGasInyeccion

        public bool GastoGasInyeccion { set; get; } = false;

        public decimal GastoGasInyeccionMax { set; get; } = 0;

        public decimal GastoGasInyeccionMin { set; get; } = 0;

        #endregion GastoGasInyeccion

        #region GastoInyeccionFluidoPotencia

        public bool GastoInyeccionFluidoPotencia { set; get; } = false;

        public decimal GastoInyeccionFluidoPotenciaMax { set; get; } = 0;

        public decimal GastoInyeccionFluidoPotenciaMin { set; get; } = 0;

        #endregion GastoInyeccionFluidoPotencia

        #region GastoLiquido

        public bool GastoLiquido { set; get; } = false;

        public decimal GastoLiquidoMax { set; get; } = 0;

        public decimal GastoLiquidoMin { set; get; } = 0;

        #endregion GastoLiquido

        #region GastoLiquidoPruebaProduccion

        public bool GastoLiquidoPruebaProduccion { set; get; } = false;

        public decimal GastoLiquidoPruebaProduccionMax { set; get; } = 0;

        public decimal GastoLiquidoPruebaProduccionMin { set; get; } = 0;

        #endregion GastoLiquidoPruebaProduccion

        #region GravedadEspecificaFluidoPotencia

        public bool GravedadEspecificaFluidoPotencia { set; get; } = false;

        public decimal GravedadEspecificaFluidoPotenciaMax { set; get; } = 0;

        public decimal GravedadEspecificaFluidoPotenciaMin { set; get; } = 0;

        #endregion GravedadEspecificaFluidoPotencia

        #region GravedadEspecificaGasInyeccion

        public bool GravedadEspecificaGasInyeccion { set; get; } = false;

        public decimal GravedadEspecificaGasInyeccionMax { set; get; } = 0;

        public decimal GravedadEspecificaGasInyeccionMin { set; get; } = 0;

        #endregion GravedadEspecificaGasInyeccion

        #region GravedadEspecificaGasProducido

        public bool GravedadEspecificaGasProducido { set; get; } = false;

        public decimal GravedadEspecificaGasProducidoMax { set; get; } = 0;

        public decimal GravedadEspecificaGasProducidoMin { set; get; } = 0;

        #endregion GravedadEspecificaGasProducido

        #region GravedadPetroleo

        public bool GravedadPetroleo { set; get; } = false;

        public decimal GravedadPetroleoMax { set; get; } = 0;

        public decimal GravedadPetroleoMin { set; get; } = 0;

        #endregion GravedadPetroleo

        #region LongitudCarrera

        public bool LongitudCarrera { set; get; } = false;

        public decimal LongitudCarreraMax { set; get; } = 0;

        public decimal LongitudCarreraMin { set; get; } = 0;

        #endregion LongitudCarrera

        #region NivelFluidoPozoTp

        public bool NivelFluidoPozoTp { set; get; } = false;

        public decimal NivelFluidoPozoTpMax { set; get; } = 0;

        public decimal NivelFluidoPozoTpMin { set; get; } = 0;

        #endregion NivelFluidoPozoTp

        #region NivelFluidoPozoTr

        public bool NivelFluidoPozoTr { set; get; } = false;

        public decimal NivelFluidoPozoTrMax { set; get; } = 0;

        public decimal NivelFluidoPozoTrMin { set; get; } = 0;

        #endregion NivelFluidoPozoTr

        #region PorcentajeAguaSedimento

        public bool PorcentajeAguaSedimento { set; get; } = false;

        public decimal PorcentajeAguaSedimentoMax { set; get; } = 0;

        public decimal PorcentajeAguaSedimentoMin { set; get; } = 0;

        #endregion PorcentajeAguaSedimento

        #region PresionAperturaCampo

        public bool PresionAperturaCampo { set; get; } = false;

        public decimal PresionAperturaCampoMax { set; get; } = 0;

        public decimal PresionAperturaCampoMin { set; get; } = 0;

        #endregion PresionAperturaCampo

        #region PresionDisponible

        public bool PresionDisponible { set; get; } = false;

        public decimal PresionDisponibleMax { set; get; } = 0;

        public decimal PresionDisponibleMin { set; get; } = 0;

        #endregion PresionDisponible

        #region PresionEntradaBomba

        public bool PresionEntradaBomba { set; get; } = false;

        public decimal PresionEntradaBombaMax { set; get; } = 0;

        public decimal PresionEntradaBombaMin { set; get; } = 0;

        #endregion PresionEntradaBomba

        #region PresionLineaDescarga

        public bool PresionLineaDescarga { set; get; } = false;

        public decimal PresionLineaDescargaMax { set; get; } = 0;

        public decimal PresionLineaDescargaMin { set; get; } = 0;

        #endregion PresionLineaDescarga

        #region PresionTuberiaProduccion

        public bool PresionTuberiaProduccion { set; get; } = false;

        public decimal PresionTuberiaProduccionMax { set; get; } = 0;

        public decimal PresionTuberiaProduccionMin { set; get; } = 0;

        #endregion PresionTuberiaProduccion

        #region PresionTuberiaRevestimiento

        public bool PresionTuberiaRevestimiento { set; get; } = false;

        public decimal PresionTuberiaRevestimientoMax { set; get; } = 0;

        public decimal PresionTuberiaRevestimientoMin { set; get; } = 0;

        #endregion PresionTuberiaRevestimiento

        #region RelacionGasAceite

        public bool RelacionGasAceite { set; get; } = false;

        public decimal RelacionGasAceiteMax { set; get; } = 0;

        public decimal RelacionGasAceiteMin { set; get; } = 0;

        #endregion RelacionGasAceite

        #region SalinidadAgua

        public bool SalinidadAgua { set; get; } = false;

        public decimal SalinidadAguaMax { set; get; } = 0;

        public decimal SalinidadAguaMin { set; get; } = 0;

        #endregion SalinidadAgua

        #region SumergenciaEfectivaBomba

        public bool SumergenciaEfectivaBomba { set; get; } = false;

        public decimal SumergenciaEfectivaBombaMax { set; get; } = 0;

        public decimal SumergenciaEfectivaBombaMin { set; get; } = 0;

        #endregion SumergenciaEfectivaBomba

        #region TemperaturaSuperficie

        public bool TemperaturaSuperficie { set; get; } = false;

        public decimal TemperaturaSuperficieMax { set; get; } = 0;

        public decimal TemperaturaSuperficieMin { set; get; } = 0;

        #endregion TemperaturaSuperficie

        #region TiempoCiclo

        public bool TiempoCiclo { set; get; } = false;

        public decimal TiempoCicloMax { set; get; } = 0;

        public decimal TiempoCicloMin { set; get; } = 0;

        #endregion TiempoCiclo

        #region TiempoDesplazamientoTapon

        public bool TiempoDesplazamientoTapon { set; get; } = false;

        public decimal TiempoDesplazamientoTaponMax { set; get; } = 0;

        public decimal TiempoDesplazamientoTaponMin { set; get; } = 0;

        #endregion TiempoDesplazamientoTapon

        #region TiempoInyeccion

        public bool TiempoInyeccion { set; get; } = false;

        public decimal TiempoInyeccionMax { set; get; } = 0;

        public decimal TiempoInyeccionMin { set; get; } = 0;

        #endregion TiempoInyeccion

        #region TiempoRecuperacion

        public bool TiempoRecuperacion { set; get; } = false;

        public decimal TiempoRecuperacionMax { set; get; } = 0;

        public decimal TiempoRecuperacionMin { set; get; } = 0;

        #endregion TiempoRecuperacion

        #region Torque

        public bool Torque { set; get; } = false;

        public decimal TorqueMax { set; get; } = 0;

        public decimal TorqueMin { set; get; } = 0;

        #endregion Torque

        #region VelocidadBomba

        public bool VelocidadBomba { set; get; } = false;

        public decimal VelocidadBombaMax { set; get; } = 0;

        public decimal VelocidadBombaMin { set; get; } = 0;

        #endregion VelocidadBomba

        #region VelocidadMotor

        public bool VelocidadMotor { set; get; } = false;

        public decimal VelocidadMotorMax { set; get; } = 0;

        public decimal VelocidadMotorMin { set; get; } = 0;

        #endregion VelocidadMotor

        #region VelocidadUnidadBombeo

        public bool VelocidadUnidadBombeo { set; get; } = false;

        public decimal VelocidadUnidadBombeoMax { set; get; } = 0;

        public decimal VelocidadUnidadBombeoMin { set; get; } = 0;

        #endregion VelocidadUnidadBombeo

        #endregion OTomaInformacion

        #region OCartaDinagrafica

        public bool CCartaDinagrafica { get; set; } = false;

        public List<OCartaDinagrafica.CCartaDinagrafica> ListCCartaDinagrafica { get; set; } = new List<OCartaDinagrafica.CCartaDinagrafica>();

        #endregion OCartaDinagrafica

        #region Temporizador

        public TimeSpan CartaDinagrafica { get; set; } = TimeSpan.Zero;

        public TimeSpan DatosOperativos { get; set; } = TimeSpan.Zero;

        #endregion Temporizador
    }
}
