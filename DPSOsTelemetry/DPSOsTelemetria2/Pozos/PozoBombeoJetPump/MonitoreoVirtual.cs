using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Pozos.PozoBombeoJetPump
{
    public partial class MonitoreoVirtual : UserControl
    {
        public MonitoreoVirtual()

        {
            InitializeComponent();
        }

        internal void Recargar(int decimales, ReferenciasI _Telemetria)
        {
            #region DatosOperativos

            OTomaInformacion.CTomaBasica DatosOperativos = _Telemetria.DatosOperativos;

            #region presionTuberiaProduccion

            //presionTuberiaProduccion.Text = $"{Languages.Pozo.presionTuberiaProduccion}:\n{DatosOperativos.presionTuberiaProduccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            //presionTuberiaRevestimiento.Text = $"{Languages.Pozo.presionTuberiaRevestimiento}:\n{DatosOperativos.presionTuberiaRevestimiento.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionTuberiaRevestimiento

            #region presionAperturaCampo

            //presionAperturaCampo.Text = $"{Languages.Pozo.presionAperturaCampo}:\n{DatosOperativos.presionAperturaCampo.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionAperturaCampo

            #region presionLineaDescarga

            //presionLineaDescarga.Text = $"{Languages.Pozo.presionLineaDescarga}:\n{DatosOperativos.presionLineaDescarga.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            //temperaturaSuperficie.Text = $"{Languages.Pozo.temperaturaSuperficie}:\n{DatosOperativos.temperaturaSuperficie.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Temperatura, _Telemetria.Unidades)}";

            #endregion temperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //sumergenciaEfectivaBomba.Text = $"{Languages.Pozo.sumergenciaEfectivaBomba}:\n{DatosOperativos.sumergenciaEfectivaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTp

            //nivelFluidoPozoTp.Text = $"{Languages.Pozo.nivelFluidoPozoTp}:\n{DatosOperativos.nivelFluidoPozoTp.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion nivelFluidoPozoTp

            #region nivelFluidoPozoTr

            //nivelFluidoPozoTr.Text = $"{Languages.Pozo.nivelFluidoPozoTr}:\n{DatosOperativos.nivelFluidoPozoTr.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            //presionEntradaBomba.Text = $"{Languages.Pozo.presionEntradaBomba}:\n{DatosOperativos.presionEntradaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionEntradaBomba

            #region velocidadBomba

            //velocidadBomba.Text = $"{Languages.Pozo.velocidadBomba}:\n{DatosOperativos.velocidadBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Velocidad, _Telemetria.Unidades)}";

            #endregion velocidadBomba

            #region velocidadUnidadBombeo

            //velocidadUnidadBombeo.Text = $"{Languages.Pozo.velocidadUnidadBombeo}:\n{DatosOperativos.velocidadUnidadBombeo.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Embolada, _Telemetria.Unidades)}";

            #endregion velocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //frecuenciaOperacionBomba.Text = $"{Languages.Pozo.frecuenciaOperacionBomba}:\n{DatosOperativos.frecuenciaOperacionBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Frecuencia, _Telemetria.Unidades)}";

            #endregion frecuenciaOperacionBomba

            #region velocidadMotor

            //velocidadMotor.Text = $"{Languages.Pozo.velocidadMotor}:\n{DatosOperativos.velocidadMotor.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Velocidad, _Telemetria.Unidades)}";

            #endregion velocidadMotor

            #region longitudCarrera

            //longitudCarrera.Text = $"{Languages.Pozo.longitudCarrera}:\n{DatosOperativos.longitudCarrera.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion longitudCarrera

            #region presionDisponible

            //presionDisponible.Text = $"{Languages.Pozo.presionDisponible}:\n{DatosOperativos.presionDisponible.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionDisponible

            #region gastoInyeccionFluidoPotencia

            //gastoInyeccionFluidoPotencia.Text = $"{Languages.Pozo.gastoInyeccionFluidoPotencia}:\n{DatosOperativos.gastoInyeccionFluidoPotencia.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.GastoGas, _Telemetria.Unidades)}";

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //gravedadEspecificaFluidoPotencia.Text = $"{Languages.Pozo.gravedadEspecificaFluidoPotencia}:\n{DatosOperativos.gravedadEspecificaFluidoPotencia.ToString($"n{decimales}")}";

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //gastoGasInyeccion.Text = $"{Languages.Pozo.gastoGasInyeccion}:\n{DatosOperativos.gastoGasInyeccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.GastoGas, _Telemetria.Unidades)}";

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //gravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.gravedadEspecificaGasInyeccion}:\n{DatosOperativos.gravedadEspecificaGasInyeccion.ToString($"n{decimales}")}";

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //torque.Text = $"{Languages.Pozo.torque}:\n{DatosOperativos.torque.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Torque, _Telemetria.Unidades)}";

            #endregion torque

            #region corriente

            //corriente.Text = $"{Languages.Pozo.corriente}:\n{DatosOperativos.corriente.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Corriente, _Telemetria.Unidades)}";

            #endregion corriente

            #region diametroEstrangulador

            //diametroEstrangulador.Text = $"{Languages.Pozo.diametroEstrangulador}:\n{DatosOperativos.diametroEstrangulador.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Diametro, _Telemetria.Unidades)}";

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //tiempoCiclo.Text = $"{Languages.Pozo.tiempoCiclo}:\n{DatosOperativos.tiempoCiclo.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //tiempoRecuperacion.Text = $"{Languages.Pozo.tiempoRecuperacion}:\n{DatosOperativos.tiempoRecuperacion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //tiempoInyeccion.Text = $"{Languages.Pozo.tiempoInyeccion}:\n{DatosOperativos.tiempoInyeccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //tiempoDesplazamientoTapon.Text = $"{Languages.Pozo.tiempoDesplazamientoTapon}:\n{DatosOperativos.tiempoDesplazamientoTapon.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoDesplazamientoTapon

            #region eficienciaLlenado

            //eficienciaLlenado.Text = $"{Languages.Pozo.eficienciaLlenado}:\n{DatosOperativos.eficienciaLlenado.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Porcentaje, _Telemetria.Unidades)}";

            #endregion eficienciaLlenado

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
        }
    }
}
