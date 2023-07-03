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

        public int CartaDinagraficaComplete { get; set; }

        public int CartaDinagraficaFails { get; set; }

        public int CartaDinagraficaSends { get; set; }

        public OTomaInformacion.CTomaBasica DatosOperativos { set; get; } = new OTomaInformacion.CTomaBasica();

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
        #region presionTuberiaProduccion

        public bool presionTuberiaProduccion { get; set; } = false;

        public decimal presionTuberiaProduccionMax { get; set; } = 0;

        public decimal presionTuberiaProduccionMin { get; set; } = 0;

        #endregion presionTuberiaProduccion

        #region presionTuberiaRevestimiento

        public bool presionTuberiaRevestimiento { get; set; } = false;

        public decimal presionTuberiaRevestimientoMax { get; set; } = 0;

        public decimal presionTuberiaRevestimientoMin { get; set; } = 0;

        #endregion presionTuberiaRevestimiento

        #region presionAperturaCampo

        public bool presionAperturaCampo { get; set; } = false;

        public decimal presionAperturaCampoMax { get; set; } = 0;

        public decimal presionAperturaCampoMin { get; set; } = 0;

        #endregion presionAperturaCampo

        #region presionLineaDescarga

        public bool presionLineaDescarga { get; set; } = false;

        public decimal presionLineaDescargaMax { get; set; } = 0;

        public decimal presionLineaDescargaMin { get; set; } = 0;

        #endregion presionLineaDescarga

        #region temperaturaSuperficie

        public bool temperaturaSuperficie { get; set; } = false;

        public decimal temperaturaSuperficieMax { get; set; } = 0;

        public decimal temperaturaSuperficieMin { get; set; } = 0;

        #endregion temperaturaSuperficie

        #region sumergenciaEfectivaBomba

        public bool sumergenciaEfectivaBomba { get; set; } = false;

        public decimal sumergenciaEfectivaBombaMax { get; set; } = 0;

        public decimal sumergenciaEfectivaBombaMin { get; set; } = 0;

        #endregion sumergenciaEfectivaBomba

        #region nivelFluidoPozoTp

        public bool nivelFluidoPozoTp { get; set; } = false;

        public decimal nivelFluidoPozoTpMax { get; set; } = 0;

        public decimal nivelFluidoPozoTpMin { get; set; } = 0;

        #endregion nivelFluidoPozoTp

        #region nivelFluidoPozoTr

        public bool nivelFluidoPozoTr { get; set; } = false;

        public decimal nivelFluidoPozoTrMax { get; set; } = 0;

        public decimal nivelFluidoPozoTrMin { get; set; } = 0;

        #endregion nivelFluidoPozoTr

        #region presionEntradaBomba

        public bool presionEntradaBomba { get; set; } = false;

        public decimal presionEntradaBombaMax { get; set; } = 0;

        public decimal presionEntradaBombaMin { get; set; } = 0;

        #endregion presionEntradaBomba

        #region velocidadBomba

        public bool velocidadBomba { get; set; } = false;

        public decimal velocidadBombaMax { get; set; } = 0;

        public decimal velocidadBombaMin { get; set; } = 0;

        #endregion velocidadBomba

        #region velocidadUnidadBombeo

        public bool velocidadUnidadBombeo { get; set; } = false;

        public decimal velocidadUnidadBombeoMax { get; set; } = 0;

        public decimal velocidadUnidadBombeoMin { get; set; } = 0;

        #endregion velocidadUnidadBombeo

        #region frecuenciaOperacionBomba

        public bool frecuenciaOperacionBomba { get; set; } = false;

        public decimal frecuenciaOperacionBombaMax { get; set; } = 0;

        public decimal frecuenciaOperacionBombaMin { get; set; } = 0;

        #endregion frecuenciaOperacionBomba

        #region velocidadMotor

        public bool velocidadMotor { get; set; } = false;

        public decimal velocidadMotorMax { get; set; } = 0;

        public decimal velocidadMotorMin { get; set; } = 0;

        #endregion velocidadMotor

        #region longitudCarrera

        public bool longitudCarrera { get; set; } = false;

        public decimal longitudCarreraMax { get; set; } = 0;

        public decimal longitudCarreraMin { get; set; } = 0;

        #endregion longitudCarrera

        #region presionDisponible

        public bool presionDisponible { get; set; } = false;

        public decimal presionDisponibleMax { get; set; } = 0;

        public decimal presionDisponibleMin { get; set; } = 0;

        #endregion presionDisponible

        #region gastoInyeccionFluidoPotencia

        public bool gastoInyeccionFluidoPotencia { get; set; } = false;

        public decimal gastoInyeccionFluidoPotenciaMax { get; set; } = 0;

        public decimal gastoInyeccionFluidoPotenciaMin { get; set; } = 0;

        #endregion gastoInyeccionFluidoPotencia

        #region gravedadEspecificaFluidoPotencia

        public bool gravedadEspecificaFluidoPotencia { get; set; } = false;

        public decimal gravedadEspecificaFluidoPotenciaMax { get; set; } = 0;

        public decimal gravedadEspecificaFluidoPotenciaMin { get; set; } = 0;

        #endregion gravedadEspecificaFluidoPotencia

        #region gastoGasInyeccion

        public bool gastoGasInyeccion { get; set; } = false;

        public decimal gastoGasInyeccionMax { get; set; } = 0;

        public decimal gastoGasInyeccionMin { get; set; } = 0;

        #endregion gastoGasInyeccion

        #region gravedadEspecificaGasInyeccion

        public bool gravedadEspecificaGasInyeccion { get; set; } = false;

        public decimal gravedadEspecificaGasInyeccionMax { get; set; } = 0;

        public decimal gravedadEspecificaGasInyeccionMin { get; set; } = 0;

        #endregion gravedadEspecificaGasInyeccion

        #region torque

        public bool torque { get; set; } = false;

        public decimal torqueMax { get; set; } = 0;

        public decimal torqueMin { get; set; } = 0;

        #endregion torque

        #region corriente

        public bool corriente { get; set; } = false;

        public decimal corrienteMax { get; set; } = 0;

        public decimal corrienteMin { get; set; } = 0;

        #endregion corriente

        #region diametroEstrangulador

        public bool diametroEstrangulador { get; set; } = false;

        public decimal diametroEstranguladorMax { get; set; } = 0;

        public decimal diametroEstranguladorMin { get; set; } = 0;

        #endregion diametroEstrangulador

        #region tiempoCiclo

        public bool tiempoCiclo { get; set; } = false;

        public decimal tiempoCicloMax { get; set; } = 0;

        public decimal tiempoCicloMin { get; set; } = 0;

        #endregion tiempoCiclo

        #region tiempoRecuperacion

        public bool tiempoRecuperacion { get; set; } = false;

        public decimal tiempoRecuperacionMax { get; set; } = 0;

        public decimal tiempoRecuperacionMin { get; set; } = 0;

        #endregion tiempoRecuperacion

        #region tiempoInyeccion

        public bool tiempoInyeccion { get; set; } = false;

        public decimal tiempoInyeccionMax { get; set; } = 0;

        public decimal tiempoInyeccionMin { get; set; } = 0;

        #endregion tiempoInyeccion

        #region tiempoDesplazamientoTapon

        public bool tiempoDesplazamientoTapon { get; set; } = false;

        public decimal tiempoDesplazamientoTaponMax { get; set; } = 0;

        public decimal tiempoDesplazamientoTaponMin { get; set; } = 0;

        #endregion tiempoDesplazamientoTapon

        #region eficienciaLlenado

        public bool eficienciaLlenado { get; set; } = false;

        public decimal eficienciaLlenadoMax { get; set; } = 0;

        public decimal eficienciaLlenadoMin { get; set; } = 0;

        #endregion eficienciaLlenado

        #region Temporizador

        public TimeSpan CartaDinagrafica { get; set; } = TimeSpan.Zero;

        public TimeSpan DatosOperativos { get; set; } = TimeSpan.Zero;

        #endregion Temporizador

        #region CCartaDinagrafica

        public bool CCartaDinagrafica { get; set; } = false;

        public List<OCartaDinagrafica.CCartaDinagrafica> ListCCartaDinagrafica { get; set; } = new List<OCartaDinagrafica.CCartaDinagrafica>();

        #endregion CCartaDinagrafica
    }
}
