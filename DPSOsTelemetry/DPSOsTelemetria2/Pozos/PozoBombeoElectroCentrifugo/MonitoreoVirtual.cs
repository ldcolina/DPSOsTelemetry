using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Pozos.PozoBombeoElectroCentrifugo
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

            #region PresionTuberiaProduccion

            //PresionTuberiaProduccion.Text = $"{Languages.Pozo.PresionTuberiaProduccion}:\n{DatosOperativos.PresionTuberiaProduccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            //PresionTuberiaRevestimiento.Text = $"{Languages.Pozo.PresionTuberiaRevestimiento}:\n{DatosOperativos.PresionTuberiaRevestimiento.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionTuberiaRevestimiento

            #region PresionAperturaCampo

            //PresionAperturaCampo.Text = $"{Languages.Pozo.PresionAperturaCampo}:\n{DatosOperativos.PresionAperturaCampo.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionAperturaCampo

            #region PresionLineaDescarga

            //PresionLineaDescarga.Text = $"{Languages.Pozo.PresionLineaDescarga}:\n{DatosOperativos.PresionLineaDescarga.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            //TemperaturaSuperficie.Text = $"{Languages.Pozo.TemperaturaSuperficie}:\n{DatosOperativos.TemperaturaSuperficie.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Temperatura, _Telemetria.Unidades)}";

            #endregion TemperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //sumergenciaEfectivaBomba.Text = $"{Languages.Pozo.sumergenciaEfectivaBomba}:\n{DatosOperativos.SumergenciaEfectivaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion sumergenciaEfectivaBomba

            #region NivelFluidoPozoTp

            //NivelFluidoPozoTp.Text = $"{Languages.Pozo.NivelFluidoPozoTp}:\n{DatosOperativos.NivelFluidoPozoTp.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion NivelFluidoPozoTp

            #region NivelFluidoPozoTr

            //NivelFluidoPozoTr.Text = $"{Languages.Pozo.NivelFluidoPozoTr}:\n{DatosOperativos.NivelFluidoPozoTr.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            //PresionEntradaBomba.Text = $"{Languages.Pozo.PresionEntradaBomba}:\n{DatosOperativos.PresionEntradaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionEntradaBomba

            #region VelocidadBomba

            //VelocidadBomba.Text = $"{Languages.Pozo.VelocidadBomba}:\n{DatosOperativos.VelocidadBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Velocidad, _Telemetria.Unidades)}";

            #endregion VelocidadBomba

            #region VelocidadUnidadBombeo

            //VelocidadUnidadBombeo.Text = $"{Languages.Pozo.VelocidadUnidadBombeo}:\n{DatosOperativos.VelocidadUnidadBombeo.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Embolada, _Telemetria.Unidades)}";

            #endregion VelocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //frecuenciaOperacionBomba.Text = $"{Languages.Pozo.frecuenciaOperacionBomba}:\n{DatosOperativos.FrecuenciaOperacionBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Frecuencia, _Telemetria.Unidades)}";

            #endregion frecuenciaOperacionBomba

            #region VelocidadMotor

            //VelocidadMotor.Text = $"{Languages.Pozo.VelocidadMotor}:\n{DatosOperativos.VelocidadMotor.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Velocidad, _Telemetria.Unidades)}";

            #endregion VelocidadMotor

            #region LongitudCarrera

            //LongitudCarrera.Text = $"{Languages.Pozo.LongitudCarrera}:\n{DatosOperativos.LongitudCarrera.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion LongitudCarrera

            #region PresionDisponible

            //PresionDisponible.Text = $"{Languages.Pozo.PresionDisponible}:\n{DatosOperativos.PresionDisponible.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionDisponible

            #region gastoInyeccionFluidoPotencia

            //gastoInyeccionFluidoPotencia.Text = $"{Languages.Pozo.GastoInyeccionFluidoPotencia}:\n{DatosOperativos.GastoInyeccionFluidoPotencia.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.GastoGas, _Telemetria.Unidades)}";

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //gravedadEspecificaFluidoPotencia.Text = $"{Languages.Pozo.GravedadEspecificaFluidoPotencia}:\n{DatosOperativos.GravedadEspecificaFluidoPotencia.ToString($"n{decimales}")}";

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //gastoGasInyeccion.Text = $"{Languages.Pozo.GastoGasInyeccion}:\n{DatosOperativos.GastoGasInyeccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.GastoGas, _Telemetria.Unidades)}";

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //gravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.GravedadEspecificaGasInyeccion}:\n{DatosOperativos.GravedadEspecificaGasInyeccion.ToString($"n{decimales}")}";

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //torque.Text = $"{Languages.Pozo.torque}:\n{DatosOperativos.Torque.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Torque, _Telemetria.Unidades)}";

            #endregion torque

            #region corriente

            //corriente.Text = $"{Languages.Pozo.corriente}:\n{DatosOperativos.Corriente.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Corriente, _Telemetria.Unidades)}";

            #endregion corriente

            #region diametroEstrangulador

            //diametroEstrangulador.Text = $"{Languages.Pozo.diametroEstrangulador}:\n{DatosOperativos.DiametroEstrangulador.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Diametro, _Telemetria.Unidades)}";

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //tiempoCiclo.Text = $"{Languages.Pozo.tiempoCiclo}:\n{DatosOperativos.TiempoCiclo.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //tiempoRecuperacion.Text = $"{Languages.Pozo.tiempoRecuperacion}:\n{DatosOperativos.TiempoRecuperacion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //tiempoInyeccion.Text = $"{Languages.Pozo.tiempoInyeccion}:\n{DatosOperativos.TiempoInyeccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //tiempoDesplazamientoTapon.Text = $"{Languages.Pozo.tiempoDesplazamientoTapon}:\n{DatosOperativos.TiempoDesplazamientoTapon.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Segundo, _Telemetria.Unidades)}";

            #endregion tiempoDesplazamientoTapon

            #region EficienciaLlenado

            //EficienciaLlenado.Text = $"{Languages.Pozo.EficienciaLlenado}:\n{DatosOperativos.EficienciaLlenado.ToString($"n{decimales}")} { Configuracion.GetSigla(Referencia.Porcentaje, _Telemetria.Unidades)}";

            #endregion EficienciaLlenado

            #region Temporizador

            //DatosOperativosSends.Text = $"{Languages.Pozo.Envio}: {_Telemetria.DatosOperativosSends}";
            //DatosOperativosComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetria.DatosOperativosComplete}";
            //DatosOperativosFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetria.DatosOperativosFails}";
            //if (_Telemetria.Range.DatosOperativos.TotalSeconds != 0)
            //this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.DatosOperativosTime.AddSeconds(_Telemetria.Range.DatosOperativos.TotalSeconds).ToLocalTime():G}";
            //else
            //this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion DatosOperativos
        }
    }
}
