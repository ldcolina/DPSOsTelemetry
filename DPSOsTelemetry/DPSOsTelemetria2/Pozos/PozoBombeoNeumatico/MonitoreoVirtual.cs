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

            #region presionTuberiaProduccion

            presionTuberiaProduccion.Text = $"{Languages.Pozo.presionTuberiaProduccion}:\n{DatosOperativos.presionTuberiaProduccion.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            presionTuberiaRevestimiento.Text = $"{Languages.Pozo.presionTuberiaRevestimiento}:\n{DatosOperativos.presionTuberiaRevestimiento.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionTuberiaRevestimiento

            #region presionLineaDescarga

            presionLineaDescarga.Text = $"{Languages.Pozo.presionLineaDescarga}:\n{DatosOperativos.presionLineaDescarga.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            temperaturaSuperficie.Text = $"{Languages.Pozo.temperaturaSuperficie}:\n{DatosOperativos.temperaturaSuperficie.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Temperatura, _Telemetria.Unidades)}";

            #endregion temperaturaSuperficie

            #region presionDisponible

            presionDisponible.Text = $"{Languages.Pozo.presionDisponible}:\n{DatosOperativos.presionDisponible.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionDisponible

            #region gastoGasInyeccion

            gastoGasInyeccion.Text = $"{Languages.Pozo.gastoGasInyeccion}:\n{DatosOperativos.gastoGasInyeccion.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.GastoGas, _Telemetria.Unidades)}";

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            gravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.gravedadEspecificaGasInyeccion}:\n{DatosOperativos.gravedadEspecificaGasInyeccion.ToString($"n{decimales}")}";

            #endregion gravedadEspecificaGasInyeccion

            #region Temporizador

            DatosOperativosSends.Text = $"{Languages.Pozo.Envio}: {_Telemetria.DatosOperativosSends}";
            DatosOperativosComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetria.DatosOperativosComplete}";
            DatosOperativosFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetria.DatosOperativosFails}";
            if (_Telemetria.Range.DatosOperativos.TotalMilliseconds != 0)
                this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.Started.AddMilliseconds(_Telemetria.Range.DatosOperativos.TotalMilliseconds * _Telemetria.DatosOperativosSends).ToLocalTime():G}";
            else
                this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion DatosOperativos
        }
    }
}
