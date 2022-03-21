using Telemetria;
using System.Windows.Forms;

namespace DPSOsTelemetria2.Pozos.PozoBombeoFluyente
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

            #region DoPresionTuberiaProduccion

            DoPresionTuberiaProduccion.Text = $"{Languages.Pozo.DoPresionTuberiaProduccion}:\n{DatosOperativos.DoPresionTuberiaProduccion.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            DoPresionTuberiaRevestimiento.Text = $"{Languages.Pozo.DoPresionTuberiaRevestimiento}:\n{DatosOperativos.DoPresionTuberiaRevestimiento.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionLineaDescarga

            DoPresionLineaDescarga.Text = $"{Languages.Pozo.DoPresionLineaDescarga}:\n{DatosOperativos.DoPresionLineaDescarga.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            DoTemperaturaSuperficie.Text = $"{Languages.Pozo.DoTemperaturaSuperficie}:\n{DatosOperativos.DoTemperaturaSuperficie.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Temperatura, _Telemetria.Unidades)}";

            #endregion DoTemperaturaSuperficie

            #region DoPresionDisponible

            DoPresionDisponible.Text = $"{Languages.Pozo.DoPresionDisponible}:\n{DatosOperativos.DoPresionDisponible.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionDisponible

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