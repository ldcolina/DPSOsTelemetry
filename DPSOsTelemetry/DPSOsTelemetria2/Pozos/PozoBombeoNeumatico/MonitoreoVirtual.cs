using Languages;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria.Pozos.PozoBombeoNeumatico
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

            #region PresionSeparacion

            PresionSeparacion.Text = $"{Languages.Pozo.PresionSeparacion}:\n{DatosOperativos.PresionSeparacion.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionSeparacion

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

            switch (_Telemetria.MetodoQGI)
            {
                case "0":
                    {
                        tlpPlateOrifice.Enabled=false;
                        tlpPlateOrifice.AutoSize=false;
                        tlpPlateOrifice.Height=0;
                        tlpMeteringValve.Enabled=false;
                        tlpMeteringValve.AutoSize=false;
                        tlpMeteringValve.Height=0;
                        tlpUser.Enabled=false;
                        tlpUser.AutoSize=false;
                        tlpUser.Height=0;

                        #region PresionDisponible

                        PresionDisponible1.Text = $"{Languages.Pozo.PresionDisponible}:\n{DatosOperativos.QgiPresionDisponible.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

                        #endregion PresionDisponible

                        #region NroVuelta

                        NroVuelta.Text = $"{Languages.Pozo.NroVuelta}:\n{DatosOperativos.QgiNroVuelta.ToString($"n{decimales}")} -";

                        #endregion NroVuelta

                        break;
                    }
                case "1":
                    {
                        tlpManualValveControl.Enabled=false;
                        tlpManualValveControl.AutoSize=false;
                        tlpManualValveControl.Height=0;
                        tlpMeteringValve.Enabled=false;
                        tlpMeteringValve.AutoSize=false;
                        tlpMeteringValve.Height=0;
                        tlpUser.Enabled=false;
                        tlpUser.AutoSize=false;
                        tlpUser.Height=0;

                        #region PresionDisponible

                        PresionDisponible2.Text = $"{Languages.Pozo.PresionDisponible}:\n{DatosOperativos.QgiPresionDisponible.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

                        #endregion PresionDisponible

                        #region PresionDiferencial

                        PresionDiferencial.Text = $"{Languages.Pozo.PresionDisponible}:\n{DatosOperativos.QgiPresionDiferencial.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

                        #endregion PresionDiferencial

                        #region DiametroOrificio

                        DiametroOrificio.Text = $"{Languages.Pozo.DiametroOrificio}:\n{DatosOperativos.QgiDiametroOrificio.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Diametro, _Telemetria.Unidades)}";

                        #endregion DiametroOrificio

                        break;
                    }
                case "2":
                    {
                        tlpManualValveControl.Enabled=false;
                        tlpManualValveControl.AutoSize=false;
                        tlpManualValveControl.Height=0;
                        tlpPlateOrifice.Enabled=false;
                        tlpPlateOrifice.AutoSize=false;
                        tlpPlateOrifice.Height=0;
                        tlpUser.Enabled=false;
                        tlpUser.AutoSize=false;
                        tlpUser.Height=0;

                        #region PresionDisponible

                        PresionDisponible3.Text = $"{Languages.Pozo.PresionDisponible}:\n{DatosOperativos.QgiPresionDisponible.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

                        #endregion PresionDisponible

                        #region AjusteValvula

                        AjusteValvula.Text = $"{Languages.Pozo.AjusteValvula}:\n{DatosOperativos.QgiAjusteValvula.ToString($"n{decimales}")} -";

                        #endregion AjusteValvula

                        break;
                    }
                case "3":
                    {
                        tlpManualValveControl.Enabled=false;
                        tlpManualValveControl.AutoSize=false;
                        tlpManualValveControl.Height=0;
                        tlpPlateOrifice.Enabled=false;
                        tlpPlateOrifice.AutoSize=false;
                        tlpPlateOrifice.Height=0;
                        tlpMeteringValve.Enabled=false;
                        tlpMeteringValve.AutoSize=false;
                        tlpMeteringValve.Height=0;

                        #region GravedadEspecificaGasInyeccion

                        GravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.GravedadEspecificaGasInyeccion}:\n{DatosOperativos.QgiGravedadEspecificaGasInyeccion.ToString($"n{decimales}")} -";

                        #endregion GravedadEspecificaGasInyeccion

                        break;
                    }
            }

            #endregion DatosProduccion

            #region TablaHistorico

            tabPage1.Text = Languages.Pozo.TablaHistorico;

            dgvTablaHistorico.Table(decimales, _Telemetrias);

            #endregion TablaHistorico

            #region Temporizador

            DatosOperativosSends.Text = $"{Languages.Pozo.Envio}: {_Telemetrias.Count()}";
            DatosOperativosComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetrias.Where(val => val.DatosOperativosFinish).Count(val => val.CartaDinagraficaBool)}";
            DatosOperativosFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetrias.Where(val => val.DatosOperativosFinish).Count(val => !val.DatosOperativosBool)}";
            this.DatosOperativos.Text =_Telemetria.Range.DatosOperativos.TotalSeconds != 0
                ? $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.DatosOperativosTime.AddSeconds(_Telemetria.Range.DatosOperativos.TotalSeconds).ToLocalTime():G}"
                : $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion DatosManual
        }
    }
}