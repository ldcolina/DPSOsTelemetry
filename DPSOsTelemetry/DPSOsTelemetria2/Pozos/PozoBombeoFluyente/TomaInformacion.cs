using Languages;
using System;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2.Pozos.PozoBombeoFluyente
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

            #region presionDisponible

            presionDisponible.Checked = referencias.Range.presionDisponible;
            presionDisponibleMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionDisponibleMin.ToString());
            presionDisponibleMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionDisponibleMax.ToString());

            #endregion presionDisponible

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

            #region presionDisponible

            presionDisponible.Text = $"{Languages.Pozo.presionDisponible} ({Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            presionDisponibleMin.Text = Condicionantes.Wrote_Formating(presionDisponibleMin.Text);
            presionDisponibleMax.Text = Condicionantes.Wrote_Formating(presionDisponibleMax.Text);

            #endregion presionDisponible

            #region Temporizador

            lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosOperativos} ({Siglas.Segundo})";
            DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosOperativos
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

            #region presionDisponible

            Range.presionDisponible = presionDisponible.Checked;
            Range.presionDisponibleMin = Convert.ToDecimal(presionDisponibleMin.Text);
            Range.presionDisponibleMax = Convert.ToDecimal(presionDisponibleMax.Text);

            if (Range.presionDisponible)
            {
                string msn = string.Empty;
                if (Range.presionDisponibleMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.presionDisponibleMin >= Range.presionDisponibleMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.presionDisponible)
                             .Replace("{1}", $"{Range.presionDisponibleMin} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.presionDisponibleMax} {Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.presionDisponible = false;
                }
            }

            #endregion presionDisponible

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
