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

            #region DatosOperativos

            #region presionTuberiaProduccion

            presionTuberiaProduccion.Checked = referencias.Range.presionTuberiaProduccion;
            presionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaProduccionMin.ToString());
            presionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaProduccionMax.ToString());

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            presionTuberiaRevestimiento.Checked = referencias.Range.presionTuberiaRevestimiento;
            presionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaRevestimientoMin.ToString());
            presionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaRevestimientoMax.ToString());

            #endregion presionTuberiaRevestimiento

            #region presionLineaDescarga

            presionLineaDescarga.Checked = referencias.Range.presionLineaDescarga;
            presionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionLineaDescargaMin.ToString());
            presionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionLineaDescargaMax.ToString());

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            temperaturaSuperficie.Checked = referencias.Range.temperaturaSuperficie;
            temperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(referencias.Range.temperaturaSuperficieMin.ToString());
            temperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(referencias.Range.temperaturaSuperficieMax.ToString());

            #endregion temperaturaSuperficie

            #region sumergenciaEfectivaBomba

            sumergenciaEfectivaBomba.Checked = referencias.Range.sumergenciaEfectivaBomba;
            sumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.sumergenciaEfectivaBombaMin.ToString());
            sumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.sumergenciaEfectivaBombaMax.ToString());

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTr

            nivelFluidoPozoTr.Checked = referencias.Range.nivelFluidoPozoTr;
            nivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(referencias.Range.nivelFluidoPozoTrMin.ToString());
            nivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(referencias.Range.nivelFluidoPozoTrMax.ToString());

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            presionEntradaBomba.Checked = referencias.Range.presionEntradaBomba;
            presionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionEntradaBombaMin.ToString());
            presionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionEntradaBombaMax.ToString());

            #endregion presionEntradaBomba

            #region velocidadUnidadBombeo

            velocidadUnidadBombeo.Checked = referencias.Range.velocidadUnidadBombeo;
            velocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadUnidadBombeoMin.ToString());
            velocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadUnidadBombeoMax.ToString());

            #endregion velocidadUnidadBombeo

            #region velocidadMotor

            velocidadMotor.Checked = referencias.Range.velocidadMotor;
            velocidadMotorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadMotorMin.ToString());
            velocidadMotorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadMotorMax.ToString());

            #endregion velocidadMotor

            #region longitudCarrera

            longitudCarrera.Checked = referencias.Range.longitudCarrera;
            longitudCarreraMin.Text = Condicionantes.Wrote_Formating(referencias.Range.longitudCarreraMin.ToString());
            longitudCarreraMax.Text = Condicionantes.Wrote_Formating(referencias.Range.longitudCarreraMax.ToString());

            #endregion longitudCarrera

            #region eficienciaLlenado

            eficienciaLlenado.Checked = referencias.Range.eficienciaLlenado;
            eficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.eficienciaLlenadoMin.ToString());
            eficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.eficienciaLlenadoMax.ToString());

            #endregion eficienciaLlenado

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
        }

        internal void Recargar()
        {
            #region DatosOperativos

            tabPage1.Text = Languages.Pozo.DatosOperativos;

            #region presionTuberiaProduccion

            presionTuberiaProduccion.Text = $"{Languages.Pozo.presionTuberiaProduccion} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            presionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(presionTuberiaProduccionMin.Text);
            presionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(presionTuberiaProduccionMax.Text);

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            presionTuberiaRevestimiento.Text = $"{Languages.Pozo.presionTuberiaRevestimiento} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            presionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(presionTuberiaRevestimientoMin.Text);
            presionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(presionTuberiaRevestimientoMax.Text);

            #endregion presionTuberiaRevestimiento

            #region presionLineaDescarga

            presionLineaDescarga.Text = $"{Languages.Pozo.presionLineaDescarga} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            presionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(presionLineaDescargaMin.Text);
            presionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(presionLineaDescargaMax.Text);

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            temperaturaSuperficie.Text = $"{Languages.Pozo.temperaturaSuperficie} ({Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)})";
            temperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(temperaturaSuperficieMin.Text);
            temperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(temperaturaSuperficieMax.Text);

            #endregion temperaturaSuperficie

            #region sumergenciaEfectivaBomba

            sumergenciaEfectivaBomba.Text = $"{Languages.Pozo.sumergenciaEfectivaBomba} ({Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            sumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(sumergenciaEfectivaBombaMin.Text);
            sumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(sumergenciaEfectivaBombaMax.Text);

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTr

            nivelFluidoPozoTr.Text = $"{Languages.Pozo.nivelFluidoPozoTr} ({Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            nivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(nivelFluidoPozoTrMin.Text);
            nivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(nivelFluidoPozoTrMax.Text);

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            presionEntradaBomba.Text = $"{Languages.Pozo.presionEntradaBomba} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            presionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(presionEntradaBombaMin.Text);
            presionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(presionEntradaBombaMax.Text);

            #endregion presionEntradaBomba

            #region velocidadUnidadBombeo

            velocidadUnidadBombeo.Text = $"{Languages.Pozo.velocidadUnidadBombeo} ({Configuracion.GetSigla(Referencia.Embolada, Referencias.Unidades)})";
            velocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(velocidadUnidadBombeoMin.Text);
            velocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(velocidadUnidadBombeoMax.Text);

            #endregion velocidadUnidadBombeo

            #region velocidadMotor

            velocidadMotor.Text = $"{Languages.Pozo.velocidadMotor} ({Configuracion.GetSigla(Referencia.Velocidad, Referencias.Unidades)})";
            velocidadMotorMin.Text = Condicionantes.Wrote_Formating(velocidadMotorMin.Text);
            velocidadMotorMax.Text = Condicionantes.Wrote_Formating(velocidadMotorMax.Text);

            #endregion velocidadMotor

            #region longitudCarrera

            longitudCarrera.Text = $"{Languages.Pozo.longitudCarrera} ({Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            longitudCarreraMin.Text = Condicionantes.Wrote_Formating(longitudCarreraMin.Text);
            longitudCarreraMax.Text = Condicionantes.Wrote_Formating(longitudCarreraMax.Text);

            #endregion longitudCarrera

            #region eficienciaLlenado

            eficienciaLlenado.Text = $"{Languages.Pozo.eficienciaLlenado} ({Configuracion.GetSigla(Referencia.Porcentaje, Referencias.Unidades)})";
            eficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(eficienciaLlenadoMin.Text);
            eficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(eficienciaLlenadoMax.Text);

            #endregion eficienciaLlenado

            #region Temporizador

            lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosOperativos} ({Siglas.Segundo})";
            DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosOperativos

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

            #region DatosOperativos

            #region presionTuberiaProduccion

            Range.presionTuberiaProduccion = presionTuberiaProduccion.Checked;
            Range.presionTuberiaProduccionMin = Convert.ToDecimal(presionTuberiaProduccionMin.Text);
            Range.presionTuberiaProduccionMax = Convert.ToDecimal(presionTuberiaProduccionMax.Text);

            if (Range.presionTuberiaProduccion)
            {
                string msn = string.Empty;
                if (Range.presionTuberiaProduccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.presionTuberiaProduccionMin >= Range.presionTuberiaProduccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.presionTuberiaProduccion)
                             .Replace("{1}", $"{Range.presionTuberiaProduccionMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.presionTuberiaProduccionMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.presionTuberiaProduccion = false;
                }
            }

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            Range.presionTuberiaRevestimiento = presionTuberiaRevestimiento.Checked;
            Range.presionTuberiaRevestimientoMin = Convert.ToDecimal(presionTuberiaRevestimientoMin.Text);
            Range.presionTuberiaRevestimientoMax = Convert.ToDecimal(presionTuberiaRevestimientoMax.Text);

            if (Range.presionTuberiaRevestimiento)
            {
                string msn = string.Empty;
                if (Range.presionTuberiaRevestimientoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.presionTuberiaRevestimientoMin >= Range.presionTuberiaRevestimientoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.presionTuberiaRevestimiento)
                             .Replace("{1}", $"{Range.presionTuberiaRevestimientoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.presionTuberiaRevestimientoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.presionTuberiaRevestimiento = false;
                }
            }

            #endregion presionTuberiaRevestimiento

            #region presionLineaDescarga

            Range.presionLineaDescarga = presionLineaDescarga.Checked;
            Range.presionLineaDescargaMin = Convert.ToDecimal(presionLineaDescargaMin.Text);
            Range.presionLineaDescargaMax = Convert.ToDecimal(presionLineaDescargaMax.Text);

            if (Range.presionLineaDescarga)
            {
                string msn = string.Empty;
                if (Range.presionLineaDescargaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.presionLineaDescargaMin >= Range.presionLineaDescargaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.presionLineaDescarga)
                             .Replace("{1}", $"{Range.presionLineaDescargaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.presionLineaDescargaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.presionLineaDescarga = false;
                }
            }

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            Range.temperaturaSuperficie = temperaturaSuperficie.Checked;
            Range.temperaturaSuperficieMin = Convert.ToDecimal(temperaturaSuperficieMin.Text);
            Range.temperaturaSuperficieMax = Convert.ToDecimal(temperaturaSuperficieMax.Text);

            if (Range.temperaturaSuperficie)
            {
                string msn = string.Empty;
                if (Range.temperaturaSuperficieMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.temperaturaSuperficieMin >= Range.temperaturaSuperficieMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.temperaturaSuperficie)
                             .Replace("{1}", $"{Range.temperaturaSuperficieMin} {Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.temperaturaSuperficieMax} {Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.temperaturaSuperficie = false;
                }
            }

            #endregion temperaturaSuperficie

            #region sumergenciaEfectivaBomba

            Range.sumergenciaEfectivaBomba = sumergenciaEfectivaBomba.Checked;
            Range.sumergenciaEfectivaBombaMin = Convert.ToDecimal(sumergenciaEfectivaBombaMin.Text);
            Range.sumergenciaEfectivaBombaMax = Convert.ToDecimal(sumergenciaEfectivaBombaMax.Text);

            if (Range.sumergenciaEfectivaBomba)
            {
                string msn = string.Empty;
                if (Range.sumergenciaEfectivaBombaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.sumergenciaEfectivaBombaMin >= Range.sumergenciaEfectivaBombaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.sumergenciaEfectivaBomba)
                             .Replace("{1}", $"{Range.sumergenciaEfectivaBombaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.sumergenciaEfectivaBombaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.sumergenciaEfectivaBomba = false;
                }
            }

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTr

            Range.nivelFluidoPozoTr = nivelFluidoPozoTr.Checked;
            Range.nivelFluidoPozoTrMin = Convert.ToDecimal(nivelFluidoPozoTrMin.Text);
            Range.nivelFluidoPozoTrMax = Convert.ToDecimal(nivelFluidoPozoTrMax.Text);

            if (Range.nivelFluidoPozoTr)
            {
                string msn = string.Empty;
                if (Range.nivelFluidoPozoTrMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.nivelFluidoPozoTrMin >= Range.nivelFluidoPozoTrMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.nivelFluidoPozoTr)
                             .Replace("{1}", $"{Range.nivelFluidoPozoTrMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.nivelFluidoPozoTrMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.nivelFluidoPozoTr = false;
                }
            }

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            Range.presionEntradaBomba = presionEntradaBomba.Checked;
            Range.presionEntradaBombaMin = Convert.ToDecimal(presionEntradaBombaMin.Text);
            Range.presionEntradaBombaMax = Convert.ToDecimal(presionEntradaBombaMax.Text);

            if (Range.presionEntradaBomba)
            {
                string msn = string.Empty;
                if (Range.presionEntradaBombaMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.presionEntradaBombaMin >= Range.presionEntradaBombaMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.presionEntradaBomba)
                             .Replace("{1}", $"{Range.presionEntradaBombaMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.presionEntradaBombaMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.presionEntradaBomba = false;
                }
            }

            #endregion presionEntradaBomba

            #region velocidadUnidadBombeo

            Range.velocidadUnidadBombeo = velocidadUnidadBombeo.Checked;
            Range.velocidadUnidadBombeoMin = Convert.ToDecimal(velocidadUnidadBombeoMin.Text);
            Range.velocidadUnidadBombeoMax = Convert.ToDecimal(velocidadUnidadBombeoMax.Text);

            if (Range.velocidadUnidadBombeo)
            {
                string msn = string.Empty;
                if (Range.velocidadUnidadBombeoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.velocidadUnidadBombeoMin >= Range.velocidadUnidadBombeoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.velocidadUnidadBombeo)
                             .Replace("{1}", $"{Range.velocidadUnidadBombeoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.velocidadUnidadBombeoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.velocidadUnidadBombeo = false;
                }
            }

            #endregion velocidadUnidadBombeo

            #region velocidadMotor

            Range.velocidadMotor = velocidadMotor.Checked;
            Range.velocidadMotorMin = Convert.ToDecimal(velocidadMotorMin.Text);
            Range.velocidadMotorMax = Convert.ToDecimal(velocidadMotorMax.Text);

            if (Range.velocidadMotor)
            {
                string msn = string.Empty;
                if (Range.velocidadMotorMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.velocidadMotorMin >= Range.velocidadMotorMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.velocidadMotor)
                             .Replace("{1}", $"{Range.velocidadMotorMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.velocidadMotorMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.velocidadMotor = false;
                }
            }

            #endregion velocidadMotor

            #region longitudCarrera

            Range.longitudCarrera = longitudCarrera.Checked;
            Range.longitudCarreraMin = Convert.ToDecimal(longitudCarreraMin.Text);
            Range.longitudCarreraMax = Convert.ToDecimal(longitudCarreraMax.Text);

            if (Range.longitudCarrera)
            {
                string msn = string.Empty;
                if (Range.longitudCarreraMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.longitudCarreraMin >= Range.longitudCarreraMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.longitudCarrera)
                             .Replace("{1}", $"{Range.longitudCarreraMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.longitudCarreraMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.longitudCarrera = false;
                }
            }

            #endregion longitudCarrera

            #region eficienciaLlenado

            Range.eficienciaLlenado = eficienciaLlenado.Checked;
            Range.eficienciaLlenadoMin = Convert.ToDecimal(eficienciaLlenadoMin.Text);
            Range.eficienciaLlenadoMax = Convert.ToDecimal(eficienciaLlenadoMax.Text);

            if (Range.eficienciaLlenado)
            {
                string msn = string.Empty;
                if (Range.eficienciaLlenadoMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.eficienciaLlenadoMin >= Range.eficienciaLlenadoMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.eficienciaLlenado)
                             .Replace("{1}", $"{Range.eficienciaLlenadoMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.eficienciaLlenadoMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.eficienciaLlenado = false;
                }
            }

            #endregion eficienciaLlenado

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

                SaveTomaInformacion();
                for (int i = 0; i < ListCCartaDinagrafica.Count; i++)
                    ListCCartaDinagrafica[i].index = i;

                object SelectDdl = CCartaDinagraficaList.SelectedItem;
                CCartaDinagraficaList.DataSource = null;
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
            List<OCartaDinagrafica.CCartaDinagrafica> CartaDinagrafica = new List<OCartaDinagrafica.CCartaDinagrafica>();

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
                List<List<oDinamometrica>> Carta = new List<List<oDinamometrica>>();
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
                    OCartaDinagrafica.CCartaDinagrafica dinagrafica = new OCartaDinagrafica.CCartaDinagrafica();
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
            List<List<oDinamometrica>> Carta = new List<List<oDinamometrica>>();

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
                        List<oDinamometrica> Dinamometrica1 = new List<oDinamometrica>();
                        for (int j = k + 1; j <= rw; j++)
                        {
                            try
                            {
                                decimal val1 = (decimal)(range.Cells[j, Position] as Excel.Range).Value2;
                                decimal val2 = (decimal)(range.Cells[j, Load] as Excel.Range).Value2;

                                oDinamometrica dinamometrica = new oDinamometrica()
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

            List<OCartaDinagrafica.CCartaDinagrafica> CartaDinagrafica = new List<OCartaDinagrafica.CCartaDinagrafica>();
            Carta.ForEach(val =>
            {
                OCartaDinagrafica.CCartaDinagrafica dinagrafica = new OCartaDinagrafica.CCartaDinagrafica();
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
            List<OCartaDinagrafica.CCartaDinagrafica> cartas = new List<OCartaDinagrafica.CCartaDinagrafica>();

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

                SaveTomaInformacion();

                for (int i = 0; i < ListCCartaDinagrafica.Count; i++)
                    ListCCartaDinagrafica[i].index = i;

                object SelectDdl = CCartaDinagraficaList.SelectedItem;
                CCartaDinagraficaList.DataSource = null;
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
            chart1.Series.Clear();
            decimal MinX = 0;
            decimal MaxX = 0;
            decimal MinY = 0;
            decimal MaxY = 0;

            try
            {
                OCartaDinagrafica.CCartaDinagrafica CCartaDinagrafica = ListCCartaDinagrafica[((lista)CCartaDinagraficaList.SelectedItem).index].Carta;
                DataTable dt = new DataTable(Languages.Graphics.DinamometricaFondo);
                dt.Columns.Add("X", typeof(decimal));
                dt.Columns.Add("Y", typeof(decimal));
                for (int i = 0; i < CCartaDinagrafica.SurfaceCardPosition.Count; i++)
                    dt.Rows.Add(CCartaDinagrafica.SurfaceCardPosition[i], CCartaDinagrafica.SurfaceCardLoad[i]);
                dt.Rows.Add(CCartaDinagrafica.SurfaceCardPosition[0], CCartaDinagrafica.SurfaceCardLoad[0]);

                Series Serie = new Series(dt.TableName, ViewType.ScatterLine)
                {
                    DataSource = dt,
                    ArgumentDataMember = "X",
                };
                Serie.ValueDataMembers.AddRange("Y");

                chart1.Series.Add(Serie);

                MinX = CCartaDinagrafica.SurfaceCardPosition.Min(val => val);
                MaxX = CCartaDinagrafica.SurfaceCardPosition.Max(val => val);
                MinY = CCartaDinagrafica.SurfaceCardLoad.Min(val => val);
                MaxY = CCartaDinagrafica.SurfaceCardLoad.Max(val => val);
            }
            catch
            {
            }

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

            try
            {
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
            catch
            {
            }
        }

        #endregion CCartaDinagrafica

        private void TomaInformacion_Load(object sender, EventArgs e) => Recargar();
    }
}
