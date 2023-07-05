using Languages;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Pozos.PozoBombeoNeumatico
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

            PresionTuberiaProduccion.Text = $"{Languages.Pozo.PresionTuberiaProduccion}:\n{DatosOperativos.PresionTuberiaProduccion.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            PresionTuberiaRevestimiento.Text = $"{Languages.Pozo.PresionTuberiaRevestimiento}:\n{DatosOperativos.PresionTuberiaRevestimiento.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionTuberiaRevestimiento

            #region PresionLineaDescarga

            PresionLineaDescarga.Text = $"{Languages.Pozo.PresionLineaDescarga}:\n{DatosOperativos.PresionLineaDescarga.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            TemperaturaSuperficie.Text = $"{Languages.Pozo.TemperaturaSuperficie}:\n{DatosOperativos.TemperaturaSuperficie.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Temperatura, _Telemetria.Unidades)}";

            #endregion TemperaturaSuperficie

            #region PresionDisponible

            PresionDisponible.Text = $"{Languages.Pozo.PresionDisponible}:\n{DatosOperativos.PresionDisponible.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionDisponible

            #region gastoGasInyeccion

            gastoGasInyeccion.Text = $"{Languages.Pozo.GastoGasInyeccion}:\n{DatosOperativos.GastoGasInyeccion.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.GastoGas, _Telemetria.Unidades)}";

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            gravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.GravedadEspecificaGasInyeccion}:\n{DatosOperativos.GravedadEspecificaGasInyeccion.ToString($"n{decimales}")}";

            #endregion gravedadEspecificaGasInyeccion

            #region Temporizador

            DatosOperativosSends.Text = $"{Languages.Pozo.Envio}: {_Telemetria.DatosOperativosSends}";
            DatosOperativosComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetria.DatosOperativosComplete}";
            DatosOperativosFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetria.DatosOperativosFails}";
            if (_Telemetria.Range.DatosOperativos.TotalSeconds != 0)
                this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.DatosOperativosTime.AddSeconds(_Telemetria.Range.DatosOperativos.TotalSeconds).ToLocalTime():G}";
            else
                this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion DatosOperativos
        }
    }
}
