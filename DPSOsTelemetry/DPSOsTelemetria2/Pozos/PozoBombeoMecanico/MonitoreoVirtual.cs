using DevExpress.Utils;
using DevExpress.XtraCharts;
using Languages;
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

        internal void Recargar(int decimales, ReferenciasI _Telemetria)
        {
            #region DatosOperativos

            tabPage1.Text = Languages.Pozo.DatosOperativos;

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

            #region sumergenciaEfectivaBomba

            sumergenciaEfectivaBomba.Text = $"{Languages.Pozo.sumergenciaEfectivaBomba}:\n{DatosOperativos.sumergenciaEfectivaBomba.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTr

            nivelFluidoPozoTr.Text = $"{Languages.Pozo.nivelFluidoPozoTr}:\n{DatosOperativos.nivelFluidoPozoTr.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            presionEntradaBomba.Text = $"{Languages.Pozo.presionEntradaBomba}:\n{DatosOperativos.presionEntradaBomba.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Presion, _Telemetria.Unidades)}";

            #endregion presionEntradaBomba

            #region velocidadUnidadBombeo

            velocidadUnidadBombeo.Text = $"{Languages.Pozo.velocidadUnidadBombeo}:\n{DatosOperativos.velocidadUnidadBombeo.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Embolada, _Telemetria.Unidades)}";

            #endregion velocidadUnidadBombeo

            #region velocidadMotor

            velocidadMotor.Text = $"{Languages.Pozo.velocidadMotor}:\n{DatosOperativos.velocidadMotor.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Velocidad, _Telemetria.Unidades)}";

            #endregion velocidadMotor

            #region longitudCarrera

            longitudCarrera.Text = $"{Languages.Pozo.longitudCarrera}:\n{DatosOperativos.longitudCarrera.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Distancia, _Telemetria.Unidades)}";

            #endregion longitudCarrera

            #region eficienciaLlenado

            eficienciaLlenado.Text = $"{Languages.Pozo.eficienciaLlenado}:\n{DatosOperativos.eficienciaLlenado.ToString($"n{decimales}")} {Configuracion.GetSigla(Referencia.Porcentaje, _Telemetria.Unidades)}";

            #endregion eficienciaLlenado

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

            #region CartaDinagrafica

            tabPage2.Text = Languages.Pozo.CartaDinagrafica;
            OCartaDinagrafica.CCartaDinagrafica CCartaDinagrafica = _Telemetria.CartaDinagrafica;
            DataTable dt = new DataTable(Languages.Graphics.DinamometricaFondo);
            dt.Columns.Add("X", typeof(decimal));
            dt.Columns.Add("Y", typeof(decimal));
            if (CCartaDinagrafica.SurfaceCardPosition.Count > 0)
            {
                for (int i = 0; i < CCartaDinagrafica.SurfaceCardPosition.Count; i++)
                    dt.Rows.Add(CCartaDinagrafica.SurfaceCardPosition[i], CCartaDinagrafica.SurfaceCardLoad[i]);
                dt.Rows.Add(CCartaDinagrafica.SurfaceCardPosition[0], CCartaDinagrafica.SurfaceCardLoad[0]);
            }

            Series Serie = new Series(dt.TableName, ViewType.ScatterLine)
            {
                DataSource = dt,
                ArgumentDataMember = "X",
            };
            Serie.ValueDataMembers.AddRange("Y");

            chart1.Series.Clear();
            chart1.Series.Add(Serie);

            decimal MinX = CCartaDinagrafica.SurfaceCardPosition.Count > 0 ? CCartaDinagrafica.SurfaceCardPosition.Min(val => val) : 0;
            decimal MaxX = CCartaDinagrafica.SurfaceCardPosition.Count > 0 ? CCartaDinagrafica.SurfaceCardPosition.Max(val => val) : 0;
            decimal MinY = CCartaDinagrafica.SurfaceCardLoad.Count > 0 ? CCartaDinagrafica.SurfaceCardLoad.Min(val => val) : 0;
            decimal MaxY = CCartaDinagrafica.SurfaceCardLoad.Count > 0 ? CCartaDinagrafica.SurfaceCardLoad.Max(val => val) : 0;

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

            CartaDinagraficaSends.Text = $"{Languages.Pozo.Envio}: {_Telemetria.CartaDinagraficaSends}";
            CartaDinagraficaComplete.Text = $"{Languages.Pozo.EnvioCorrecto}: {_Telemetria.CartaDinagraficaComplete}";
            CartaDinagraficaFails.Text = $"{Languages.Pozo.EnvioIncorrecto}: {_Telemetria.CartaDinagraficaFails}";
            if (_Telemetria.Range.CartaDinagrafica.TotalMilliseconds != 0)
                CartaDinagrafica.Text = $"{Languages.Pozo.ProxActualizacion}:\n{_Telemetria.Started.AddMilliseconds(_Telemetria.Range.CartaDinagrafica.TotalMilliseconds * _Telemetria.CartaDinagraficaSends).ToLocalTime():G}";
            else
                CartaDinagrafica.Text = $"{Languages.Pozo.ProxActualizacion}:\n-";

            #endregion Temporizador

            #endregion CartaDinagrafica
        }
    }
}
