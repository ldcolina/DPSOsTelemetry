using Languages;
using System;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Pozos.PozoBombeoNeumatico
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

            #region PresionDisponible

            PresionDisponible.Checked = referencias.Range.PresionDisponible;
            PresionDisponibleMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionDisponibleMin.ToString());
            PresionDisponibleMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionDisponibleMax.ToString());

            #endregion PresionDisponible

            #region gastoGasInyeccion

            gastoGasInyeccion.Checked = referencias.Range.GastoGasInyeccion;
            gastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoGasInyeccionMin.ToString());
            gastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoGasInyeccionMax.ToString());

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            gravedadEspecificaGasInyeccion.Checked = referencias.Range.GravedadEspecificaGasInyeccion;
            gravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaGasInyeccionMin.ToString());
            gravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaGasInyeccionMax.ToString());

            #endregion gravedadEspecificaGasInyeccion

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
        }

        internal void Recargar()
        {
            #region DatosOperativos

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

            #region PresionDisponible

            PresionDisponible.Text = $"{Languages.Pozo.PresionDisponible} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            PresionDisponibleMin.Text = Condicionantes.Wrote_Formating(PresionDisponibleMin.Text);
            PresionDisponibleMax.Text = Condicionantes.Wrote_Formating(PresionDisponibleMax.Text);

            #endregion PresionDisponible

            #region gastoGasInyeccion

            gastoGasInyeccion.Text = $"{Languages.Pozo.GastoGasInyeccion} ({Configuracion.GetSigla(Referencia.GastoGas, Referencias.Unidades)})";
            gastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(gastoGasInyeccionMin.Text);
            gastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(gastoGasInyeccionMax.Text);

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            gravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.GravedadEspecificaGasInyeccion} (-)";
            gravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(gravedadEspecificaGasInyeccionMin.Text);
            gravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(gravedadEspecificaGasInyeccionMax.Text);

            #endregion gravedadEspecificaGasInyeccion

            #region Temporizador

            lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.OperativeData} ({Siglas.Segundo})";
            DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosOperativos
        }

        internal TomaBasica SaveTomaInformacion()
        {
            TomaBasica Range = new TomaBasica();

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

            #region PresionDisponible

            Range.PresionDisponible = PresionDisponible.Checked;
            Range.PresionDisponibleMin = Convert.ToDecimal(PresionDisponibleMin.Text);
            Range.PresionDisponibleMax = Convert.ToDecimal(PresionDisponibleMax.Text);

            if (Range.PresionDisponible)
            {
                string msn = string.Empty;
                if (Range.PresionDisponibleMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.PresionDisponibleMin >= Range.PresionDisponibleMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.PresionDisponible)
                             .Replace("{1}", $"{Range.PresionDisponibleMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.PresionDisponibleMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.PresionDisponible = false;
                }
            }

            #endregion PresionDisponible

            #region gastoGasInyeccion

            Range.GastoGasInyeccion = gastoGasInyeccion.Checked;
            Range.GastoGasInyeccionMin = Convert.ToDecimal(gastoGasInyeccionMin.Text);
            Range.GastoGasInyeccionMax = Convert.ToDecimal(gastoGasInyeccionMax.Text);

            if (Range.GastoGasInyeccion)
            {
                string msn = string.Empty;
                if (Range.GastoGasInyeccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GastoGasInyeccionMin >= Range.GastoGasInyeccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GastoGasInyeccion)
                             .Replace("{1}", $"{Range.GastoGasInyeccionMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GastoGasInyeccionMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GastoGasInyeccion = false;
                }
            }

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            Range.GravedadEspecificaGasInyeccion = gravedadEspecificaGasInyeccion.Checked;
            Range.GravedadEspecificaGasInyeccionMin = Convert.ToDecimal(gravedadEspecificaGasInyeccionMin.Text);
            Range.GravedadEspecificaGasInyeccionMax = Convert.ToDecimal(gravedadEspecificaGasInyeccionMax.Text);

            if (Range.GravedadEspecificaGasInyeccion)
            {
                string msn = string.Empty;
                if (Range.GravedadEspecificaGasInyeccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.GravedadEspecificaGasInyeccionMin >= Range.GravedadEspecificaGasInyeccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.GravedadEspecificaGasInyeccion)
                             .Replace("{1}", $"{Range.GravedadEspecificaGasInyeccionMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.GravedadEspecificaGasInyeccionMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.GravedadEspecificaGasInyeccion = false;
                }
            }

            #endregion gravedadEspecificaGasInyeccion

            #region Temporizador

            Range.DatosOperativos = TimeSpan.FromSeconds(Convert.ToDouble(DatosOperativos.Text));

            #endregion Temporizador

            #endregion DatosOperativos

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

        private void TomaInformacion_Load(object sender, EventArgs e) => Recargar();
    }
}
