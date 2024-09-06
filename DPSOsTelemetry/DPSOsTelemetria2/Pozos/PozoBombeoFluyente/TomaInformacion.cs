using Languages;
using System;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria.Pozos.PozoBombeoFluyente
{
    public partial class TomaInformacion : UserControl
    {
        private readonly ReferenciasII Referencias;

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

            foreach (object item in tlpVariables.Controls)
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

            foreach (object item in tlpVariables2.Controls)
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
        }

        internal void Recargar()
        {
            #region DatosManual

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

            #endregion DatosOperativos

            #region Temporizador

            lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosManual} ({Siglas.Segundo})";
            DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosManual
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

            #endregion DatosProduccion

            #region Temporizador

            Range.DatosOperativos = TimeSpan.FromSeconds(Convert.ToDouble(DatosOperativos.Text));

            #endregion Temporizador

            #endregion DatosManual

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

        private void TomaInformacion_Load(object sender, EventArgs e) => Recargar();
    }
}