﻿using Languages;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria.Pozos.PozoBombeoFluyente
{
    public partial class MonitoreoVirtual : UserControl
    {
        public MonitoreoVirtual()

        {
            InitializeComponent();
        }

        internal void Recargar(int decimales, List<ReferenciasI> _Telemetrias)
        {
            ReferenciasI _Telemetria = _Telemetrias.LastOrDefault();

            #region DatosManual

            OTomaInformacion.CTomaBasica DatosOperativos = _Telemetria.DatosOperativos;

            #region DatosOperativos

            tabPage3.Text = Languages.Pozo.OperativeData;

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

            #endregion DatosOperativos

            #region DatosProduccion

            tabPage4.Text = Languages.Pozo.ProductionData;

            #region GastoLiquidoPruebaProduccion

            GastoLiquidoPruebaProduccion.Text = $"{Languages.Pozo.GastoLiquidoPruebaProduccion}:\n{DatosOperativos.GastoLiquidoPruebaProduccion.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.FlujoVolumetricoLiquido, _Telemetria.Unidades)}";

            #endregion GastoLiquidoPruebaProduccion

            #region PorcentajeAguaSedimento

            PorcentajeAguaSedimento.Text = $"{Languages.Pozo.PorcentajeAguaSedimento}:\n{DatosOperativos.PorcentajeAguaSedimento.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Porcentaje, _Telemetria.Unidades)}";

            #endregion PorcentajeAguaSedimento

            #region GastoAceite

            GastoAceite.Text = $"{Languages.Pozo.GastoAceite}:\n{DatosOperativos.GastoAceite.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.FlujoVolumetricoLiquido, _Telemetria.Unidades)}";

            #endregion GastoAceite

            #region GastoGas

            GastoGas.Text = $"{Languages.Pozo.GastoGas}:\n{DatosOperativos.GastoGas.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.GastoGas, _Telemetria.Unidades)}";

            #endregion GastoGas

            #region GastoLiquido

            GastoLiquido.Text = $"{Languages.Pozo.GastoLiquido}:\n{DatosOperativos.GastoLiquido.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.FlujoVolumetricoLiquido, _Telemetria.Unidades)}";

            #endregion GastoLiquido

            #region RelacionGasAceite

            RelacionGasAceite.Text = $"{Languages.Pozo.RelacionGasAceite}:\n{DatosOperativos.RelacionGasAceite.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.RelacionGasAceite, _Telemetria.Unidades)}";

            #endregion RelacionGasAceite

            #region GravedadPetroleo

            GravedadPetroleo.Text = $"{Languages.Pozo.GravedadPetroleo}:\n{DatosOperativos.GravedadPetroleo.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Densidad, _Telemetria.Unidades)}";

            #endregion GravedadPetroleo

            #region Emulsion

            Emulsion.Text = $"{Languages.Pozo.Emulsion}:\n{DatosOperativos.Emulsion.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Porcentaje, _Telemetria.Unidades)}";

            #endregion Emulsion

            #region SalinidadAgua

            SalinidadAgua.Text = $"{Languages.Pozo.SalinidadAgua}:\n{DatosOperativos.SalinidadAgua.ToString($"n{decimales}")} ppm";

            #endregion SalinidadAgua

            #region GravedadEspecificaGasProducido

            GravedadEspecificaGasProducido.Text = $"{Languages.Pozo.GravedadEspecificaGasProducido}:\n{DatosOperativos.GravedadEspecificaGasProducido.ToString($"n{decimales}")} -";

            #endregion GravedadEspecificaGasProducido

            #endregion DatosProduccion

            #region TablaHistorico

            tabPage1.Text = Languages.Pozo.TablaHistorico;

            dgvTablaHistorico.Table(decimales, _Telemetrias);

            #endregion TablaHistorico

            #region Temporizador

            DatosOperativosSends.Text = $"{Languages.Pozo.Envio}: {_Telemetrias.Where(val => val.Sent.Contains("DatosOperativos")).Count()}";
            DatosOperativosComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetrias.Where(val => val.Sent.Contains("DatosOperativos") && val.DatosOperativosFinish && val.DatosOperativosBool).Count()}";
            DatosOperativosFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetrias.Where(val => val.Sent.Contains("DatosOperativos") && val.DatosOperativosFinish && !val.DatosOperativosBool).Count()}";
            this.DatosOperativos.Text =_Telemetria.Range.DatosOperativos.TotalSeconds != 0
                ? $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.DatosOperativosTime.AddSeconds(_Telemetria.Range.DatosOperativos.TotalSeconds).ToLocalTime():G}"
                : $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion DatosManual
        }
    }
}