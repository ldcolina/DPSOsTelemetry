using DevExpress.Utils;
using DevExpress.XtraCharts;
using Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using Telemetria;
using Excel = Microsoft.Office.Interop.Excel;

namespace DPSOsTelemetria2.Pozos.PozoBombeoMecanico
{
    public partial class TomaInformacion : UserControl
    {
        private readonly ReferenciasII Referencias;

        private List<lista> ListCCartaDinagrafica = new List<lista>();

        public TomaInformacion()
        {
            InitializeComponent();
        }

        public TomaInformacion(ReferenciasII referencias) : this()
        {
            Referencias = referencias;

            #region DatosManual

            #region DatosOperativos

            #region PresionTuberiaProduccion

            PresionTuberiaProduccion.Checked = referencias.Range.PresionTuberiaProduccion;
            PresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaProduccionMin.ToString());
            PresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaProduccionMax.ToString());

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            PresionTuberiaRevestimiento.Checked = referencias.Range.PresionTuberiaRevestimiento;
            PresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaRevestimientoMin.ToString());
            PresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaRevestimientoMax.ToString());

            #endregion PresionTuberiaRevestimiento

            #region PresionLineaDescarga

            PresionLineaDescarga.Checked = referencias.Range.PresionLineaDescarga;
            PresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionLineaDescargaMin.ToString());
            PresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionLineaDescargaMax.ToString());

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            TemperaturaSuperficie.Checked = referencias.Range.TemperaturaSuperficie;
            TemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(referencias.Range.TemperaturaSuperficieMin.ToString());
            TemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(referencias.Range.TemperaturaSuperficieMax.ToString());

            #endregion TemperaturaSuperficie

            #region SumergenciaEfectivaBomba

            SumergenciaEfectivaBomba.Checked = referencias.Range.SumergenciaEfectivaBomba;
            SumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.SumergenciaEfectivaBombaMin.ToString());
            SumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.SumergenciaEfectivaBombaMax.ToString());

            #endregion SumergenciaEfectivaBomba

            #region NivelFluidoPozoTr

            NivelFluidoPozoTr.Checked = referencias.Range.NivelFluidoPozoTr;
            NivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(referencias.Range.NivelFluidoPozoTrMin.ToString());
            NivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(referencias.Range.NivelFluidoPozoTrMax.ToString());

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            PresionEntradaBomba.Checked = referencias.Range.PresionEntradaBomba;
            PresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionEntradaBombaMin.ToString());
            PresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionEntradaBombaMax.ToString());

            #endregion PresionEntradaBomba

            #region VelocidadUnidadBombeo

            VelocidadUnidadBombeo.Checked = referencias.Range.VelocidadUnidadBombeo;
            VelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadUnidadBombeoMin.ToString());
            VelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadUnidadBombeoMax.ToString());

            #endregion VelocidadUnidadBombeo

            #region VelocidadMotor

            VelocidadMotor.Checked = referencias.Range.VelocidadMotor;
            VelocidadMotorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadMotorMin.ToString());
            VelocidadMotorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadMotorMax.ToString());

            #endregion VelocidadMotor

            #region LongitudCarrera

            LongitudCarrera.Checked = referencias.Range.LongitudCarrera;
            LongitudCarreraMin.Text = Condicionantes.Wrote_Formating(referencias.Range.LongitudCarreraMin.ToString());
            LongitudCarreraMax.Text = Condicionantes.Wrote_Formating(referencias.Range.LongitudCarreraMax.ToString());

            #endregion LongitudCarrera

            #region EficienciaLlenado

            EficienciaLlenado.Checked = referencias.Range.EficienciaLlenado;
            EficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.EficienciaLlenadoMin.ToString());
            EficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.EficienciaLlenadoMax.ToString());

            #endregion EficienciaLlenado

            foreach (var item in tlpVariables.Controls)
            {
                switch (item.GetType().Name)
                {
                    case "CheckBox":
                        {
                            ((CheckBox)item).CheckedChanged += CheckBox_CheckedChanged;
                            CheckBox_CheckedChanged((CheckBox)item, null);

                            break;
                        }
                    case "TextBox":
                        {
                            ((TextBox)item).Leave += Wrote_Leave;
                            ((TextBox)item).KeyPress += Wrote_KeyPress;

                            break;
                        }
                }
            }

            #endregion DatosOperativos

            #region DatosProduccion

            #region GastoLiquidoPruebaProduccion

            GastoLiquidoPruebaProduccion.Checked = referencias.Range.GastoLiquidoPruebaProduccion;
            GastoLiquidoPruebaProduccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoLiquidoPruebaProduccionMin.ToString());
            GastoLiquidoPruebaProduccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoLiquidoPruebaProduccionMax.ToString());

            #endregion GastoLiquidoPruebaProduccion

            #region PorcentajeAguaSedimento

            PorcentajeAguaSedimento.Checked = referencias.Range.PorcentajeAguaSedimento;
            PorcentajeAguaSedimentoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PorcentajeAguaSedimentoMin.ToString());
            PorcentajeAguaSedimentoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PorcentajeAguaSedimentoMax.ToString());

            #endregion PorcentajeAguaSedimento

            #region GastoAceite

            GastoAceite.Checked = referencias.Range.GastoAceite;
            GastoAceiteMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoAceiteMin.ToString());
            GastoAceiteMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoAceiteMax.ToString());

            #endregion GastoAceite

            #region GastoGas

            GastoGas.Checked = referencias.Range.GastoGas;
            GastoGasMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoGasMin.ToString());
            GastoGasMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoGasMax.ToString());

            #endregion GastoGas

            #region GastoLiquido

            GastoLiquido.Checked = referencias.Range.GastoLiquido;
            GastoLiquidoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoLiquidoMin.ToString());
            GastoLiquidoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoLiquidoMax.ToString());

            #endregion GastoLiquido

            #region RelacionGasAceite

            RelacionGasAceite.Checked = referencias.Range.RelacionGasAceite;
            RelacionGasAceiteMin.Text = Condicionantes.Wrote_Formating(referencias.Range.RelacionGasAceiteMin.ToString());
            RelacionGasAceiteMax.Text = Condicionantes.Wrote_Formating(referencias.Range.RelacionGasAceiteMax.ToString());

            #endregion RelacionGasAceite

            #region GravedadPetroleo

            GravedadPetroleo.Checked = referencias.Range.GravedadPetroleo;
            GravedadPetroleoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadPetroleoMin.ToString());
            GravedadPetroleoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadPetroleoMax.ToString());

            #endregion GravedadPetroleo

            #region Emulsion

            Emulsion.Checked = referencias.Range.Emulsion;
            EmulsionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.EmulsionMin.ToString());
            EmulsionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.EmulsionMax.ToString());

            #endregion Emulsion

            #region SalinidadAgua

            SalinidadAgua.Checked = referencias.Range.SalinidadAgua;
            SalinidadAguaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.SalinidadAguaMin.ToString());
            SalinidadAguaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.SalinidadAguaMax.ToString());

            #endregion SalinidadAgua

            #region GravedadEspecificaGasProducido

            GravedadEspecificaGasProducido.Checked = referencias.Range.GravedadEspecificaGasProducido;
            GravedadEspecificaGasProducidoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaGasProducidoMin.ToString());
            GravedadEspecificaGasProducidoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaGasProducidoMax.ToString());

            #endregion GravedadEspecificaGasProducido

            #region CargaSobreBarraPulida

            CargaSobreBarraPulida.Checked = referencias.Range.CargaSobreBarraPulida;
            CargaSobreBarraPulidaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.CargaSobreBarraPulidaMin.ToString());
            CargaSobreBarraPulidaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.CargaSobreBarraPulidaMax.ToString());

            #endregion CargaSobreBarraPulida

            foreach (var item in tlpVariables2.Controls)
            {
                switch (item.GetType().Name)
                {
                    case "CheckBox":
                        {
                            ((CheckBox)item).CheckedChanged += CheckBox2_CheckedChanged;
                            CheckBox2_CheckedChanged((CheckBox)item, null);

                            break;
                        }
                    case "TextBox":
                        {
                            ((TextBox)item).Leave += Wrote_Leave;
                            ((TextBox)item).KeyPress += Wrote_KeyPress;

                            break;
                        }
                }
            }

            #endregion DatosProduccion

            #region Temporizador

            DatosOperativos.Text = Condicionantes.Wrote_Formating(referencias.Range.DatosOperativos.TotalSeconds.ToString());
            DatosOperativos.Leave += Wrote_Leave;
            DatosOperativos.KeyPress += Wrote_KeyPress;

            #endregion Temporizador

            #endregion DatosManual

            #region CartaDinagrafica

            #region CCartaDinagrafica

            CCartaDinagrafica.Checked = referencias.Range.CCartaDinagrafica;
            CCartaDinagrafica_CheckedChanged(null, null);

            for (int i = 0; i < referencias.Range.ListCCartaDinagrafica.Count; i++)
                ListCCartaDinagrafica.Add(new lista() { index = i, Carta = referencias.Range.ListCCartaDinagrafica[i] });

            object SelectDdl = CCartaDinagraficaList.SelectedItem;
            CCartaDinagraficaList.DataSource = ListCCartaDinagrafica;
            CCartaDinagraficaList.DisplayMember = "index";
            if (ListCCartaDinagrafica.Count > 0)
            {
                if (SelectDdl != null)
                {
                    int index = ((lista)SelectDdl).index;
                    if (0 <= index && index <= ListCCartaDinagrafica.Max(val => val.index))
                        CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica[index];
                    else
                        CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica.Last();
                }
                else
                    CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica.First();
            }
            else
                CCartaDinagraficaList.SelectedItem = null;

            CCartaDinagraficaList_SelectedIndexChanged(null, null);

            #endregion CCartaDinagrafica

            #region Temporizador

            CartaDinagrafica.Text = Condicionantes.Wrote_Formating(referencias.Range.CartaDinagrafica.TotalSeconds.ToString());
            CartaDinagrafica.Leave += Wrote_Leave;
            CartaDinagrafica.KeyPress += Wrote_KeyPress;

            #endregion Temporizador

            #endregion CartaDinagrafica
        }

        internal void Recargar()
        {
            #region DatosManual

            tabPage1.Text = Languages.Pozo.DatosManual;

            #region DatosOperativos

            tabPage3.Text = Languages.Pozo.OperativeData;

            #region PresionTuberiaProduccion

            PresionTuberiaProduccion.Text = $"{Languages.Pozo.PresionTuberiaProduccion} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            PresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(PresionTuberiaProduccionMin.Text);
            PresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(PresionTuberiaProduccionMax.Text);

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            PresionTuberiaRevestimiento.Text = $"{Languages.Pozo.PresionTuberiaRevestimiento} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            PresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(PresionTuberiaRevestimientoMin.Text);
            PresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(PresionTuberiaRevestimientoMax.Text);

            #endregion PresionTuberiaRevestimiento

            #region PresionLineaDescarga

            PresionLineaDescarga.Text = $"{Languages.Pozo.PresionLineaDescarga} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            PresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(PresionLineaDescargaMin.Text);
            PresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(PresionLineaDescargaMax.Text);

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            TemperaturaSuperficie.Text = $"{Languages.Pozo.TemperaturaSuperficie} ({Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)})";
            TemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(TemperaturaSuperficieMin.Text);
            TemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(TemperaturaSuperficieMax.Text);

            #endregion TemperaturaSuperficie

            #region SumergenciaEfectivaBomba

            SumergenciaEfectivaBomba.Text = $"{Languages.Pozo.SumergenciaEfectivaBomba} ({Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            SumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(SumergenciaEfectivaBombaMin.Text);
            SumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(SumergenciaEfectivaBombaMax.Text);

            #endregion SumergenciaEfectivaBomba

            #region NivelFluidoPozoTr

            NivelFluidoPozoTr.Text = $"{Languages.Pozo.NivelFluidoPozoTr} ({Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            NivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(NivelFluidoPozoTrMin.Text);
            NivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(NivelFluidoPozoTrMax.Text);

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            PresionEntradaBomba.Text = $"{Languages.Pozo.PresionEntradaBomba} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            PresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(PresionEntradaBombaMin.Text);
            PresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(PresionEntradaBombaMax.Text);

            #endregion PresionEntradaBomba

            #region VelocidadUnidadBombeo

            VelocidadUnidadBombeo.Text = $"{Languages.Pozo.VelocidadUnidadBombeo} ({Configuracion.GetSigla(Referencia.Embolada, Referencias.Unidades)})";
            VelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(VelocidadUnidadBombeoMin.Text);
            VelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(VelocidadUnidadBombeoMax.Text);

            #endregion VelocidadUnidadBombeo

            #region VelocidadMotor

            VelocidadMotor.Text = $"{Languages.Pozo.VelocidadMotor} ({Configuracion.GetSigla(Referencia.Velocidad, Referencias.Unidades)})";
            VelocidadMotorMin.Text = Condicionantes.Wrote_Formating(VelocidadMotorMin.Text);
            VelocidadMotorMax.Text = Condicionantes.Wrote_Formating(VelocidadMotorMax.Text);

            #endregion VelocidadMotor

            #region LongitudCarrera

            LongitudCarrera.Text = $"{Languages.Pozo.LongitudCarrera} ({Configuracion.GetSigla(Referencia.Diametro, Referencias.Unidades)})";
            LongitudCarreraMin.Text = Condicionantes.Wrote_Formating(LongitudCarreraMin.Text);
            LongitudCarreraMax.Text = Condicionantes.Wrote_Formating(LongitudCarreraMax.Text);

            #endregion LongitudCarrera

            #region EficienciaLlenado

            EficienciaLlenado.Text = $"{Languages.Pozo.EficienciaLlenado} ({Configuracion.GetSigla(Referencia.Porcentaje, Referencias.Unidades)})";
            EficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(EficienciaLlenadoMin.Text);
            EficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(EficienciaLlenadoMax.Text);

            #endregion EficienciaLlenado

            #endregion DatosOperativos

            #region DatosOperativos

            tabPage4.Text = Languages.Pozo.ProductionData;

            #region GastoLiquidoPruebaProduccion

            GastoLiquidoPruebaProduccion.Text = $"{Languages.Pozo.GastoLiquidoPruebaProduccion} ({Configuracion.GetSigla(Referencia.FlujoVolumetricoLiquido, Referencias.Unidades)})";
            GastoLiquidoPruebaProduccionMin.Text = Condicionantes.Wrote_Formating(GastoLiquidoPruebaProduccionMin.Text);
            GastoLiquidoPruebaProduccionMax.Text = Condicionantes.Wrote_Formating(GastoLiquidoPruebaProduccionMax.Text);

            #endregion GastoLiquidoPruebaProduccion

            #region PorcentajeAguaSedimento

            PorcentajeAguaSedimento.Text = $"{Languages.Pozo.PorcentajeAguaSedimento} ({Configuracion.GetSigla(Referencia.Porcentaje, Referencias.Unidades)})";
            PorcentajeAguaSedimentoMin.Text = Condicionantes.Wrote_Formating(PorcentajeAguaSedimentoMin.Text);
            PorcentajeAguaSedimentoMax.Text = Condicionantes.Wrote_Formating(PorcentajeAguaSedimentoMax.Text);

            #endregion PorcentajeAguaSedimento

            #region GastoAceite

            GastoAceite.Text = $"{Languages.Pozo.GastoAceite} ({Configuracion.GetSigla(Referencia.FlujoVolumetricoLiquido, Referencias.Unidades)})";
            GastoAceiteMin.Text = Condicionantes.Wrote_Formating(GastoAceiteMin.Text);
            GastoAceiteMax.Text = Condicionantes.Wrote_Formating(GastoAceiteMax.Text);

            #endregion GastoAceite

            #region GastoGas

            GastoGas.Text = $"{Languages.Pozo.GastoGas} ({Configuracion.GetSigla(Referencia.GastoGas, Referencias.Unidades)})";
            GastoGasMin.Text = Condicionantes.Wrote_Formating(GastoGasMin.Text);
            GastoGasMax.Text = Condicionantes.Wrote_Formating(GastoGasMax.Text);

            #endregion GastoGas

            #region GastoLiquido

            GastoLiquido.Text = $"{Languages.Pozo.GastoLiquido} ({Configuracion.GetSigla(Referencia.FlujoVolumetricoLiquido, Referencias.Unidades)})";
            GastoLiquidoMin.Text = Condicionantes.Wrote_Formating(GastoLiquidoMin.Text);
            GastoLiquidoMax.Text = Condicionantes.Wrote_Formating(GastoLiquidoMax.Text);

            #endregion GastoLiquido

            #region RelacionGasAceite

            RelacionGasAceite.Text = $"{Languages.Pozo.RelacionGasAceite} ({Configuracion.GetSigla(Referencia.RelacionGasAceite, Referencias.Unidades)})";
            RelacionGasAceiteMin.Text = Condicionantes.Wrote_Formating(RelacionGasAceiteMin.Text);
            RelacionGasAceiteMax.Text = Condicionantes.Wrote_Formating(RelacionGasAceiteMax.Text);

            #endregion RelacionGasAceite

            #region GravedadPetroleo

            GravedadPetroleo.Text = $"{Languages.Pozo.GravedadPetroleo} ({Configuracion.GetSigla(Referencia.Densidad, Referencias.Unidades)})";
            GravedadPetroleoMin.Text = Condicionantes.Wrote_Formating(GravedadPetroleoMin.Text);
            GravedadPetroleoMax.Text = Condicionantes.Wrote_Formating(GravedadPetroleoMax.Text);

            #endregion GravedadPetroleo

            #region Emulsion

            Emulsion.Text = $"{Languages.Pozo.Emulsion} ({Configuracion.GetSigla(Referencia.Porcentaje, Referencias.Unidades)})";
            EmulsionMin.Text = Condicionantes.Wrote_Formating(EmulsionMin.Text);
            EmulsionMax.Text = Condicionantes.Wrote_Formating(EmulsionMax.Text);

            #endregion Emulsion

            #region SalinidadAgua

            SalinidadAgua.Text = $"{Languages.Pozo.SalinidadAgua} (ppm)";
            SalinidadAguaMin.Text = Condicionantes.Wrote_Formating(SalinidadAguaMin.Text);
            SalinidadAguaMax.Text = Condicionantes.Wrote_Formating(SalinidadAguaMax.Text);

            #endregion SalinidadAgua

            #region GravedadEspecificaGasProducido

            GravedadEspecificaGasProducido.Text = $"{Languages.Pozo.GravedadEspecificaGasProducido} (-)";
            GravedadEspecificaGasProducidoMin.Text = Condicionantes.Wrote_Formating(GravedadEspecificaGasProducidoMin.Text);
            GravedadEspecificaGasProducidoMax.Text = Condicionantes.Wrote_Formating(GravedadEspecificaGasProducidoMax.Text);

            #endregion GravedadEspecificaGasProducido

            #region CargaSobreBarraPulida

            CargaSobreBarraPulida.Text = $"{Languages.Pozo.CargaSobreBarraPulida} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            CargaSobreBarraPulidaMin.Text = Condicionantes.Wrote_Formating(CargaSobreBarraPulidaMin.Text);
            CargaSobreBarraPulidaMax.Text = Condicionantes.Wrote_Formating(CargaSobreBarraPulidaMax.Text);

            #endregion CargaSobreBarraPulida

            #endregion DatosOperativos

            #region Temporizador

            lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosManual} ({Siglas.Segundo})";
            DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosManual

            #region CartaDinagrafica

            tabPage2.Text = Languages.Pozo.CartaDinagrafica;

            #region CCartaDinagrafica

            CCartaDinagrafica.Text = $"{Languages.Pozo.CartaDinagrafica} ({Configuracion.GetSigla(Referencia.Longitud_Carta, Referencias.Unidades)}/{Configuracion.GetSigla(Referencia.Fuerza, Referencias.Unidades)})";
            CCartaDinagraficaAgregar.Text = Languages.Pozo.Agregar;
            CCartaDinagraficaEliminar.Text = Languages.Pozo.Eliminar;

            #endregion CCartaDinagrafica

            #region Temporizador

            lbTemporizador2.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.CartaDinagrafica} ({Siglas.Segundo})";
            CartaDinagrafica.Text = Condicionantes.Wrote_Formating(CartaDinagrafica.Text);

            #endregion Temporizador

            #endregion CartaDinagrafica
        }

        internal TomaBasica SaveTomaInformacion()
        {
            TomaBasica Range = new TomaBasica();

            #region DatosManual

            #region DatosOperativos

            #region PresionTuberiaProduccion

            Range.PresionTuberiaProduccion = PresionTuberiaProduccion.Checked;
            Range.PresionTuberiaProduccionMin = Convert.ToDecimal(PresionTuberiaProduccionMin.Text);
            Range.PresionTuberiaProduccionMax = Convert.ToDecimal(PresionTuberiaProduccionMax.Text);

            if (Range.PresionTuberiaProduccion)
            {
                string msn = string.Empty;
                if (Range.PresionTuberiaProduccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.PresionTuberiaProduccionMin >= Range.PresionTuberiaProduccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.PresionTuberiaProduccion)
                             .Replace("{1}", $"{Range.PresionTuberiaProduccionMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.PresionTuberiaProduccionMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.PresionTuberiaProduccion = false;
                }
            }

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            Range.PresionTuberiaRevestimiento = PresionTuberiaRevestimiento.Checked;
            Range.PresionTuberiaRevestimientoMin = Convert.ToDecimal(PresionTuberiaRevestimientoMin.Text);
            Range.PresionTuberiaRevestimientoMax = Convert.ToDecimal(PresionTuberiaRevestimientoMax.Text);

            if (Range.PresionTuberiaRevestimiento)
            {
                string msn = string.Empty;
                if (Range.PresionTuberiaRevestimientoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.PresionTuberiaRevestimientoMin >= Range.PresionTuberiaRevestimientoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.PresionTuberiaRevestimiento)
                             .Replace("{1}", $"{Range.PresionTuberiaRevestimientoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.PresionTuberiaRevestimientoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.PresionTuberiaRevestimiento = false;
                }
            }

            #endregion PresionTuberiaRevestimiento

            #region PresionLineaDescarga

            Range.PresionLineaDescarga = PresionLineaDescarga.Checked;
            Range.PresionLineaDescargaMin = Convert.ToDecimal(PresionLineaDescargaMin.Text);
            Range.PresionLineaDescargaMax = Convert.ToDecimal(PresionLineaDescargaMax.Text);

            if (Range.PresionLineaDescarga)
            {
                string msn = string.Empty;
                if (Range.PresionLineaDescargaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.PresionLineaDescargaMin >= Range.PresionLineaDescargaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.PresionLineaDescarga)
                             .Replace("{1}", $"{Range.PresionLineaDescargaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.PresionLineaDescargaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.PresionLineaDescarga = false;
                }
            }

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            Range.TemperaturaSuperficie = TemperaturaSuperficie.Checked;
            Range.TemperaturaSuperficieMin = Convert.ToDecimal(TemperaturaSuperficieMin.Text);
            Range.TemperaturaSuperficieMax = Convert.ToDecimal(TemperaturaSuperficieMax.Text);

            if (Range.TemperaturaSuperficie)
            {
                string msn = string.Empty;
                if (Range.TemperaturaSuperficieMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.TemperaturaSuperficieMin >= Range.TemperaturaSuperficieMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.TemperaturaSuperficie)
                             .Replace("{1}", $"{Range.TemperaturaSuperficieMin} {Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.TemperaturaSuperficieMax} {Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.TemperaturaSuperficie = false;
                }
            }

            #endregion TemperaturaSuperficie

            #region SumergenciaEfectivaBomba

            Range.SumergenciaEfectivaBomba = SumergenciaEfectivaBomba.Checked;
            Range.SumergenciaEfectivaBombaMin = Convert.ToDecimal(SumergenciaEfectivaBombaMin.Text);
            Range.SumergenciaEfectivaBombaMax = Convert.ToDecimal(SumergenciaEfectivaBombaMax.Text);

            if (Range.SumergenciaEfectivaBomba)
            {
                string msn = string.Empty;
                if (Range.SumergenciaEfectivaBombaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.SumergenciaEfectivaBombaMin >= Range.SumergenciaEfectivaBombaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.SumergenciaEfectivaBomba)
                             .Replace("{1}", $"{Range.SumergenciaEfectivaBombaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.SumergenciaEfectivaBombaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.SumergenciaEfectivaBomba = false;
                }
            }

            #endregion SumergenciaEfectivaBomba

            #region NivelFluidoPozoTr

            Range.NivelFluidoPozoTr = NivelFluidoPozoTr.Checked;
            Range.NivelFluidoPozoTrMin = Convert.ToDecimal(NivelFluidoPozoTrMin.Text);
            Range.NivelFluidoPozoTrMax = Convert.ToDecimal(NivelFluidoPozoTrMax.Text);

            if (Range.NivelFluidoPozoTr)
            {
                string msn = string.Empty;
                if (Range.NivelFluidoPozoTrMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.NivelFluidoPozoTrMin >= Range.NivelFluidoPozoTrMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.NivelFluidoPozoTr)
                             .Replace("{1}", $"{Range.NivelFluidoPozoTrMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.NivelFluidoPozoTrMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.NivelFluidoPozoTr = false;
                }
            }

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            Range.PresionEntradaBomba = PresionEntradaBomba.Checked;
            Range.PresionEntradaBombaMin = Convert.ToDecimal(PresionEntradaBombaMin.Text);
            Range.PresionEntradaBombaMax = Convert.ToDecimal(PresionEntradaBombaMax.Text);

            if (Range.PresionEntradaBomba)
            {
                string msn = string.Empty;
                if (Range.PresionEntradaBombaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.PresionEntradaBombaMin >= Range.PresionEntradaBombaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.PresionEntradaBomba)
                             .Replace("{1}", $"{Range.PresionEntradaBombaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.PresionEntradaBombaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.PresionEntradaBomba = false;
                }
            }

            #endregion PresionEntradaBomba

            #region VelocidadUnidadBombeo

            Range.VelocidadUnidadBombeo = VelocidadUnidadBombeo.Checked;
            Range.VelocidadUnidadBombeoMin = Convert.ToDecimal(VelocidadUnidadBombeoMin.Text);
            Range.VelocidadUnidadBombeoMax = Convert.ToDecimal(VelocidadUnidadBombeoMax.Text);

            if (Range.VelocidadUnidadBombeo)
            {
                string msn = string.Empty;
                if (Range.VelocidadUnidadBombeoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.VelocidadUnidadBombeoMin >= Range.VelocidadUnidadBombeoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.VelocidadUnidadBombeo)
                             .Replace("{1}", $"{Range.VelocidadUnidadBombeoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.VelocidadUnidadBombeoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.VelocidadUnidadBombeo = false;
                }
            }

            #endregion VelocidadUnidadBombeo

            #region VelocidadMotor

            Range.VelocidadMotor = VelocidadMotor.Checked;
            Range.VelocidadMotorMin = Convert.ToDecimal(VelocidadMotorMin.Text);
            Range.VelocidadMotorMax = Convert.ToDecimal(VelocidadMotorMax.Text);

            if (Range.VelocidadMotor)
            {
                string msn = string.Empty;
                if (Range.VelocidadMotorMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.VelocidadMotorMin >= Range.VelocidadMotorMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.VelocidadMotor)
                             .Replace("{1}", $"{Range.VelocidadMotorMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.VelocidadMotorMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.VelocidadMotor = false;
                }
            }

            #endregion VelocidadMotor

            #region LongitudCarrera

            Range.LongitudCarrera = LongitudCarrera.Checked;
            Range.LongitudCarreraMin = Convert.ToDecimal(LongitudCarreraMin.Text);
            Range.LongitudCarreraMax = Convert.ToDecimal(LongitudCarreraMax.Text);

            if (Range.LongitudCarrera)
            {
                string msn = string.Empty;
                if (Range.LongitudCarreraMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.LongitudCarreraMin >= Range.LongitudCarreraMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.LongitudCarrera)
                             .Replace("{1}", $"{Range.LongitudCarreraMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.LongitudCarreraMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.LongitudCarrera = false;
                }
            }

            #endregion LongitudCarrera

            #region EficienciaLlenado

            Range.EficienciaLlenado = EficienciaLlenado.Checked;
            Range.EficienciaLlenadoMin = Convert.ToDecimal(EficienciaLlenadoMin.Text);
            Range.EficienciaLlenadoMax = Convert.ToDecimal(EficienciaLlenadoMax.Text);

            if (Range.EficienciaLlenado)
            {
                string msn = string.Empty;
                if (Range.EficienciaLlenadoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.EficienciaLlenadoMin >= Range.EficienciaLlenadoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.EficienciaLlenado)
                             .Replace("{1}", $"{Range.EficienciaLlenadoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.EficienciaLlenadoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.EficienciaLlenado = false;
                }
            }

            #endregion EficienciaLlenado

            #endregion DatosOperativos

            #region DatosProduccion

            #region GastoLiquidoPruebaProduccion

            Range.GastoLiquidoPruebaProduccion = GastoLiquidoPruebaProduccion.Checked;
            Range.GastoLiquidoPruebaProduccionMin = Convert.ToDecimal(GastoLiquidoPruebaProduccionMin.Text);
            Range.GastoLiquidoPruebaProduccionMax = Convert.ToDecimal(GastoLiquidoPruebaProduccionMax.Text);

            if (Range.GastoLiquidoPruebaProduccion)
            {
                string msn = string.Empty;
                if (Range.GastoLiquidoPruebaProduccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GastoLiquidoPruebaProduccionMin >= Range.GastoLiquidoPruebaProduccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GastoLiquidoPruebaProduccion)
                             .Replace("{1}", $"{Range.GastoLiquidoPruebaProduccionMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GastoLiquidoPruebaProduccionMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GastoLiquidoPruebaProduccion = false;
                }
            }

            #endregion GastoLiquidoPruebaProduccion

            #region PorcentajeAguaSedimento

            Range.PorcentajeAguaSedimento = PorcentajeAguaSedimento.Checked;
            Range.PorcentajeAguaSedimentoMin = Convert.ToDecimal(PorcentajeAguaSedimentoMin.Text);
            Range.PorcentajeAguaSedimentoMax = Convert.ToDecimal(PorcentajeAguaSedimentoMax.Text);

            if (Range.PorcentajeAguaSedimento)
            {
                string msn = string.Empty;
                if (Range.PorcentajeAguaSedimentoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.PorcentajeAguaSedimentoMin >= Range.PorcentajeAguaSedimentoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.PorcentajeAguaSedimento)
                             .Replace("{1}", $"{Range.PorcentajeAguaSedimentoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.PorcentajeAguaSedimentoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.PorcentajeAguaSedimento = false;
                }
            }

            #endregion PorcentajeAguaSedimento

            #region GastoAceite

            Range.GastoAceite = GastoAceite.Checked;
            Range.GastoAceiteMin = Convert.ToDecimal(GastoAceiteMin.Text);
            Range.GastoAceiteMax = Convert.ToDecimal(GastoAceiteMax.Text);

            if (Range.GastoAceite)
            {
                string msn = string.Empty;
                if (Range.GastoAceiteMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GastoAceiteMin >= Range.GastoAceiteMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GastoAceite)
                             .Replace("{1}", $"{Range.GastoAceiteMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GastoAceiteMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GastoAceite = false;
                }
            }

            #endregion GastoAceite

            #region GastoGas

            Range.GastoGas = GastoGas.Checked;
            Range.GastoGasMin = Convert.ToDecimal(GastoGasMin.Text);
            Range.GastoGasMax = Convert.ToDecimal(GastoGasMax.Text);

            if (Range.GastoGas)
            {
                string msn = string.Empty;
                if (Range.GastoGasMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GastoGasMin >= Range.GastoGasMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GastoGas)
                             .Replace("{1}", $"{Range.GastoGasMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GastoGasMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GastoGas = false;
                }
            }

            #endregion GastoGas

            #region GastoLiquido

            Range.GastoLiquido = GastoLiquido.Checked;
            Range.GastoLiquidoMin = Convert.ToDecimal(GastoLiquidoMin.Text);
            Range.GastoLiquidoMax = Convert.ToDecimal(GastoLiquidoMax.Text);

            if (Range.GastoLiquido)
            {
                string msn = string.Empty;
                if (Range.GastoLiquidoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GastoLiquidoMin >= Range.GastoLiquidoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GastoLiquido)
                             .Replace("{1}", $"{Range.GastoLiquidoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GastoLiquidoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GastoLiquido = false;
                }
            }

            #endregion GastoLiquido

            #region RelacionGasAceite

            Range.RelacionGasAceite = RelacionGasAceite.Checked;
            Range.RelacionGasAceiteMin = Convert.ToDecimal(RelacionGasAceiteMin.Text);
            Range.RelacionGasAceiteMax = Convert.ToDecimal(RelacionGasAceiteMax.Text);

            if (Range.RelacionGasAceite)
            {
                string msn = string.Empty;
                if (Range.RelacionGasAceiteMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.RelacionGasAceiteMin >= Range.RelacionGasAceiteMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.RelacionGasAceite)
                             .Replace("{1}", $"{Range.RelacionGasAceiteMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.RelacionGasAceiteMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.RelacionGasAceite = false;
                }
            }

            #endregion RelacionGasAceite

            #region GravedadPetroleo

            Range.GravedadPetroleo = GravedadPetroleo.Checked;
            Range.GravedadPetroleoMin = Convert.ToDecimal(GravedadPetroleoMin.Text);
            Range.GravedadPetroleoMax = Convert.ToDecimal(GravedadPetroleoMax.Text);

            if (Range.GravedadPetroleo)
            {
                string msn = string.Empty;
                if (Range.GravedadPetroleoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GravedadPetroleoMin >= Range.GravedadPetroleoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GravedadPetroleo)
                             .Replace("{1}", $"{Range.GravedadPetroleoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GravedadPetroleoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GravedadPetroleo = false;
                }
            }

            #endregion GravedadPetroleo

            #region Emulsion

            Range.Emulsion = Emulsion.Checked;
            Range.EmulsionMin = Convert.ToDecimal(EmulsionMin.Text);
            Range.EmulsionMax = Convert.ToDecimal(EmulsionMax.Text);

            if (Range.Emulsion)
            {
                string msn = string.Empty;
                if (Range.EmulsionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.EmulsionMin >= Range.EmulsionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.Emulsion)
                             .Replace("{1}", $"{Range.EmulsionMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.EmulsionMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.Emulsion = false;
                }
            }

            #endregion Emulsion

            #region SalinidadAgua

            Range.SalinidadAgua = SalinidadAgua.Checked;
            Range.SalinidadAguaMin = Convert.ToDecimal(SalinidadAguaMin.Text);
            Range.SalinidadAguaMax = Convert.ToDecimal(SalinidadAguaMax.Text);

            if (Range.SalinidadAgua)
            {
                string msn = string.Empty;
                if (Range.SalinidadAguaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.SalinidadAguaMin >= Range.SalinidadAguaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.SalinidadAgua)
                             .Replace("{1}", $"{Range.SalinidadAguaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.SalinidadAguaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.SalinidadAgua = false;
                }
            }

            #endregion SalinidadAgua

            #region GravedadEspecificaGasProducido

            Range.GravedadEspecificaGasProducido = GravedadEspecificaGasProducido.Checked;
            Range.GravedadEspecificaGasProducidoMin = Convert.ToDecimal(GravedadEspecificaGasProducidoMin.Text);
            Range.GravedadEspecificaGasProducidoMax = Convert.ToDecimal(GravedadEspecificaGasProducidoMax.Text);

            if (Range.GravedadEspecificaGasProducido)
            {
                string msn = string.Empty;
                if (Range.GravedadEspecificaGasProducidoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GravedadEspecificaGasProducidoMin >= Range.GravedadEspecificaGasProducidoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GravedadEspecificaGasProducido)
                             .Replace("{1}", $"{Range.GravedadEspecificaGasProducidoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GravedadEspecificaGasProducidoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GravedadEspecificaGasProducido = false;
                }
            }

            #endregion GravedadEspecificaGasProducido

            #region CargaSobreBarraPulida

            Range.CargaSobreBarraPulida = CargaSobreBarraPulida.Checked;
            Range.CargaSobreBarraPulidaMin = Convert.ToDecimal(CargaSobreBarraPulidaMin.Text);
            Range.CargaSobreBarraPulidaMax = Convert.ToDecimal(CargaSobreBarraPulidaMax.Text);

            if (Range.CargaSobreBarraPulida)
            {
                string msn = string.Empty;
                if (Range.CargaSobreBarraPulidaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.CargaSobreBarraPulidaMin >= Range.CargaSobreBarraPulidaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.CargaSobreBarraPulida)
                             .Replace("{1}", $"{Range.CargaSobreBarraPulidaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.CargaSobreBarraPulidaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.CargaSobreBarraPulida = false;
                }
            }

            #endregion CargaSobreBarraPulida

            #endregion DatosProduccion

            #region Temporizador

            Range.DatosOperativos = TimeSpan.FromSeconds(Convert.ToDouble(DatosOperativos.Text));

            #endregion Temporizador

            #endregion DatosManual

            #region CartaDinagrafica

            #region CCartaDinagrafica

            Range.CCartaDinagrafica = CCartaDinagrafica.Checked;
            Range.ListCCartaDinagrafica = ListCCartaDinagrafica.Select(val => val.Carta).ToList();

            if (Range.CCartaDinagrafica && Range.ListCCartaDinagrafica.Count <= 0)
            {
                MessageBox.Show(Languages.Pozo.Error.Replace("\\n", "\n"), "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                Range.CCartaDinagrafica = false;
            }

            #endregion CCartaDinagrafica

            #region Temporizador

            Range.CartaDinagrafica = TimeSpan.FromSeconds(Convert.ToDouble(CartaDinagrafica.Text));

            #endregion Temporizador

            #endregion CartaDinagrafica

            return Range;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string Name = ((CheckBox)sender).Name;
            foreach (TextBox txb in tlpVariables.Controls.OfType<TextBox>())
                if (txb.Name.Contains(Name))
                {
                    txb.Enabled = ((CheckBox)sender).Checked;
                }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            string Name = ((CheckBox)sender).Name;
            foreach (TextBox txb in tlpVariables2.Controls.OfType<TextBox>())
                if (txb.Name.Contains(Name))
                {
                    txb.Enabled = ((CheckBox)sender).Checked;
                }
        }

        private void Wrote_KeyPress(object sender, KeyPressEventArgs e) => Condicionantes.Wrote_KeyPress(sender, e);

        private void Wrote_Leave(object sender, EventArgs e) => ((TextBox)sender).Text = Condicionantes.Wrote_Formating(((TextBox)sender).Text);

        #region CCartaDinagrafica

        private class lista
        {
            public OCartaDinagrafica.CTomaCarta Carta { get; set; }

            public int index { get; set; }
        }

        private void CCartaDinagrafica_CheckedChanged(object sender, EventArgs e)
        {
            CCartaDinagraficaList.Enabled = CCartaDinagrafica.Checked;
            CCartaDinagraficaAgregar.Enabled = CCartaDinagrafica.Checked;
            CCartaDinagraficaEliminar.Enabled = CCartaDinagrafica.Checked;
        }

        private void CCartaDinagraficaAgregar_Click(object sender, EventArgs e)
        {
            List<List<OCartaDinagrafica.CartaSuperficie>> newLista = SeleccionarArchivo();

            if (newLista.Count > 0)
            {
                newLista.ForEach(val =>
                {
                    if (!ListCCartaDinagrafica.Exists(x => JsonConvert.SerializeObject(x.Carta) == JsonConvert.SerializeObject(val)))
                    {
                        ListCCartaDinagrafica.Add(new lista() { Carta = new OCartaDinagrafica.CTomaCarta() { CartaSuperficie = val } });
                    }
                });

                SaveTomaInformacion();
                for (int i = 0; i < ListCCartaDinagrafica.Count; i++)
                    ListCCartaDinagrafica[i].index = i;

                object SelectDdl = CCartaDinagraficaList.SelectedItem;
                CCartaDinagraficaList.DataSource=null;
                CCartaDinagraficaList.DataSource = ListCCartaDinagrafica;
                CCartaDinagraficaList.DisplayMember = "index";
                if (ListCCartaDinagrafica.Count > 0)
                {
                    if (SelectDdl != null)
                    {
                        int index = ((lista)SelectDdl).index;
                        if (0 <= index && index <= ListCCartaDinagrafica.Max(val => val.index))
                            CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica[index];
                        else
                            CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica.Last();
                    }
                    else
                        CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica.First();
                }
                else
                    CCartaDinagraficaList.SelectedItem = null;

                CCartaDinagraficaList_SelectedIndexChanged(null, null);
            }
        }

        #region Load carta

        protected List<List<OCartaDinagrafica.CartaSuperficie>> SeleccionarArchivo()
        {
            List<List<OCartaDinagrafica.CartaSuperficie>> cartas = new List<List<OCartaDinagrafica.CartaSuperficie>>();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog file = openFileDialog1;

                //Empezamos a manejar el archivo
                string archivo = file.FileName;
                string extencion = Path.GetExtension(archivo);

                switch (extencion.ToLower())
                {
                    case ".xls":
                    case ".xlsx":
                        cartas = LeerExcel(archivo);
                        if (cartas.Count <= 0)
                            MessageBox.Show(Languages.Pozo.ErrorCarta.Replace("\\n", "\n"), Languages.Pozo.Aviso, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                        break;

                    case ".json":
                        cartas = LeerJson(archivo);
                        if (cartas.Count <= 0)
                            MessageBox.Show(Languages.Pozo.ErrorCarta.Replace("\\n", "\n"), Languages.Pozo.Aviso, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                        break;

                    default:
                        MessageBox.Show(General.FileError);
                        break;
                }
            }

            return cartas;
        }

        #region Excel

        protected static List<List<OCartaDinagrafica.CartaSuperficie>> LeerExcel(string Archivo)
        {
            List<List<OCartaDinagrafica.CartaSuperficie>> CartaDinagrafica = new List<List<OCartaDinagrafica.CartaSuperficie>>();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open($"{Archivo}", 0, true, 5, "", "", true,
                                                                 Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range range;

            int i = 1;
            try
            {
                bool tr = true;
                while (tr)
                {
                    try
                    {
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(i);
                    }
                    catch
                    {
                        break;
                    }
                    range = xlWorkSheet.UsedRange;
                    int rw = range.Rows.Count;
                    int cl = range.Columns.Count;

                    int Position = -1;
                    int Load = -1;
                    int k = 0;
                    for (k = 1; k <= rw; k++)
                    {
                        for (int j = 1; j <= cl; j++)
                        {
                            try
                            {
                                string str = (string)(range.Cells[k, j] as Excel.Range).Value2;

                                if (str == "Pump Card Position")
                                    Position = j;
                                if (str == "Pump Card Load")
                                    Load = j;
                            }
                            catch
                            {
                            }
                            if (Position >= 0 && Load >= 0 && Position != Load)
                                break;
                        }

                        if (Position >= 0 && Load >= 0 && Position != Load)
                            break;
                    }

                    if (Position >= 0 && Load >= 0 && Position != Load)
                    {
                        List<OCartaDinagrafica.CartaSuperficie> cartaDinagrafica = new List<OCartaDinagrafica.CartaSuperficie>();
                        for (int j = k + 1; j <= rw; j++)
                        {
                            try
                            {
                                decimal val1 = (decimal)(range.Cells[j, Position] as Excel.Range).Value2;
                                decimal val2 = (decimal)(range.Cells[j, Load] as Excel.Range).Value2;

                                OCartaDinagrafica.CartaSuperficie Fila = new OCartaDinagrafica.CartaSuperficie()
                                {
                                    Distancia = val1,
                                    Fuerza = val2,
                                };
                                cartaDinagrafica.Add(Fila);
                            }
                            catch
                            {
                            }
                        }

                        CartaDinagrafica.Add(cartaDinagrafica);
                    }
                    i++;
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
            }
            finally
            {
                //Funcione o no, cerramos la cadena de conexión
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }

            return CartaDinagrafica;
        }

        protected static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("No se puede liberar el objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion Excel

        #region Json

        protected static List<List<OCartaDinagrafica.CartaSuperficie>> LeerJson(string Archivo)
        {
            List<List<OCartaDinagrafica.CartaSuperficie>> CartaDinagrafica = new List<List<OCartaDinagrafica.CartaSuperficie>>();
            string data = File.ReadAllText(Archivo);

            {
                try
                {
                    var t1 = JsonConvert.DeserializeObject<List<OCartaDinagrafica.CartaSuperficie>>(data);
                    CartaDinagrafica.Add(t1);
                }
                catch
                {
                }

                try
                {
                    var t1 = JsonConvert.DeserializeObject<List<List<OCartaDinagrafica.CartaSuperficie>>>(data);
                    CartaDinagrafica.AddRange(t1);
                }
                catch
                {
                }
            }

            {
                // Root1
                try
                {
                    var t1 = JsonConvert.DeserializeObject<Root1>(data);
                    CartaDinagrafica.Add(t1.oDinamometrica);
                }
                catch
                {
                }

                try
                {
                    var t1 = JsonConvert.DeserializeObject<List<Root1>>(data);
                    CartaDinagrafica.AddRange(t1.Select(val => val.oDinamometrica));
                }
                catch
                {
                }
            }

            {
                // Root2
                try
                {
                    var t1 = JsonConvert.DeserializeObject<Root2>(data);
                    CartaDinagrafica.Add(t1.CartaSuperficie);
                }
                catch
                {
                }

                try
                {
                    var t1 = JsonConvert.DeserializeObject<List<Root2>>(data);
                    CartaDinagrafica.AddRange(t1.Select(val => val.CartaSuperficie));
                }
                catch
                {
                }
            }

            {
                // Root3
                try
                {
                    var t1 = JsonConvert.DeserializeObject<Root3>(data);
                    CartaDinagrafica.Add(t1.CartaDinagrafica);
                }
                catch
                {
                }

                try
                {
                    var t1 = JsonConvert.DeserializeObject<List<Root3>>(data);
                    CartaDinagrafica.AddRange(t1.Select(val => val.CartaDinagrafica));
                }
                catch
                {
                }
            }

            return CartaDinagrafica;
        }

        public class Root1
        {
            public List<OCartaDinagrafica.CartaSuperficie> oDinamometrica { get; set; }
        }

        public class Root2
        {
            public List<OCartaDinagrafica.CartaSuperficie> CartaSuperficie { get; set; }
        }

        public class Root3
        {
            public List<OCartaDinagrafica.CartaSuperficie> CartaDinagrafica { get; set; }
        }

        #endregion Json

        #endregion Load carta

        private void CCartaDinagraficaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ListCCartaDinagrafica.RemoveAt(CCartaDinagraficaList.SelectedIndex);

                SaveTomaInformacion();

                for (int i = 0; i < ListCCartaDinagrafica.Count; i++)
                    ListCCartaDinagrafica[i].index = i;

                object SelectDdl = CCartaDinagraficaList.SelectedItem;
                CCartaDinagraficaList.DataSource = ListCCartaDinagrafica;
                CCartaDinagraficaList.DisplayMember = "index";
                if (ListCCartaDinagrafica.Count > 0)
                {
                    if (SelectDdl != null)
                    {
                        int index = ((lista)SelectDdl).index;
                        if (0 <= index && index <= ListCCartaDinagrafica.Max(val => val.index))
                            CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica[index];
                        else
                            CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica.Last();
                    }
                    else
                        CCartaDinagraficaList.SelectedItem = ListCCartaDinagrafica.First();
                }
                else
                    CCartaDinagraficaList.SelectedItem = null;

                CCartaDinagraficaList_SelectedIndexChanged(null, null);
            }
            catch
            {
            }
        }

        private void CCartaDinagraficaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<OCartaDinagrafica.CartaSuperficie> CCartaDinagrafica;
            try
            {
                CCartaDinagrafica = ListCCartaDinagrafica[((lista)CCartaDinagraficaList.SelectedItem).index].Carta.CartaSuperficie;
            }
            catch
            {
                CCartaDinagrafica = new List<OCartaDinagrafica.CartaSuperficie>();
            }
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
            diagram.AxisX.Title.Text = $"{Languages.Graphics.Axis_Desplazamiento} ({Configuracion.GetSigla(Referencia.Longitud_Carta, Referencias.Unidades)})";
            diagram.AxisX.Title.Visibility = DefaultBoolean.True;
            diagram.AxisX.Title.Alignment = StringAlignment.Center;
            diagram.AxisX.Title.EnableAntialiasing = DefaultBoolean.True;

            // Customize the appearance of the Carga (klbf).
            diagram.AxisY.Title.Text = $"{Languages.Graphics.Axis_Carga} ({Configuracion.GetSigla(Referencia.Fuerza, Referencias.Unidades)})";
            diagram.AxisY.Title.Visibility = DefaultBoolean.True;
            diagram.AxisY.Title.Alignment = StringAlignment.Center;
            diagram.AxisY.Title.EnableAntialiasing = DefaultBoolean.True;
        }

        #endregion CCartaDinagrafica

        private void TomaInformacion_Load(object sender, EventArgs e) => Recargar();
    }
}