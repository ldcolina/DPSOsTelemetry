using Languages;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Pozos
{
    public static class Tabla_Historico
    {
        public class _tabla : OTomaInformacion.CTomaBasica
        {
            public string DatosOperativosTime { get; set; }

            public string DatosOperativosResult { get; set; }
        }

        public static DataGridView Table(this DataGridView dt, int decimales, List<ReferenciasI> tablaHistorico)
        {
            List<_tabla> tabla = new List<_tabla>();
            tablaHistorico.OrderByDescending(val => val.DatosOperativosTime).ToList().ForEach(val =>
            {
                _tabla tabla1 = val.DatosOperativos.Copy<OTomaInformacion.CTomaBasica, _tabla>();
                if (val.DatosOperativosFinish)
                    tabla1.DatosOperativosResult = val.DatosOperativosBool ? Languages.Pozo.EnvioCorrecto : Languages.Pozo.EnvioIncorrecto;

                tabla1.DatosOperativosTime = val.DatosOperativosTime.ToString("G");
                tabla.Add(tabla1);
            });
            dt.DataSource = tabla.ToDataTable();

            ReferenciasI _Telemetria = tablaHistorico.FirstOrDefault();

            #region DatosOperativosTime

            dt.Columns["DatosOperativosTime"].DisplayIndex = 0;
            dt.Columns["DatosOperativosTime"].HeaderText = Languages.Pozo.DatosOperativosTime;

            #endregion DatosOperativosTime

            #region DatosOperativosResult

            dt.Columns["DatosOperativosResult"].DisplayIndex = 1;
            dt.Columns["DatosOperativosResult"].HeaderText = Languages.Pozo.DatosOperativosResult;

            #endregion DatosOperativosResult

            #region CargaSobreBarraPulida

            dt.Columns["CargaSobreBarraPulida"].Visible = _Telemetria.Range.CargaSobreBarraPulida;
            dt.Columns["CargaSobreBarraPulida"].HeaderText = Languages.Pozo.CargaSobreBarraPulida;
            dt.Columns["CargaSobreBarraPulida"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion CargaSobreBarraPulida

            #region Corriente

            dt.Columns["Corriente"].Visible = _Telemetria.Range.Corriente;
            dt.Columns["Corriente"].HeaderText = Languages.Pozo.Corriente;
            dt.Columns["Corriente"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion Corriente

            #region DiametroEstrangulador

            dt.Columns["DiametroEstrangulador"].Visible = _Telemetria.Range.DiametroEstrangulador;
            dt.Columns["DiametroEstrangulador"].HeaderText = Languages.Pozo.DiametroEstrangulador;
            dt.Columns["DiametroEstrangulador"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion DiametroEstrangulador

            #region EficienciaLlenado

            dt.Columns["EficienciaLlenado"].Visible = _Telemetria.Range.EficienciaLlenado;
            dt.Columns["EficienciaLlenado"].HeaderText = Languages.Pozo.EficienciaLlenado;
            dt.Columns["EficienciaLlenado"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion EficienciaLlenado

            #region Emulsion

            dt.Columns["Emulsion"].Visible = _Telemetria.Range.Emulsion;
            dt.Columns["Emulsion"].HeaderText = Languages.Pozo.Emulsion;
            dt.Columns["Emulsion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion Emulsion

            #region FrecuenciaOperacionBomba

            dt.Columns["FrecuenciaOperacionBomba"].Visible = _Telemetria.Range.FrecuenciaOperacionBomba;
            dt.Columns["FrecuenciaOperacionBomba"].HeaderText = Languages.Pozo.FrecuenciaOperacionBomba;
            dt.Columns["FrecuenciaOperacionBomba"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion FrecuenciaOperacionBomba

            #region GastoAceite

            dt.Columns["GastoAceite"].Visible = _Telemetria.Range.GastoAceite;
            dt.Columns["GastoAceite"].HeaderText = Languages.Pozo.GastoAceite;
            dt.Columns["GastoAceite"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GastoAceite

            #region GastoGas

            dt.Columns["GastoGas"].Visible = _Telemetria.Range.GastoGas;
            dt.Columns["GastoGas"].HeaderText = Languages.Pozo.GastoGas;
            dt.Columns["GastoGas"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GastoGas

            #region GastoGasInyeccion

            dt.Columns["GastoGasInyeccion"].Visible = _Telemetria.Range.GastoGasInyeccion;
            dt.Columns["GastoGasInyeccion"].HeaderText = Languages.Pozo.GastoGasInyeccion;
            dt.Columns["GastoGasInyeccion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GastoGasInyeccion

            #region GastoInyeccionFluidoPotencia

            dt.Columns["GastoInyeccionFluidoPotencia"].Visible = _Telemetria.Range.GastoInyeccionFluidoPotencia;
            dt.Columns["GastoInyeccionFluidoPotencia"].HeaderText = Languages.Pozo.GastoInyeccionFluidoPotencia;
            dt.Columns["GastoInyeccionFluidoPotencia"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GastoInyeccionFluidoPotencia

            #region GastoLiquido

            dt.Columns["GastoLiquido"].Visible = _Telemetria.Range.GastoLiquido;
            dt.Columns["GastoLiquido"].HeaderText = Languages.Pozo.GastoLiquido;
            dt.Columns["GastoLiquido"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GastoLiquido

            #region GastoLiquidoPruebaProduccion

            dt.Columns["GastoLiquidoPruebaProduccion"].Visible = _Telemetria.Range.GastoLiquidoPruebaProduccion;
            dt.Columns["GastoLiquidoPruebaProduccion"].HeaderText = Languages.Pozo.GastoLiquido;
            dt.Columns["GastoLiquidoPruebaProduccion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GastoLiquidoPruebaProduccion

            #region GravedadEspecificaFluidoPotencia

            dt.Columns["GravedadEspecificaFluidoPotencia"].Visible = _Telemetria.Range.GravedadEspecificaFluidoPotencia;
            dt.Columns["GravedadEspecificaFluidoPotencia"].HeaderText = Languages.Pozo.GravedadEspecificaFluidoPotencia;
            dt.Columns["GravedadEspecificaFluidoPotencia"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GravedadEspecificaFluidoPotencia

            #region PresionDisponible

            dt.Columns["QgiPresionDisponible"].Visible = _Telemetria.Range.PresionDisponible;
            dt.Columns["QgiPresionDisponible"].HeaderText = Languages.Pozo.PresionDisponible;
            dt.Columns["QgiPresionDisponible"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionDisponible

            #region NroVuelta

            dt.Columns["QgiNroVuelta"].Visible = _Telemetria.Range.NroVuelta;
            dt.Columns["QgiNroVuelta"].HeaderText = Languages.Pozo.NroVuelta;
            dt.Columns["QgiNroVuelta"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion NroVuelta

            #region PresionDiferencial

            dt.Columns["QgiPresionDiferencial"].Visible = _Telemetria.Range.PresionDiferencial;
            dt.Columns["QgiPresionDiferencial"].HeaderText = Languages.Pozo.PresionDiferencial;
            dt.Columns["QgiPresionDiferencial"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionDiferencial

            #region DiametroOrificio

            dt.Columns["QgiDiametroOrificio"].Visible = _Telemetria.Range.DiametroOrificio;
            dt.Columns["QgiDiametroOrificio"].HeaderText = Languages.Pozo.DiametroOrificio;
            dt.Columns["QgiDiametroOrificio"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion DiametroOrificio

            #region AjusteValvula

            dt.Columns["QgiAjusteValvula"].Visible = _Telemetria.Range.AjusteValvula;
            dt.Columns["QgiAjusteValvula"].HeaderText = Languages.Pozo.AjusteValvula;
            dt.Columns["QgiAjusteValvula"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion AjusteValvula

            #region GravedadEspecificaGasInyeccion

            dt.Columns["QgiGravedadEspecificaGasInyeccion"].Visible = _Telemetria.Range.GravedadEspecificaGasInyeccion;
            dt.Columns["QgiGravedadEspecificaGasInyeccion"].HeaderText = Languages.Pozo.GravedadEspecificaGasInyeccion;
            dt.Columns["QgiGravedadEspecificaGasInyeccion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GravedadEspecificaGasInyeccion

            #region GravedadEspecificaGasProducido

            dt.Columns["GravedadEspecificaGasProducido"].Visible = _Telemetria.Range.GravedadEspecificaGasProducido;
            dt.Columns["GravedadEspecificaGasProducido"].HeaderText = Languages.Pozo.GravedadEspecificaGasProducido;
            dt.Columns["GravedadEspecificaGasProducido"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GravedadEspecificaGasProducido

            #region GravedadPetroleo

            dt.Columns["GravedadPetroleo"].Visible = _Telemetria.Range.GravedadPetroleo;
            dt.Columns["GravedadPetroleo"].HeaderText = Languages.Pozo.GravedadPetroleo;
            dt.Columns["GravedadPetroleo"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion GravedadPetroleo

            #region LongitudCarrera

            dt.Columns["LongitudCarrera"].Visible = _Telemetria.Range.LongitudCarrera;
            dt.Columns["LongitudCarrera"].HeaderText = Languages.Pozo.LongitudCarrera;
            dt.Columns["LongitudCarrera"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion LongitudCarrera

            #region NivelFluidoPozoTp

            dt.Columns["NivelFluidoPozoTp"].Visible = _Telemetria.Range.NivelFluidoPozoTp;
            dt.Columns["NivelFluidoPozoTp"].HeaderText = Languages.Pozo.NivelFluidoPozoTp;
            dt.Columns["NivelFluidoPozoTp"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion NivelFluidoPozoTp

            #region NivelFluidoPozoTr

            dt.Columns["NivelFluidoPozoTr"].Visible = _Telemetria.Range.NivelFluidoPozoTr;
            dt.Columns["NivelFluidoPozoTr"].HeaderText = Languages.Pozo.NivelFluidoPozoTr;
            dt.Columns["NivelFluidoPozoTr"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion NivelFluidoPozoTr

            #region PorcentajeAguaSedimento

            dt.Columns["PorcentajeAguaSedimento"].Visible = _Telemetria.Range.PorcentajeAguaSedimento;
            dt.Columns["PorcentajeAguaSedimento"].HeaderText = Languages.Pozo.PorcentajeAguaSedimento;
            dt.Columns["PorcentajeAguaSedimento"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PorcentajeAguaSedimento

            #region PresionAperturaCampo

            dt.Columns["PresionAperturaCampo"].Visible = _Telemetria.Range.PresionAperturaCampo;
            dt.Columns["PresionAperturaCampo"].HeaderText = Languages.Pozo.PresionAperturaCampo;
            dt.Columns["PresionAperturaCampo"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionAperturaCampo

            #region PresionEntradaBomba

            dt.Columns["PresionEntradaBomba"].Visible = _Telemetria.Range.PresionEntradaBomba;
            dt.Columns["PresionEntradaBomba"].HeaderText = Languages.Pozo.PresionEntradaBomba;
            dt.Columns["PresionEntradaBomba"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionEntradaBomba

            #region PresionLineaDescarga

            dt.Columns["PresionLineaDescarga"].Visible = _Telemetria.Range.PresionLineaDescarga;
            dt.Columns["PresionLineaDescarga"].HeaderText = Languages.Pozo.PresionLineaDescarga;
            dt.Columns["PresionLineaDescarga"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionLineaDescarga

            #region PresionTuberiaProduccion

            dt.Columns["PresionTuberiaProduccion"].Visible = _Telemetria.Range.PresionTuberiaProduccion;
            dt.Columns["PresionTuberiaProduccion"].HeaderText = Languages.Pozo.PresionTuberiaProduccion;
            dt.Columns["PresionTuberiaProduccion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            dt.Columns["PresionTuberiaRevestimiento"].Visible = _Telemetria.Range.PresionTuberiaRevestimiento;
            dt.Columns["PresionTuberiaRevestimiento"].HeaderText = Languages.Pozo.PresionTuberiaRevestimiento;
            dt.Columns["PresionTuberiaRevestimiento"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionTuberiaRevestimiento

            #region PresionSeparacion

            dt.Columns["PresionSeparacion"].Visible = _Telemetria.Range.PresionSeparacion;
            dt.Columns["PresionSeparacion"].HeaderText = Languages.Pozo.PresionSeparacion;
            dt.Columns["PresionSeparacion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion PresionSeparacion

            #region RelacionGasAceite

            dt.Columns["RelacionGasAceite"].Visible = _Telemetria.Range.RelacionGasAceite;
            dt.Columns["RelacionGasAceite"].HeaderText = Languages.Pozo.RelacionGasAceite;
            dt.Columns["RelacionGasAceite"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion RelacionGasAceite

            #region SalinidadAgua

            dt.Columns["SalinidadAgua"].Visible = _Telemetria.Range.SalinidadAgua;
            dt.Columns["SalinidadAgua"].HeaderText = Languages.Pozo.SalinidadAgua;
            dt.Columns["SalinidadAgua"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion SalinidadAgua

            #region SumergenciaEfectivaBomba

            dt.Columns["SumergenciaEfectivaBomba"].Visible = _Telemetria.Range.SumergenciaEfectivaBomba;
            dt.Columns["SumergenciaEfectivaBomba"].HeaderText = Languages.Pozo.SumergenciaEfectivaBomba;
            dt.Columns["SumergenciaEfectivaBomba"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion SumergenciaEfectivaBomba

            #region TemperaturaSuperficie

            dt.Columns["TemperaturaSuperficie"].Visible = _Telemetria.Range.TemperaturaSuperficie;
            dt.Columns["TemperaturaSuperficie"].HeaderText = Languages.Pozo.TemperaturaSuperficie;
            dt.Columns["TemperaturaSuperficie"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion TemperaturaSuperficie

            #region TiempoCiclo

            dt.Columns["TiempoCiclo"].Visible = _Telemetria.Range.TiempoCiclo;
            dt.Columns["TiempoCiclo"].HeaderText = Languages.Pozo.TiempoCiclo;
            dt.Columns["TiempoCiclo"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion TiempoCiclo

            #region TiempoDesplazamientoTapon

            dt.Columns["TiempoDesplazamientoTapon"].Visible = _Telemetria.Range.TiempoDesplazamientoTapon;
            dt.Columns["TiempoDesplazamientoTapon"].HeaderText = Languages.Pozo.TiempoDesplazamientoTapon;
            dt.Columns["TiempoDesplazamientoTapon"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion TiempoDesplazamientoTapon

            #region TiempoInyeccion

            dt.Columns["TiempoInyeccion"].Visible = _Telemetria.Range.TiempoInyeccion;
            dt.Columns["TiempoInyeccion"].HeaderText = Languages.Pozo.TiempoInyeccion;
            dt.Columns["TiempoInyeccion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion TiempoInyeccion

            #region TiempoRecuperacion

            dt.Columns["TiempoRecuperacion"].Visible = _Telemetria.Range.TiempoRecuperacion;
            dt.Columns["TiempoRecuperacion"].HeaderText = Languages.Pozo.TiempoRecuperacion;
            dt.Columns["TiempoRecuperacion"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion TiempoRecuperacion

            #region Torque

            dt.Columns["Torque"].Visible = _Telemetria.Range.Torque;
            dt.Columns["Torque"].HeaderText = Languages.Pozo.Torque;
            dt.Columns["Torque"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion Torque

            #region VelocidadBomba

            dt.Columns["VelocidadBomba"].Visible = _Telemetria.Range.VelocidadBomba;
            dt.Columns["VelocidadBomba"].HeaderText = Languages.Pozo.VelocidadBomba;
            dt.Columns["VelocidadBomba"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion VelocidadBomba

            #region VelocidadMotor

            dt.Columns["VelocidadMotor"].Visible = _Telemetria.Range.VelocidadMotor;
            dt.Columns["VelocidadMotor"].HeaderText = Languages.Pozo.VelocidadMotor;
            dt.Columns["VelocidadMotor"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion VelocidadMotor

            #region VelocidadUnidadBombeo

            dt.Columns["VelocidadUnidadBombeo"].Visible = _Telemetria.Range.VelocidadUnidadBombeo;
            dt.Columns["VelocidadUnidadBombeo"].HeaderText = Languages.Pozo.VelocidadUnidadBombeo;
            dt.Columns["VelocidadUnidadBombeo"].DefaultCellStyle.Format = $"N{decimales}";

            #endregion VelocidadUnidadBombeo

            return dt;
        }
    }
}