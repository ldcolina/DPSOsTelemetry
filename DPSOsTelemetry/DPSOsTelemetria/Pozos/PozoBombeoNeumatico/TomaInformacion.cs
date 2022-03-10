using Telemetria;

namespace DPSOsTelemetria.Pozos.PozoBombeoNeumatico
{
    public partial class TomaInformacion : ScrollableControl
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

            #region DoPresionDisponible

            DoPresionDisponible.Checked = referencias.Range.DoPresionDisponible;
            DoPresionDisponibleMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionDisponibleMin.ToString());
            DoPresionDisponibleMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionDisponibleMax.ToString());

            #endregion DoPresionDisponible

            #region DoGastoGasInyeccion

            DoGastoGasInyeccion.Checked = referencias.Range.DoGastoGasInyeccion;
            DoGastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGastoGasInyeccionMin.ToString());
            DoGastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGastoGasInyeccionMax.ToString());

            #endregion DoGastoGasInyeccion

            #region DoGravedadEspecificaGasInyeccion

            DoGravedadEspecificaGasInyeccion.Checked = referencias.Range.DoGravedadEspecificaGasInyeccion;
            DoGravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGravedadEspecificaGasInyeccionMin.ToString());
            DoGravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGravedadEspecificaGasInyeccionMax.ToString());

            #endregion DoGravedadEspecificaGasInyeccion

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

            Recargar();
        }

        internal TomaBasica SaveTomaInformacion()
        {
            TomaBasica Range = new TomaBasica();

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

            #region DoPresionDisponible

            Range.DoPresionDisponible = DoPresionDisponible.Checked;
            Range.DoPresionDisponibleMin = Convert.ToDecimal(DoPresionDisponibleMin.Text);
            Range.DoPresionDisponibleMax = Convert.ToDecimal(DoPresionDisponibleMax.Text);

            if (Range.DoPresionDisponible)
            {
                string msn = string.Empty;
                if (Range.DoPresionDisponibleMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoPresionDisponibleMin >= Range.DoPresionDisponibleMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoPresionDisponible)
                             .Replace("{1}", $"{Range.DoPresionDisponibleMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoPresionDisponibleMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoPresionDisponible = false;
                }
            }

            #endregion DoPresionDisponible

            #region DoGastoGasInyeccion

            Range.DoGastoGasInyeccion = DoGastoGasInyeccion.Checked;
            Range.DoGastoGasInyeccionMin = Convert.ToDecimal(DoGastoGasInyeccionMin.Text);
            Range.DoGastoGasInyeccionMax = Convert.ToDecimal(DoGastoGasInyeccionMax.Text);

            if (Range.DoGastoGasInyeccion)
            {
                string msn = string.Empty;
                if (Range.DoGastoGasInyeccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoGastoGasInyeccionMin >= Range.DoGastoGasInyeccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoGastoGasInyeccion)
                             .Replace("{1}", $"{Range.DoGastoGasInyeccionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoGastoGasInyeccionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoGastoGasInyeccion = false;
                }
            }

            #endregion DoGastoGasInyeccion

            #region DoGravedadEspecificaGasInyeccion

            Range.DoGravedadEspecificaGasInyeccion = DoGravedadEspecificaGasInyeccion.Checked;
            Range.DoGravedadEspecificaGasInyeccionMin = Convert.ToDecimal(DoGravedadEspecificaGasInyeccionMin.Text);
            Range.DoGravedadEspecificaGasInyeccionMax = Convert.ToDecimal(DoGravedadEspecificaGasInyeccionMax.Text);

            if (Range.DoGravedadEspecificaGasInyeccion)
            {
                string msn = string.Empty;
                if (Range.DoGravedadEspecificaGasInyeccionMin < 0)
                {
                    msn = Languages.Pozo.GreaterThan;
                }
                if (Range.DoGravedadEspecificaGasInyeccionMin >= Range.DoGravedadEspecificaGasInyeccionMax)
                {
                    msn = Languages.Pozo.GreaterThanValue;
                }

                if (!string.IsNullOrEmpty(msn))
                {
                    msn = msn.Replace("{0}", Languages.Pozo.DoGravedadEspecificaGasInyeccion)
                             .Replace("{1}", $"{Range.DoGravedadEspecificaGasInyeccionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
                             .Replace("{2}", $"{Range.DoGravedadEspecificaGasInyeccionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
                    MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
                    Range.DoGravedadEspecificaGasInyeccion = false;
                }
            }

            #endregion DoGravedadEspecificaGasInyeccion

            #region Temporizador

            Range.DatosOperativos = TimeSpan.FromSeconds(Convert.ToDouble(DatosOperativos.Text));

            #endregion Temporizador

            #endregion DatosOperativos

            return Range;
        }

        internal void Recargar()
        {
            #region DatosOperativos

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

            #region DoPresionDisponible

            DoPresionDisponible.Text = $"{Languages.Pozo.DoPresionDisponible} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            DoPresionDisponibleMin.Text = Condicionantes.Wrote_Formating(DoPresionDisponibleMin.Text);
            DoPresionDisponibleMax.Text = Condicionantes.Wrote_Formating(DoPresionDisponibleMax.Text);

            #endregion DoPresionDisponible

            #region DoGastoGasInyeccion

            DoGastoGasInyeccion.Text = $"{Languages.Pozo.DoGastoGasInyeccion} ({ Configuracion.GetSigla(Siglas.GastoGas, Referencias.Unidades)})";
            DoGastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(DoGastoGasInyeccionMin.Text);
            DoGastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(DoGastoGasInyeccionMax.Text);

            #endregion DoGastoGasInyeccion

            #region DoGravedadEspecificaGasInyeccion

            DoGravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.DoGravedadEspecificaGasInyeccion} (-)";
            DoGravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(DoGravedadEspecificaGasInyeccionMin.Text);
            DoGravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(DoGravedadEspecificaGasInyeccionMax.Text);

            #endregion DoGravedadEspecificaGasInyeccion

            #region Temporizador

            lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosOperativos} ({Languages.Siglas.Segundo})";
            DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosOperativos
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
    }
}