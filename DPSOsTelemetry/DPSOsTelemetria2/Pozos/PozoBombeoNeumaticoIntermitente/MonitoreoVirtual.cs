using Telemetria;

using System;

namespace DPSOsTelemetria2.Pozos.PozoBombeoNeumaticoIntermitente
{
    public partial class MonitoreoVirtual : System.Windows.Forms.UserControl
    {
        public MonitoreoVirtual()

        {
            InitializeComponent();
        }

        internal void Recargar(int decimales, ReferenciasI _Telemetria)
        {
            #region DatosOperativos

            OTomaInformacion.CTomaBasica DatosOperativos = _Telemetria.DatosOperativos;

            #region DoPresionTuberiaProduccion

            //DoPresionTuberiaProduccion.Text = $"{Languages.Pozo.DoPresionTuberiaProduccion}:\n{DatosOperativos.DoPresionTuberiaProduccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            //DoPresionTuberiaRevestimiento.Text = $"{Languages.Pozo.DoPresionTuberiaRevestimiento}:\n{DatosOperativos.DoPresionTuberiaRevestimiento.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionAperturaCampo

            //DoPresionAperturaCampo.Text = $"{Languages.Pozo.DoPresionAperturaCampo}:\n{DatosOperativos.DoPresionAperturaCampo.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionAperturaCampo

            #region DoPresionLineaDescarga

            //DoPresionLineaDescarga.Text = $"{Languages.Pozo.DoPresionLineaDescarga}:\n{DatosOperativos.DoPresionLineaDescarga.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            //DoTemperaturaSuperficie.Text = $"{Languages.Pozo.DoTemperaturaSuperficie}:\n{DatosOperativos.DoTemperaturaSuperficie.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Temperatura, _Telemetria.Unidades)}";

            #endregion DoTemperaturaSuperficie

            #region DoSumergenciaEfectivaBomba

            //DoSumergenciaEfectivaBomba.Text = $"{Languages.Pozo.DoSumergenciaEfectivaBomba}:\n{DatosOperativos.DoSumergenciaEfectivaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Distancia, _Telemetria.Unidades)}";

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTp

            //DoNivelFluidoPozoTp.Text = $"{Languages.Pozo.DoNivelFluidoPozoTp}:\n{DatosOperativos.DoNivelFluidoPozoTp.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Distancia, _Telemetria.Unidades)}";

            #endregion DoNivelFluidoPozoTp

            #region DoNivelFluidoPozoTr

            //DoNivelFluidoPozoTr.Text = $"{Languages.Pozo.DoNivelFluidoPozoTr}:\n{DatosOperativos.DoNivelFluidoPozoTr.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Distancia, _Telemetria.Unidades)}";

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            //DoPresionEntradaBomba.Text = $"{Languages.Pozo.DoPresionEntradaBomba}:\n{DatosOperativos.DoPresionEntradaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionEntradaBomba

            #region DoVelocidadBomba

            //DoVelocidadBomba.Text = $"{Languages.Pozo.DoVelocidadBomba}:\n{DatosOperativos.DoVelocidadBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Velocidad, _Telemetria.Unidades)}";

            #endregion DoVelocidadBomba

            #region DoVelocidadUnidadBombeo

            //DoVelocidadUnidadBombeo.Text = $"{Languages.Pozo.DoVelocidadUnidadBombeo}:\n{DatosOperativos.DoVelocidadUnidadBombeo.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Embolada, _Telemetria.Unidades)}";

            #endregion DoVelocidadUnidadBombeo

            #region DoFrecuenciaOperacionBomba

            //DoFrecuenciaOperacionBomba.Text = $"{Languages.Pozo.DoFrecuenciaOperacionBomba}:\n{DatosOperativos.DoFrecuenciaOperacionBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Frecuencia, _Telemetria.Unidades)}";

            #endregion DoFrecuenciaOperacionBomba

            #region DoVelocidadMotor

            //DoVelocidadMotor.Text = $"{Languages.Pozo.DoVelocidadMotor}:\n{DatosOperativos.DoVelocidadMotor.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Velocidad, _Telemetria.Unidades)}";

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            //DoLongitudCarrera.Text = $"{Languages.Pozo.DoLongitudCarrera}:\n{DatosOperativos.DoLongitudCarrera.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Distancia, _Telemetria.Unidades)}";

            #endregion DoLongitudCarrera

            #region DoPresionDisponible

            //DoPresionDisponible.Text = $"{Languages.Pozo.DoPresionDisponible}:\n{DatosOperativos.DoPresionDisponible.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionDisponible

            #region DoGastoInyeccionFluidoPotencia

            //DoGastoInyeccionFluidoPotencia.Text = $"{Languages.Pozo.DoGastoInyeccionFluidoPotencia}:\n{DatosOperativos.DoGastoInyeccionFluidoPotencia.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.GastoGas, _Telemetria.Unidades)}";

            #endregion DoGastoInyeccionFluidoPotencia

            #region DoGravedadEspecificaFluidoPotencia

            //DoGravedadEspecificaFluidoPotencia.Text = $"{Languages.Pozo.DoGravedadEspecificaFluidoPotencia}:\n{DatosOperativos.DoGravedadEspecificaFluidoPotencia.ToString($"n{decimales}")}";

            #endregion DoGravedadEspecificaFluidoPotencia

            #region DoGastoGasInyeccion

            //DoGastoGasInyeccion.Text = $"{Languages.Pozo.DoGastoGasInyeccion}:\n{DatosOperativos.DoGastoGasInyeccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.GastoGas, _Telemetria.Unidades)}";

            #endregion DoGastoGasInyeccion

            #region DoGravedadEspecificaGasInyeccion

            //DoGravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.DoGravedadEspecificaGasInyeccion}:\n{DatosOperativos.DoGravedadEspecificaGasInyeccion.ToString($"n{decimales}")}";

            #endregion DoGravedadEspecificaGasInyeccion

            #region DoTorque

            //DoTorque.Text = $"{Languages.Pozo.DoTorque}:\n{DatosOperativos.DoTorque.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Torque, _Telemetria.Unidades)}";

            #endregion DoTorque

            #region DoCorriente

            //DoCorriente.Text = $"{Languages.Pozo.DoCorriente}:\n{DatosOperativos.DoCorriente.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Corriente, _Telemetria.Unidades)}";

            #endregion DoCorriente

            #region DoDiametroEstrangulador

            //DoDiametroEstrangulador.Text = $"{Languages.Pozo.DoDiametroEstrangulador}:\n{DatosOperativos.DoDiametroEstrangulador.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Diametro, _Telemetria.Unidades)}";

            #endregion DoDiametroEstrangulador

            #region DoTiempoCiclo

            //DoTiempoCiclo.Text = $"{Languages.Pozo.DoTiempoCiclo}:\n{DatosOperativos.DoTiempoCiclo.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Segundo, _Telemetria.Unidades)}";

            #endregion DoTiempoCiclo

            #region DoTiempoRecuperacion

            //DoTiempoRecuperacion.Text = $"{Languages.Pozo.DoTiempoRecuperacion}:\n{DatosOperativos.DoTiempoRecuperacion.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Segundo, _Telemetria.Unidades)}";

            #endregion DoTiempoRecuperacion

            #region DoTiempoInyeccion

            //DoTiempoInyeccion.Text = $"{Languages.Pozo.DoTiempoInyeccion}:\n{DatosOperativos.DoTiempoInyeccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Segundo, _Telemetria.Unidades)}";

            #endregion DoTiempoInyeccion

            #region DoTiempoDesplazamientoTapon

            //DoTiempoDesplazamientoTapon.Text = $"{Languages.Pozo.DoTiempoDesplazamientoTapon}:\n{DatosOperativos.DoTiempoDesplazamientoTapon.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Segundo, _Telemetria.Unidades)}";

            #endregion DoTiempoDesplazamientoTapon

            #region DoEficienciaLlenado

            //DoEficienciaLlenado.Text = $"{Languages.Pozo.DoEficienciaLlenado}:\n{DatosOperativos.DoEficienciaLlenado.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Porcentaje, _Telemetria.Unidades)}";

            #endregion DoEficienciaLlenado

            #region Temporizador

            //DatosOperativosSends.Text = $"{Languages.Pozo.Envio}: {_Telemetria.DatosOperativosSends}";
            //DatosOperativosComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetria.DatosOperativosComplete}";
            //DatosOperativosFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetria.DatosOperativosFails}";
            //if (_Telemetria.Range.DatosOperativos.TotalMilliseconds != 0)
            //this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.Started.AddMilliseconds(_Telemetria.Range.DatosOperativos.TotalMilliseconds * _Telemetria.DatosOperativosSends).ToLocalTime():G}";
            //else
            //this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion DatosOperativos

            #region CartaDinagrafica

            //OCartaDinagrafica.CCartaDinagrafica CCartaDinagrafica = _Telemetria.CartaDinagrafica;

            //CCartaDinagrafica.Text = $"{Languages.Pozo.CCartaDinagrafica}: {DatosOperativos.xxx.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Longitud_Carta, _Telemetria.Unidades)}/{ Configuracion.GetSigla(Siglas.Fuerza, _Telemetria.Unidades)}";

            #region Temporizador

            //CartaDinagraficaSends.Text = $"{Languages.Pozo.Envio}: {_Telemetria.CartaDinagraficaSends}";
            //CartaDinagraficaComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetria.CartaDinagraficaComplete}";
            //CartaDinagraficaFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetria.CartaDinagraficaFails}";
            //if (_Telemetria.Range.CartaDinagrafica.TotalMilliseconds != 0)
            //    CartaDinagrafica.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.Started.AddMilliseconds(_Telemetria.Range.CartaDinagrafica.TotalMilliseconds * _Telemetria.CartaDinagraficaSends).ToLocalTime():G}";
            //else
            //    CartaDinagrafica.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion CartaDinagrafica
        }

        private void MonitoreoVirtual_Load(object sender, EventArgs e)
        {
        }
    }
}