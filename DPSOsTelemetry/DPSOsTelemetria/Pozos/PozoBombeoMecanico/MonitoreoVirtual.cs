using System.Data;
using Telemetria;

namespace DPSOsTelemetria.Pozos.PozoBombeoMecanico
{
    public partial class MonitoreoVirtual : UserControl
    {
        public MonitoreoVirtual()

        {
            InitializeComponent();
            //chart1.Legend.Visibility = DefaultBoolean.False;
        }

        internal void Recargar(int decimales, ReferenciasI _Telemetria)
        {
            #region DatosOperativos

            tabPage1.Text = Languages.Pozo.DatosOperativos;

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

            #region DoSumergenciaEfectivaBomba

            DoSumergenciaEfectivaBomba.Text = $"{Languages.Pozo.DoSumergenciaEfectivaBomba}:\n{DatosOperativos.DoSumergenciaEfectivaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Distancia, _Telemetria.Unidades)}";

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTr

            DoNivelFluidoPozoTr.Text = $"{Languages.Pozo.DoNivelFluidoPozoTr}:\n{DatosOperativos.DoNivelFluidoPozoTr.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Distancia, _Telemetria.Unidades)}";

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            DoPresionEntradaBomba.Text = $"{Languages.Pozo.DoPresionEntradaBomba}:\n{DatosOperativos.DoPresionEntradaBomba.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Presion, _Telemetria.Unidades)}";

            #endregion DoPresionEntradaBomba

            #region DoVelocidadUnidadBombeo

            DoVelocidadUnidadBombeo.Text = $"{Languages.Pozo.DoVelocidadUnidadBombeo}:\n{DatosOperativos.DoVelocidadUnidadBombeo.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Embolada, _Telemetria.Unidades)}";

            #endregion DoVelocidadUnidadBombeo

            #region DoVelocidadMotor

            DoVelocidadMotor.Text = $"{Languages.Pozo.DoVelocidadMotor}:\n{DatosOperativos.DoVelocidadMotor.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Velocidad, _Telemetria.Unidades)}";

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            DoLongitudCarrera.Text = $"{Languages.Pozo.DoLongitudCarrera}:\n{DatosOperativos.DoLongitudCarrera.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Distancia, _Telemetria.Unidades)}";

            #endregion DoLongitudCarrera

            #region DoEficienciaLlenado

            DoEficienciaLlenado.Text = $"{Languages.Pozo.DoEficienciaLlenado}:\n{DatosOperativos.DoEficienciaLlenado.ToString($"n{decimales}")} { Configuracion.GetSigla(Siglas.Porcentaje, _Telemetria.Unidades)}";

            #endregion DoEficienciaLlenado

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
            DataTable dt = new(Languages.Graphics.DinamometricaFondo);
            dt.Columns.Add("X", typeof(decimal));
            dt.Columns.Add("Y", typeof(decimal));
            for (int i = 0; i < CCartaDinagrafica.SurfaceCardPosition.Count; i++)
                dt.Rows.Add(CCartaDinagrafica.SurfaceCardPosition[i], CCartaDinagrafica.SurfaceCardLoad[i]);

            //Series Serie = new Series(dt.TableName, ViewType.ScatterLine)
            //{
            //    DataSource = dt,
            //    ArgumentDataMember = "X",
            //};
            //Serie.ValueDataMembers.AddRange("Y");

            //chart1.Series.Clear();
            //chart1.Series.Add(Serie);

            //decimal MinX = CCartaDinagrafica.SurfaceCardPosition.Count > 0 ? CCartaDinagrafica.SurfaceCardPosition.Min(val => val) : 0;
            //decimal MaxX = CCartaDinagrafica.SurfaceCardPosition.Count > 0 ? CCartaDinagrafica.SurfaceCardPosition.Max(val => val) : 0;
            //decimal MinY = CCartaDinagrafica.SurfaceCardLoad.Count > 0 ? CCartaDinagrafica.SurfaceCardLoad.Min(val => val) : 0;
            //decimal MaxY = CCartaDinagrafica.SurfaceCardLoad.Count > 0 ? CCartaDinagrafica.SurfaceCardLoad.Max(val => val) : 0;

            //decimal area = (MaxX - MinX) / 2;
            //if (area == 0)
            //    area = 1;
            //MinX -= area * 1 / 16;
            //MaxX += area * 1 / 16;

            //area = (MaxY - MinY) / 2;
            //if (area == 0)
            //    area = 1;
            //MinY -= area * 1 / 16;
            //MaxY += area * 1 / 16;

            //chart1.Legend.Visibility = DefaultBoolean.False;

            //XYDiagram diagram = (XYDiagram)chart1.Diagram;
            //diagram.AxisX.WholeRange.SideMarginsValue = 0;
            //diagram.AxisY.WholeRange.SideMarginsValue = 0;
            //diagram.AxisX.WholeRange.SetMinMaxValues(MinX, MaxX);
            //diagram.AxisY.WholeRange.SetMinMaxValues(MinY, MaxY);

            //// Customize the appearance of the Desplazamiento (ft).
            //diagram.AxisX.Title.Text = $"{Languages.Graphics.Axis_Desplazamiento} ({Configuracion.GetSigla(Siglas.Longitud_Carta, _Telemetria.Unidades)})";
            //diagram.AxisX.Title.Visibility = DefaultBoolean.True;
            //diagram.AxisX.Title.Alignment = StringAlignment.Center;
            //diagram.AxisX.Title.EnableAntialiasing = DefaultBoolean.True;

            //// Customize the appearance of the Carga (klbf).
            //diagram.AxisY.Title.Text = $"{Languages.Graphics.Axis_Carga} ({Configuracion.GetSigla(Siglas.Fuerza, _Telemetria.Unidades)})";
            //diagram.AxisY.Title.Visibility = DefaultBoolean.True;
            //diagram.AxisY.Title.Alignment = StringAlignment.Center;
            //diagram.AxisY.Title.EnableAntialiasing = DefaultBoolean.True;

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

        private void MonitoreoVirtual_Load(object sender, EventArgs e)
        {

        }
    }
}