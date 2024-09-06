using DevExpress.Utils;
using DevExpress.XtraCharts;
using Languages;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Pozos.PozoBombeoMecanico
{
    public partial class MonitoreoVirtual : UserControl
    {
        public MonitoreoVirtual()

        {
            InitializeComponent();
            chart1.Legend.Visibility = DefaultBoolean.False;
        }

        internal void Recargar(int decimales, List<ReferenciasI> _Telemetrias)
        {
            ReferenciasI _Telemetria = _Telemetrias.LastOrDefault();

            #region DatosManual

            tabPage1.Text = Languages.Pozo.DatosManual;
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

            #region SumergenciaEfectivaBomba

            SumergenciaEfectivaBomba.Text = $"{Languages.Pozo.SumergenciaEfectivaBomba}:\n{DatosOperativos.SumergenciaEfectivaBomba.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion SumergenciaEfectivaBomba

            #region NivelFluidoPozoTr

            NivelFluidoPozoTr.Text = $"{Languages.Pozo.NivelFluidoPozoTr}:\n{DatosOperativos.NivelFluidoPozoTr.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            PresionEntradaBomba.Text = $"{Languages.Pozo.PresionEntradaBomba}:\n{DatosOperativos.PresionEntradaBomba.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion PresionEntradaBomba

            #region VelocidadUnidadBombeo

            VelocidadUnidadBombeo.Text = $"{Languages.Pozo.VelocidadUnidadBombeo}:\n{DatosOperativos.VelocidadUnidadBombeo.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Embolada, _Telemetria.Unidades)}";

            #endregion VelocidadUnidadBombeo

            #region VelocidadMotor

            VelocidadMotor.Text = $"{Languages.Pozo.VelocidadMotor}:\n{DatosOperativos.VelocidadMotor.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Velocidad, _Telemetria.Unidades)}";

            #endregion VelocidadMotor

            #region LongitudCarrera

            LongitudCarrera.Text = $"{Languages.Pozo.LongitudCarrera}:\n{DatosOperativos.LongitudCarrera.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Diametro, _Telemetria.Unidades)}";

            #endregion LongitudCarrera

            #region EficienciaLlenado

            EficienciaLlenado.Text = $"{Languages.Pozo.EficienciaLlenado}:\n{DatosOperativos.EficienciaLlenado.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Porcentaje, _Telemetria.Unidades)}";

            #endregion EficienciaLlenado

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

            #region CargaSobreBarraPulida

            CargaSobreBarraPulida.Text = $"{Languages.Pozo.CargaSobreBarraPulida}:\n{DatosOperativos.CargaSobreBarraPulida.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion CargaSobreBarraPulida

            #endregion DatosProduccion

            #region TablaHistorico

            tabPage5.Text = Languages.Pozo.TablaHistorico;

            dgvTablaHistorico.Table(decimales, _Telemetrias);

            #endregion TablaHistorico

            #region Temporizador

            DatosOperativosSends.Text = $"{Languages.Pozo.Envio}: {_Telemetrias.Where(val => val.Sent.Contains("DatosOperativos")).Count()}";
            DatosOperativosComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetrias.Where(val => val.Sent.Contains("DatosOperativos") && val.DatosOperativosFinish && val.DatosOperativosBool).Count()}";
            DatosOperativosFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetrias.Where(val => val.Sent.Contains("DatosOperativos") && val.DatosOperativosFinish && !val.DatosOperativosBool).Count()}";
            if (_Telemetria.Range.DatosOperativos.TotalSeconds != 0)
                this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.DatosOperativosTime.AddSeconds(_Telemetria.Range.DatosOperativos.TotalSeconds).ToLocalTime():G}";
            else
                this.DatosOperativos.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion DatosManual

            #region CartaDinagrafica

            tabPage2.Text = Languages.Pozo.CartaDinagrafica;

            List<OCartaDinagrafica.CartaSuperficie> CCartaDinagrafica = new List<OCartaDinagrafica.CartaSuperficie>();
            if (_Telemetria.DatosCarta.CartaSuperficie!=null)
                CCartaDinagrafica= _Telemetria.DatosCarta.CartaSuperficie;

            DataTable dt = new DataTable(Languages.Graphics.DinamometricaFondo);
            dt.Columns.Add("X", typeof(decimal));
            dt.Columns.Add("Y", typeof(decimal));
            if (CCartaDinagrafica.Count > 0)
            {
                for (int i = 0; i < CCartaDinagrafica.Count; i++)
                    dt.Rows.Add(CCartaDinagrafica[i].Distancia, CCartaDinagrafica[i].Fuerza);
                dt.Rows.Add(CCartaDinagrafica[0].Distancia, CCartaDinagrafica[0].Fuerza);
            }

            Series Serie = new Series(dt.TableName, ViewType.ScatterLine)
            {
                DataSource = dt,
                ArgumentDataMember = "X",
            };
            Serie.ValueDataMembers.AddRange("Y");

            chart1.Series.Clear();
            chart1.Series.Add(Serie);

            decimal MinX = CCartaDinagrafica.Count > 0 ? CCartaDinagrafica.Min(val => val.Distancia) : 0;
            decimal MaxX = CCartaDinagrafica.Count > 0 ? CCartaDinagrafica.Max(val => val.Distancia) : 0;
            decimal MinY = CCartaDinagrafica.Count > 0 ? CCartaDinagrafica.Min(val => val.Fuerza) : 0;
            decimal MaxY = CCartaDinagrafica.Count > 0 ? CCartaDinagrafica.Max(val => val.Fuerza) : 0;

            decimal area = (MaxX - MinX) / 2;
            if (area == 0)
                area = 1;
            MinX -= area * 1 / 16;
            MaxX += area * 1 / 16;

            area = (MaxY - MinY) / 2;
            if (area == 0)
                area = 1;
            MinY -= area * 1 / 16;
            MaxY += area * 1 / 16;

            chart1.Legend.Visibility = DefaultBoolean.False;

            XYDiagram diagram = (XYDiagram)chart1.Diagram;
            diagram.AxisX.WholeRange.SideMarginsValue = 0;
            diagram.AxisY.WholeRange.SideMarginsValue = 0;
            diagram.AxisX.WholeRange.SetMinMaxValues(MinX, MaxX);
            diagram.AxisY.WholeRange.SetMinMaxValues(MinY, MaxY);

            // Customize the appearance of the Desplazamiento (ft).
            diagram.AxisX.Title.Text = $"{Languages.Graphics.Axis_Desplazamiento} ({Configuracion.GetSigla(Referencia.Longitud_Carta, _Telemetria.Unidades)})";
            diagram.AxisX.Title.Visibility = DefaultBoolean.True;
            diagram.AxisX.Title.Alignment = StringAlignment.Center;
            diagram.AxisX.Title.EnableAntialiasing = DefaultBoolean.True;

            // Customize the appearance of the Carga (klbf).
            diagram.AxisY.Title.Text = $"{Languages.Graphics.Axis_Carga} ({Configuracion.GetSigla(Referencia.Fuerza, _Telemetria.Unidades)})";
            diagram.AxisY.Title.Visibility = DefaultBoolean.True;
            diagram.AxisY.Title.Alignment = StringAlignment.Center;
            diagram.AxisY.Title.EnableAntialiasing = DefaultBoolean.True;

            #region Temporizador

            CartaDinagraficaSends.Text = $"{Languages.Pozo.Envio}: {_Telemetrias.Where(val => val.Sent.Contains("CartaDinagrafica")).Count()}";
            CartaDinagraficaComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetrias.Where(val => val.Sent.Contains("CartaDinagrafica") && val.CartaDinagraficaFinish && val.CartaDinagraficaBool).Count()}";
            CartaDinagraficaFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetrias.Where(val => val.Sent.Contains("CartaDinagrafica") && val.CartaDinagraficaFinish && !val.CartaDinagraficaBool).Count()}";
            if (_Telemetria.Range.CartaDinagrafica.TotalSeconds != 0)
                this.CartaDinagrafica.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.CartaDinagraficaTime.AddSeconds(_Telemetria.Range.CartaDinagrafica.TotalSeconds).ToLocalTime():G}";
            else
                this.CartaDinagrafica.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion CartaDinagrafica
        }
    }
}