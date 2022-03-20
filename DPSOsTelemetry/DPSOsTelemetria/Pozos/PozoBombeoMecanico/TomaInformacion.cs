using Newtonsoft.Json;
using System.Data;
using System.Security;
using Telemetria;
using Excel = Microsoft.Office.Interop.Excel;

namespace DPSOsTelemetria.Pozos.PozoBombeoMecanico
{
    public partial class TomaInformacion : UserControl
    {
        private readonly ReferenciasII Referencias;
        private List<lista> ListCCartaDinagrafica = new();

        public TomaInformacion()
        {
            InitializeComponent();
        }

        public TomaInformacion(ReferenciasII referencias) : this()
        {
            Referencias = referencias;

            #region DatosOperativos

            #region DoPresionTuberiaProduccion

            DoPresionTuberiaProduccion.Checked = referencias.Range.DoPresionTuberiaProduccion;
            DoPresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaProduccionMin.ToString());
            DoPresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaProduccionMax.ToString());

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            DoPresionTuberiaRevestimiento.Checked = referencias.Range.DoPresionTuberiaRevestimiento;
            DoPresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaRevestimientoMin.ToString());
            DoPresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaRevestimientoMax.ToString());

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionLineaDescarga

            DoPresionLineaDescarga.Checked = referencias.Range.DoPresionLineaDescarga;
            DoPresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionLineaDescargaMin.ToString());
            DoPresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionLineaDescargaMax.ToString());

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            DoTemperaturaSuperficie.Checked = referencias.Range.DoTemperaturaSuperficie;
            DoTemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTemperaturaSuperficieMin.ToString());
            DoTemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTemperaturaSuperficieMax.ToString());

            #endregion DoTemperaturaSuperficie

            #region DoSumergenciaEfectivaBomba

            DoSumergenciaEfectivaBomba.Checked = referencias.Range.DoSumergenciaEfectivaBomba;
            DoSumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoSumergenciaEfectivaBombaMin.ToString());
            DoSumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoSumergenciaEfectivaBombaMax.ToString());

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTr

            DoNivelFluidoPozoTr.Checked = referencias.Range.DoNivelFluidoPozoTr;
            DoNivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoNivelFluidoPozoTrMin.ToString());
            DoNivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoNivelFluidoPozoTrMax.ToString());

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            DoPresionEntradaBomba.Checked = referencias.Range.DoPresionEntradaBomba;
            DoPresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionEntradaBombaMin.ToString());
            DoPresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionEntradaBombaMax.ToString());

            #endregion DoPresionEntradaBomba

            #region DoVelocidadUnidadBombeo

            DoVelocidadUnidadBombeo.Checked = referencias.Range.DoVelocidadUnidadBombeo;
            DoVelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadUnidadBombeoMin.ToString());
            DoVelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadUnidadBombeoMax.ToString());

            #endregion DoVelocidadUnidadBombeo

            #region DoVelocidadMotor

            DoVelocidadMotor.Checked = referencias.Range.DoVelocidadMotor;
            DoVelocidadMotorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadMotorMin.ToString());
            DoVelocidadMotorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadMotorMax.ToString());

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            DoLongitudCarrera.Checked = referencias.Range.DoLongitudCarrera;
            DoLongitudCarreraMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoLongitudCarreraMin.ToString());
            DoLongitudCarreraMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoLongitudCarreraMax.ToString());

            #endregion DoLongitudCarrera

            #region DoEficienciaLlenado

            DoEficienciaLlenado.Checked = referencias.Range.DoEficienciaLlenado;
            DoEficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoEficienciaLlenadoMin.ToString());
            DoEficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoEficienciaLlenadoMax.ToString());

            #endregion DoEficienciaLlenado

            #region Temporizador

            DatosOperativos.Text = Condicionantes.Wrote_Formating(referencias.Range.DatosOperativos.TotalSeconds.ToString());
            DatosOperativos.Leave += Wrote_Leave;
            DatosOperativos.KeyPress += Wrote_KeyPress;

            #endregion Temporizador

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

            Recargar();
        }

        internal void Recargar()
        {
            #region DatosOperativos

            tabPage1.Text = Languages.Pozo.DatosOperativos;

            #region DoPresionTuberiaProduccion

            DoPresionTuberiaProduccion.Text = $"{Languages.Pozo.DoPresionTuberiaProduccion} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            DoPresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaProduccionMin.Text);
            DoPresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaProduccionMax.Text);

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            DoPresionTuberiaRevestimiento.Text = $"{Languages.Pozo.DoPresionTuberiaRevestimiento} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            DoPresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaRevestimientoMin.Text);
            DoPresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaRevestimientoMax.Text);

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionLineaDescarga

            DoPresionLineaDescarga.Text = $"{Languages.Pozo.DoPresionLineaDescarga} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            DoPresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(DoPresionLineaDescargaMin.Text);
            DoPresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(DoPresionLineaDescargaMax.Text);

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            DoTemperaturaSuperficie.Text = $"{Languages.Pozo.DoTemperaturaSuperficie} ({ Configuracion.GetSigla(Siglas.Temperatura, Referencias.Unidades)})";
            DoTemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(DoTemperaturaSuperficieMin.Text);
            DoTemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(DoTemperaturaSuperficieMax.Text);

            #endregion DoTemperaturaSuperficie

            #region DoSumergenciaEfectivaBomba

            DoSumergenciaEfectivaBomba.Text = $"{Languages.Pozo.DoSumergenciaEfectivaBomba} ({ Configuracion.GetSigla(Siglas.Distancia, Referencias.Unidades)})";
            DoSumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(DoSumergenciaEfectivaBombaMin.Text);
            DoSumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(DoSumergenciaEfectivaBombaMax.Text);

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTr

            DoNivelFluidoPozoTr.Text = $"{Languages.Pozo.DoNivelFluidoPozoTr} ({ Configuracion.GetSigla(Siglas.Distancia, Referencias.Unidades)})";
            DoNivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(DoNivelFluidoPozoTrMin.Text);
            DoNivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(DoNivelFluidoPozoTrMax.Text);

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            DoPresionEntradaBomba.Text = $"{Languages.Pozo.DoPresionEntradaBomba} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            DoPresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(DoPresionEntradaBombaMin.Text);
            DoPresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(DoPresionEntradaBombaMax.Text);

            #endregion DoPresionEntradaBomba

            #region DoVelocidadUnidadBombeo

            DoVelocidadUnidadBombeo.Text = $"{Languages.Pozo.DoVelocidadUnidadBombeo} ({ Configuracion.GetSigla(Siglas.Embolada, Referencias.Unidades)})";
            DoVelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(DoVelocidadUnidadBombeoMin.Text);
            DoVelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(DoVelocidadUnidadBombeoMax.Text);

            #endregion DoVelocidadUnidadBombeo

            #region DoVelocidadMotor

            DoVelocidadMotor.Text = $"{Languages.Pozo.DoVelocidadMotor} ({ Configuracion.GetSigla(Siglas.Velocidad, Referencias.Unidades)})";
            DoVelocidadMotorMin.Text = Condicionantes.Wrote_Formating(DoVelocidadMotorMin.Text);
            DoVelocidadMotorMax.Text = Condicionantes.Wrote_Formating(DoVelocidadMotorMax.Text);

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            DoLongitudCarrera.Text = $"{Languages.Pozo.DoLongitudCarrera} ({ Configuracion.GetSigla(Siglas.Distancia, Referencias.Unidades)})";
            DoLongitudCarreraMin.Text = Condicionantes.Wrote_Formating(DoLongitudCarreraMin.Text);
            DoLongitudCarreraMax.Text = Condicionantes.Wrote_Formating(DoLongitudCarreraMax.Text);

            #endregion DoLongitudCarrera

            #region DoEficienciaLlenado

            DoEficienciaLlenado.Text = $"{Languages.Pozo.DoEficienciaLlenado} ({ Configuracion.GetSigla(Siglas.Porcentaje, Referencias.Unidades)})";
            DoEficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(DoEficienciaLlenadoMin.Text);
            DoEficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(DoEficienciaLlenadoMax.Text);

            #endregion DoEficienciaLlenado

            #region Temporizador

            lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosOperativos} ({Languages.Siglas.Segundo})";
            DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosOperativos

            #region CartaDinagrafica

            tabPage2.Text = Languages.Pozo.CartaDinagrafica;

            #region CCartaDinagrafica

            CCartaDinagrafica.Text = $"{Languages.Pozo.CartaDinagrafica} ({ Configuracion.GetSigla(Siglas.Longitud_Carta, Referencias.Unidades)}/{ Configuracion.GetSigla(Siglas.Fuerza, Referencias.Unidades)})";
            CCartaDinagraficaAgregar.Text = Languages.Pozo.Agregar;
            CCartaDinagraficaEliminar.Text = Languages.Pozo.Eliminar;

            #endregion CCartaDinagrafica

            #region Temporizador

            lbTemporizador2.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.CartaDinagrafica} ({Languages.Siglas.Segundo})";
            CartaDinagrafica.Text = Condicionantes.Wrote_Formating(CartaDinagrafica.Text);

            #endregion Temporizador

            #endregion CartaDinagrafica
        }

        internal TomaBasica SaveTomaInformacion()
        {
            TomaBasica Range = new();

            #region DatosOperativos

            #region DoPresionTuberiaProduccion

            Range.DoPresionTuberiaProduccion = DoPresionTuberiaProduccion.Checked;
            Range.DoPresionTuberiaProduccionMin = Convert.ToDecimal(DoPresionTuberiaProduccionMin.Text);
            Range.DoPresionTuberiaProduccionMax = Convert.ToDecimal(DoPresionTuberiaProduccionMax.Text);

            if (Range.DoPresionTuberiaProduccion)
            {
                string msn = string.Empty;
                if (Range.DoPresionTuberiaProduccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoPresionTuberiaProduccionMin >= Range.DoPresionTuberiaProduccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoPresionTuberiaProduccion)
                             .Replace("{1}", $"{Range.DoPresionTuberiaProduccionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoPresionTuberiaProduccionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoPresionTuberiaProduccion = false;
                }
            }

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            Range.DoPresionTuberiaRevestimiento = DoPresionTuberiaRevestimiento.Checked;
            Range.DoPresionTuberiaRevestimientoMin = Convert.ToDecimal(DoPresionTuberiaRevestimientoMin.Text);
            Range.DoPresionTuberiaRevestimientoMax = Convert.ToDecimal(DoPresionTuberiaRevestimientoMax.Text);

            if (Range.DoPresionTuberiaRevestimiento)
            {
                string msn = string.Empty;
                if (Range.DoPresionTuberiaRevestimientoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoPresionTuberiaRevestimientoMin >= Range.DoPresionTuberiaRevestimientoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoPresionTuberiaRevestimiento)
                             .Replace("{1}", $"{Range.DoPresionTuberiaRevestimientoMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoPresionTuberiaRevestimientoMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoPresionTuberiaRevestimiento = false;
                }
            }

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionLineaDescarga

            Range.DoPresionLineaDescarga = DoPresionLineaDescarga.Checked;
            Range.DoPresionLineaDescargaMin = Convert.ToDecimal(DoPresionLineaDescargaMin.Text);
            Range.DoPresionLineaDescargaMax = Convert.ToDecimal(DoPresionLineaDescargaMax.Text);

            if (Range.DoPresionLineaDescarga)
            {
                string msn = string.Empty;
                if (Range.DoPresionLineaDescargaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoPresionLineaDescargaMin >= Range.DoPresionLineaDescargaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoPresionLineaDescarga)
                             .Replace("{1}", $"{Range.DoPresionLineaDescargaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoPresionLineaDescargaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoPresionLineaDescarga = false;
                }
            }

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            Range.DoTemperaturaSuperficie = DoTemperaturaSuperficie.Checked;
            Range.DoTemperaturaSuperficieMin = Convert.ToDecimal(DoTemperaturaSuperficieMin.Text);
            Range.DoTemperaturaSuperficieMax = Convert.ToDecimal(DoTemperaturaSuperficieMax.Text);

            if (Range.DoTemperaturaSuperficie)
            {
                string msn = string.Empty;
                if (Range.DoTemperaturaSuperficieMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoTemperaturaSuperficieMin >= Range.DoTemperaturaSuperficieMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoTemperaturaSuperficie)
                             .Replace("{1}", $"{Range.DoTemperaturaSuperficieMin} { Configuracion.GetSigla(Siglas.Temperatura, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoTemperaturaSuperficieMax} { Configuracion.GetSigla(Siglas.Temperatura, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoTemperaturaSuperficie = false;
                }
            }

            #endregion DoTemperaturaSuperficie

            #region DoSumergenciaEfectivaBomba

            Range.DoSumergenciaEfectivaBomba = DoSumergenciaEfectivaBomba.Checked;
            Range.DoSumergenciaEfectivaBombaMin = Convert.ToDecimal(DoSumergenciaEfectivaBombaMin.Text);
            Range.DoSumergenciaEfectivaBombaMax = Convert.ToDecimal(DoSumergenciaEfectivaBombaMax.Text);

            if (Range.DoSumergenciaEfectivaBomba)
            {
                string msn = string.Empty;
                if (Range.DoSumergenciaEfectivaBombaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoSumergenciaEfectivaBombaMin >= Range.DoSumergenciaEfectivaBombaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoSumergenciaEfectivaBomba)
                             .Replace("{1}", $"{Range.DoSumergenciaEfectivaBombaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoSumergenciaEfectivaBombaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoSumergenciaEfectivaBomba = false;
                }
            }

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTr

            Range.DoNivelFluidoPozoTr = DoNivelFluidoPozoTr.Checked;
            Range.DoNivelFluidoPozoTrMin = Convert.ToDecimal(DoNivelFluidoPozoTrMin.Text);
            Range.DoNivelFluidoPozoTrMax = Convert.ToDecimal(DoNivelFluidoPozoTrMax.Text);

            if (Range.DoNivelFluidoPozoTr)
            {
                string msn = string.Empty;
                if (Range.DoNivelFluidoPozoTrMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoNivelFluidoPozoTrMin >= Range.DoNivelFluidoPozoTrMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoNivelFluidoPozoTr)
                             .Replace("{1}", $"{Range.DoNivelFluidoPozoTrMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoNivelFluidoPozoTrMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoNivelFluidoPozoTr = false;
                }
            }

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            Range.DoPresionEntradaBomba = DoPresionEntradaBomba.Checked;
            Range.DoPresionEntradaBombaMin = Convert.ToDecimal(DoPresionEntradaBombaMin.Text);
            Range.DoPresionEntradaBombaMax = Convert.ToDecimal(DoPresionEntradaBombaMax.Text);

            if (Range.DoPresionEntradaBomba)
            {
                string msn = string.Empty;
                if (Range.DoPresionEntradaBombaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoPresionEntradaBombaMin >= Range.DoPresionEntradaBombaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoPresionEntradaBomba)
                             .Replace("{1}", $"{Range.DoPresionEntradaBombaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoPresionEntradaBombaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoPresionEntradaBomba = false;
                }
            }

            #endregion DoPresionEntradaBomba

            #region DoVelocidadUnidadBombeo

            Range.DoVelocidadUnidadBombeo = DoVelocidadUnidadBombeo.Checked;
            Range.DoVelocidadUnidadBombeoMin = Convert.ToDecimal(DoVelocidadUnidadBombeoMin.Text);
            Range.DoVelocidadUnidadBombeoMax = Convert.ToDecimal(DoVelocidadUnidadBombeoMax.Text);

            if (Range.DoVelocidadUnidadBombeo)
            {
                string msn = string.Empty;
                if (Range.DoVelocidadUnidadBombeoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoVelocidadUnidadBombeoMin >= Range.DoVelocidadUnidadBombeoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoVelocidadUnidadBombeo)
                             .Replace("{1}", $"{Range.DoVelocidadUnidadBombeoMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoVelocidadUnidadBombeoMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoVelocidadUnidadBombeo = false;
                }
            }

            #endregion DoVelocidadUnidadBombeo

            #region DoVelocidadMotor

            Range.DoVelocidadMotor = DoVelocidadMotor.Checked;
            Range.DoVelocidadMotorMin = Convert.ToDecimal(DoVelocidadMotorMin.Text);
            Range.DoVelocidadMotorMax = Convert.ToDecimal(DoVelocidadMotorMax.Text);

            if (Range.DoVelocidadMotor)
            {
                string msn = string.Empty;
                if (Range.DoVelocidadMotorMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoVelocidadMotorMin >= Range.DoVelocidadMotorMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoVelocidadMotor)
                             .Replace("{1}", $"{Range.DoVelocidadMotorMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoVelocidadMotorMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoVelocidadMotor = false;
                }
            }

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            Range.DoLongitudCarrera = DoLongitudCarrera.Checked;
            Range.DoLongitudCarreraMin = Convert.ToDecimal(DoLongitudCarreraMin.Text);
            Range.DoLongitudCarreraMax = Convert.ToDecimal(DoLongitudCarreraMax.Text);

            if (Range.DoLongitudCarrera)
            {
                string msn = string.Empty;
                if (Range.DoLongitudCarreraMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoLongitudCarreraMin >= Range.DoLongitudCarreraMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoLongitudCarrera)
                             .Replace("{1}", $"{Range.DoLongitudCarreraMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoLongitudCarreraMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoLongitudCarrera = false;
                }
            }

            #endregion DoLongitudCarrera

            #region DoEficienciaLlenado

            Range.DoEficienciaLlenado = DoEficienciaLlenado.Checked;
            Range.DoEficienciaLlenadoMin = Convert.ToDecimal(DoEficienciaLlenadoMin.Text);
            Range.DoEficienciaLlenadoMax = Convert.ToDecimal(DoEficienciaLlenadoMax.Text);

            if (Range.DoEficienciaLlenado)
            {
                string msn = string.Empty;
                if (Range.DoEficienciaLlenadoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoEficienciaLlenadoMin >= Range.DoEficienciaLlenadoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoEficienciaLlenado)
                             .Replace("{1}", $"{Range.DoEficienciaLlenadoMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoEficienciaLlenadoMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoEficienciaLlenado = false;
                }
            }

            #endregion DoEficienciaLlenado

            #region Temporizador

            Range.DatosOperativos = TimeSpan.FromSeconds(Convert.ToDouble(DatosOperativos.Text));

            #endregion Temporizador

            #endregion DatosOperativos

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

        private void Wrote_KeyPress(object sender, KeyPressEventArgs e) => Condicionantes.Wrote_KeyPress(sender, e);

        private void Wrote_Leave(object sender, EventArgs e) => ((TextBox)sender).Text = Condicionantes.Wrote_Formating(((TextBox)sender).Text);

        private class lista
        {
            public OCartaDinagrafica.CCartaDinagrafica Carta { get; set; }
            public int index { get; set; }
        }

        #region CCartaDinagrafica

        private void CCartaDinagrafica_CheckedChanged(object sender, EventArgs e)
        {
            CCartaDinagraficaList.Enabled = CCartaDinagrafica.Checked;
            CCartaDinagraficaAgregar.Enabled = CCartaDinagrafica.Checked;
            CCartaDinagraficaEliminar.Enabled = CCartaDinagrafica.Checked;
        }

        private void CCartaDinagraficaAgregar_Click(object sender, EventArgs e)
        {
            List<OCartaDinagrafica.CCartaDinagrafica> newLista = SeleccionarArchivo();

            if (newLista.Count > 0)
            {
                newLista.ForEach(val =>
                {
                    if (!ListCCartaDinagrafica.Exists(x => JsonConvert.SerializeObject(x) == JsonConvert.SerializeObject(val)))
                    {
                        ListCCartaDinagrafica.Add(new lista() { Carta = val });
                    }
                });

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
        }

        #region Load carta

        public static List<OCartaDinagrafica.CCartaDinagrafica> LeerJson(string Archivo)
        {
            string datos = File.ReadAllText(Archivo);
            List<OCartaDinagrafica.CCartaDinagrafica> CartaDinagrafica = new();

            if (datos.Contains("SurfaceCardLoad"))
            {
                try
                {
                    CartaDinagrafica = JsonConvert.DeserializeObject<List<OCartaDinagrafica.CCartaDinagrafica>>(datos);
                }
                catch
                {
                    try
                    {
                        OCartaDinagrafica.CCartaDinagrafica Carta2 = JsonConvert.DeserializeObject<OCartaDinagrafica.CCartaDinagrafica>(datos);
                        CartaDinagrafica.Add(Carta2);
                    }
                    catch
                    { }
                }
            }
            else if (datos.Contains("Distancia"))
            {
                List<List<oDinamometrica>> Carta = new();
                try
                {
                    Carta = JsonConvert.DeserializeObject<List<List<oDinamometrica>>>(datos);
                }
                catch
                {
                    try
                    {
                        var Carta1 = JsonConvert.DeserializeObject<List<oDinamometrica>>(datos);
                        Carta.Add(Carta1);
                    }
                    catch
                    { }
                }

                Carta.ForEach(val =>
                {
                    OCartaDinagrafica.CCartaDinagrafica dinagrafica = new();
                    val.ForEach(x =>
                    {
                        dinagrafica.SurfaceCardLoad.Add(x.Fuerza);
                        dinagrafica.SurfaceCardPosition.Add(x.Distancia);
                    });

                    if (!CartaDinagrafica.Exists(x => JsonConvert.SerializeObject(x) == JsonConvert.SerializeObject(dinagrafica)))
                        CartaDinagrafica.Add(dinagrafica);
                });
            }

            for (int i = CartaDinagrafica.Count - 1; i >= 0; i--)
                if (CartaDinagrafica.FindAll(val => JsonConvert.SerializeObject(val) == JsonConvert.SerializeObject(CartaDinagrafica[i])).ToList().Count > 1)
                    CartaDinagrafica.RemoveAt(i);

            return CartaDinagrafica;
        }

        protected static List<OCartaDinagrafica.CCartaDinagrafica> LeerExcel(string Archivo)
        {
            List<List<oDinamometrica>> Carta = new();

            Excel.Application xlApp = new();
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
                        List<oDinamometrica> Dinamometrica1 = new();
                        for (int j = k + 1; j <= rw; j++)
                        {
                            try
                            {
                                decimal val1 = (decimal)(range.Cells[j, Position] as Excel.Range).Value2;
                                decimal val2 = (decimal)(range.Cells[j, Load] as Excel.Range).Value2;

                                oDinamometrica dinamometrica = new()
                                {
                                    Distancia = val1,
                                    Fuerza = val2,
                                };
                                Dinamometrica1.Add(dinamometrica);
                            }
                            catch
                            {
                            }
                        }

                        Carta.Add(Dinamometrica1);
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

            List<OCartaDinagrafica.CCartaDinagrafica> CartaDinagrafica = new();
            Carta.ForEach(val =>
            {
                OCartaDinagrafica.CCartaDinagrafica dinagrafica = new();
                val.ForEach(x =>
                  {
                      dinagrafica.SurfaceCardLoad.Add(x.Fuerza);
                      dinagrafica.SurfaceCardPosition.Add(x.Distancia);
                  });

                if (!CartaDinagrafica.Exists(x => JsonConvert.SerializeObject(x) == JsonConvert.SerializeObject(dinagrafica)))
                    CartaDinagrafica.Add(dinagrafica);
            });
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

        protected List<OCartaDinagrafica.CCartaDinagrafica> SeleccionarArchivo()
        {
            List<OCartaDinagrafica.CCartaDinagrafica> cartas = new();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog file = openFileDialog1;

                // Empezamos a manejar el archivo
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
                        MessageBox.Show(Languages.General.FileError);
                        break;
                }
            }

            return cartas;
        }

        public class oDinamometrica
        {
            public decimal Distancia { get; set; }
            public decimal Fuerza { get; set; }
        }

        #endregion Load carta

        private void CCartaDinagraficaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ListCCartaDinagrafica.RemoveAt(CCartaDinagraficaList.SelectedIndex);

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
            //chart1.Series.Clear();
            //decimal MinX = 0;
            //decimal MaxX = 1;
            //decimal MinY = 0;
            //decimal MaxY = 1;

            //try
            //{
            //    OCartaDinagrafica.CCartaDinagrafica CCartaDinagrafica = ListCCartaDinagrafica[((lista)CCartaDinagraficaList.SelectedItem).index].Carta;
            //    DataTable dt = new DataTable(Languages.Graphics.DinamometricaFondo);
            //    dt.Columns.Add("X", typeof(decimal));
            //    dt.Columns.Add("Y", typeof(decimal));
            //    for (int i = 0; i < CCartaDinagrafica.SurfaceCardPosition.Count; i++)
            //        dt.Rows.Add(CCartaDinagrafica.SurfaceCardPosition[i], CCartaDinagrafica.SurfaceCardLoad[i]);

            //    Series Serie = new Series(dt.TableName, ViewType.ScatterLine)
            //    {
            //        DataSource = dt,
            //        ArgumentDataMember = "X",
            //    };
            //    Serie.ValueDataMembers.AddRange("Y");

            //    chart1.Series.Add(Serie);

            //    MinX = CCartaDinagrafica.SurfaceCardPosition.Min(val => val);
            //    MaxX = CCartaDinagrafica.SurfaceCardPosition.Max(val => val);
            //    MinY = CCartaDinagrafica.SurfaceCardLoad.Min(val => val);
            //    MaxY = CCartaDinagrafica.SurfaceCardLoad.Max(val => val);
            //}
            //catch
            //{
            //}

            //decimal area = (MaxX - MinX) / 2;
            //MinX -= area * 1 / 16;
            //MaxX += area * 1 / 16;

            //area = (MaxY - MinY) / 2;
            //MinY -= area * 1 / 16;
            //MaxY += area * 1 / 16;

            //chart1.Legend.Visibility = DefaultBoolean.False;

            //try
            //{
            //    XYDiagram diagram = (XYDiagram)chart1.Diagram;
            //    diagram.AxisX.WholeRange.SideMarginsValue = 0;
            //    diagram.AxisY.WholeRange.SideMarginsValue = 0;
            //    diagram.AxisX.WholeRange.SetMinMaxValues(MinX, MaxX);
            //    diagram.AxisY.WholeRange.SetMinMaxValues(MinY, MaxY);

            //    // Customize the appearance of the Desplazamiento (ft).
            //    diagram.AxisX.Title.Text = $"{Languages.Graphics.Axis_Desplazamiento} ({Configuracion.GetSigla(Siglas.Longitud_Carta, Referencias.Unidades)})";
            //    diagram.AxisX.Title.Visibility = DefaultBoolean.True;
            //    diagram.AxisX.Title.Alignment = StringAlignment.Center;
            //    diagram.AxisX.Title.EnableAntialiasing = DefaultBoolean.True;

            //    // Customize the appearance of the Carga (klbf).
            //    diagram.AxisY.Title.Text = $"{Languages.Graphics.Axis_Carga} ({Configuracion.GetSigla(Siglas.Fuerza, Referencias.Unidades)})";
            //    diagram.AxisY.Title.Visibility = DefaultBoolean.True;
            //    diagram.AxisY.Title.Alignment = StringAlignment.Center;
            //    diagram.AxisY.Title.EnableAntialiasing = DefaultBoolean.True;
            //}
            //catch
            //{
            //}
        }

        #endregion CCartaDinagrafica

        private void TomaInformacion_Load(object sender, EventArgs e)
        {
        }
    }
}