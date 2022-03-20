using Telemetria;
using System.Windows.Forms;

using System;
using System.Linq;

namespace DPSOsTelemetria2.Pozos.PozoBombeoNeumaticoIntermitente
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

            #region DoPresionTuberiaProduccion

            //DoPresionTuberiaProduccion.Checked = referencias.Range.DoPresionTuberiaProduccion;
            //DoPresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaProduccionMin.ToString());
            //DoPresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaProduccionMax.ToString());

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            //DoPresionTuberiaRevestimiento.Checked = referencias.Range.DoPresionTuberiaRevestimiento;
            //DoPresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaRevestimientoMin.ToString());
            //DoPresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionTuberiaRevestimientoMax.ToString());

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionAperturaCampo

            //DoPresionAperturaCampo.Checked = referencias.Range.DoPresionAperturaCampo;
            //DoPresionAperturaCampoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionAperturaCampoMin.ToString());
            //DoPresionAperturaCampoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionAperturaCampoMax.ToString());

            #endregion DoPresionAperturaCampo

            #region DoPresionLineaDescarga

            //DoPresionLineaDescarga.Checked = referencias.Range.DoPresionLineaDescarga;
            //DoPresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionLineaDescargaMin.ToString());
            //DoPresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionLineaDescargaMax.ToString());

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            //DoTemperaturaSuperficie.Checked = referencias.Range.DoTemperaturaSuperficie;
            //DoTemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTemperaturaSuperficieMin.ToString());
            //DoTemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTemperaturaSuperficieMax.ToString());

            #endregion DoTemperaturaSuperficie

            #region DoSumergenciaEfectivaBomba

            //DoSumergenciaEfectivaBomba.Checked = referencias.Range.DoSumergenciaEfectivaBomba;
            //DoSumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoSumergenciaEfectivaBombaMin.ToString());
            //DoSumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoSumergenciaEfectivaBombaMax.ToString());

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTp

            //DoNivelFluidoPozoTp.Checked = referencias.Range.DoNivelFluidoPozoTp;
            //DoNivelFluidoPozoTpMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoNivelFluidoPozoTpMin.ToString());
            //DoNivelFluidoPozoTpMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoNivelFluidoPozoTpMax.ToString());

            #endregion DoNivelFluidoPozoTp

            #region DoNivelFluidoPozoTr

            //DoNivelFluidoPozoTr.Checked = referencias.Range.DoNivelFluidoPozoTr;
            //DoNivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoNivelFluidoPozoTrMin.ToString());
            //DoNivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoNivelFluidoPozoTrMax.ToString());

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            //DoPresionEntradaBomba.Checked = referencias.Range.DoPresionEntradaBomba;
            //DoPresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionEntradaBombaMin.ToString());
            //DoPresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionEntradaBombaMax.ToString());

            #endregion DoPresionEntradaBomba

            #region DoVelocidadBomba

            //DoVelocidadBomba.Checked = referencias.Range.DoVelocidadBomba;
            //DoVelocidadBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadBombaMin.ToString());
            //DoVelocidadBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadBombaMax.ToString());

            #endregion DoVelocidadBomba

            #region DoVelocidadUnidadBombeo

            //DoVelocidadUnidadBombeo.Checked = referencias.Range.DoVelocidadUnidadBombeo;
            //DoVelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadUnidadBombeoMin.ToString());
            //DoVelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadUnidadBombeoMax.ToString());

            #endregion DoVelocidadUnidadBombeo

            #region DoFrecuenciaOperacionBomba

            //DoFrecuenciaOperacionBomba.Checked = referencias.Range.DoFrecuenciaOperacionBomba;
            //DoFrecuenciaOperacionBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoFrecuenciaOperacionBombaMin.ToString());
            //DoFrecuenciaOperacionBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoFrecuenciaOperacionBombaMax.ToString());

            #endregion DoFrecuenciaOperacionBomba

            #region DoVelocidadMotor

            //DoVelocidadMotor.Checked = referencias.Range.DoVelocidadMotor;
            //DoVelocidadMotorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadMotorMin.ToString());
            //DoVelocidadMotorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoVelocidadMotorMax.ToString());

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            //DoLongitudCarrera.Checked = referencias.Range.DoLongitudCarrera;
            //DoLongitudCarreraMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoLongitudCarreraMin.ToString());
            //DoLongitudCarreraMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoLongitudCarreraMax.ToString());

            #endregion DoLongitudCarrera

            #region DoPresionDisponible

            //DoPresionDisponible.Checked = referencias.Range.DoPresionDisponible;
            //DoPresionDisponibleMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionDisponibleMin.ToString());
            //DoPresionDisponibleMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoPresionDisponibleMax.ToString());

            #endregion DoPresionDisponible

            #region DoGastoInyeccionFluidoPotencia

            //DoGastoInyeccionFluidoPotencia.Checked = referencias.Range.DoGastoInyeccionFluidoPotencia;
            //DoGastoInyeccionFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGastoInyeccionFluidoPotenciaMin.ToString());
            //DoGastoInyeccionFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGastoInyeccionFluidoPotenciaMax.ToString());

            #endregion DoGastoInyeccionFluidoPotencia

            #region DoGravedadEspecificaFluidoPotencia

            //DoGravedadEspecificaFluidoPotencia.Checked = referencias.Range.DoGravedadEspecificaFluidoPotencia;
            //DoGravedadEspecificaFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGravedadEspecificaFluidoPotenciaMin.ToString());
            //DoGravedadEspecificaFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGravedadEspecificaFluidoPotenciaMax.ToString());

            #endregion DoGravedadEspecificaFluidoPotencia

            #region DoGastoGasInyeccion

            //DoGastoGasInyeccion.Checked = referencias.Range.DoGastoGasInyeccion;
            //DoGastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGastoGasInyeccionMin.ToString());
            //DoGastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGastoGasInyeccionMax.ToString());

            #endregion DoGastoGasInyeccion

            #region DoGravedadEspecificaGasInyeccion

            //DoGravedadEspecificaGasInyeccion.Checked = referencias.Range.DoGravedadEspecificaGasInyeccion;
            //DoGravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGravedadEspecificaGasInyeccionMin.ToString());
            //DoGravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoGravedadEspecificaGasInyeccionMax.ToString());

            #endregion DoGravedadEspecificaGasInyeccion

            #region DoTorque

            //DoTorque.Checked = referencias.Range.DoTorque;
            //DoTorqueMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTorqueMin.ToString());
            //DoTorqueMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTorqueMax.ToString());

            #endregion DoTorque

            #region DoCorriente

            //DoCorriente.Checked = referencias.Range.DoCorriente;
            //DoCorrienteMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoCorrienteMin.ToString());
            //DoCorrienteMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoCorrienteMax.ToString());

            #endregion DoCorriente

            #region DoDiametroEstrangulador

            //DoDiametroEstrangulador.Checked = referencias.Range.DoDiametroEstrangulador;
            //DoDiametroEstranguladorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoDiametroEstranguladorMin.ToString());
            //DoDiametroEstranguladorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoDiametroEstranguladorMax.ToString());

            #endregion DoDiametroEstrangulador

            #region DoTiempoCiclo

            //DoTiempoCiclo.Checked = referencias.Range.DoTiempoCiclo;
            //DoTiempoCicloMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoCicloMin.ToString());
            //DoTiempoCicloMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoCicloMax.ToString());

            #endregion DoTiempoCiclo

            #region DoTiempoRecuperacion

            //DoTiempoRecuperacion.Checked = referencias.Range.DoTiempoRecuperacion;
            //DoTiempoRecuperacionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoRecuperacionMin.ToString());
            //DoTiempoRecuperacionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoRecuperacionMax.ToString());

            #endregion DoTiempoRecuperacion

            #region DoTiempoInyeccion

            //DoTiempoInyeccion.Checked = referencias.Range.DoTiempoInyeccion;
            //DoTiempoInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoInyeccionMin.ToString());
            //DoTiempoInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoInyeccionMax.ToString());

            #endregion DoTiempoInyeccion

            #region DoTiempoDesplazamientoTapon

            //DoTiempoDesplazamientoTapon.Checked = referencias.Range.DoTiempoDesplazamientoTapon;
            //DoTiempoDesplazamientoTaponMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoDesplazamientoTaponMin.ToString());
            //DoTiempoDesplazamientoTaponMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoTiempoDesplazamientoTaponMax.ToString());

            #endregion DoTiempoDesplazamientoTapon

            #region DoEficienciaLlenado

            //DoEficienciaLlenado.Checked = referencias.Range.DoEficienciaLlenado;
            //DoEficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DoEficienciaLlenadoMin.ToString());
            //DoEficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DoEficienciaLlenadoMax.ToString());

            #endregion DoEficienciaLlenado

            #region Temporizador

            //DatosOperativos.Text = Condicionantes.Wrote_Formating(referencias.Range.DatosOperativos.TotalSeconds.ToString());
            //DatosOperativos.Leave += Wrote_Leave;
            //DatosOperativos.KeyPress += Wrote_KeyPress;

            #endregion Temporizador

            #endregion DatosOperativos

            #region CCartaDinagrafica

            //CCartaDinagrafica = CCartaDinagrafica.Check;
            //List<OCartaDinagrafica.CCartaDinagrafica> ListCCartaDinagrafica = new List<OCartaDinagrafica.CCartaDinagrafica>();

            #region Temporizador

            //CartaDinagrafica.Text = Condicionantes.Wrote_Formating(referencias.Range.CartaDinagrafica.TotalSeconds.ToString());
            //CartaDinagrafica.Leave += Wrote_Leave;
            //CartaDinagrafica.KeyPress += Wrote_KeyPress;

            #endregion Temporizador

            #endregion CCartaDinagrafica

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

            Recargar();
        }

        internal void Recargar()
        {
            #region DatosOperativos

            #region DoPresionTuberiaProduccion

            //DoPresionTuberiaProduccion.Text = $"{Languages.Pozo.DoPresionTuberiaProduccion} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            //DoPresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaProduccionMin.Text);
            //DoPresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaProduccionMax.Text);

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            //DoPresionTuberiaRevestimiento.Text = $"{Languages.Pozo.DoPresionTuberiaRevestimiento} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            //DoPresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaRevestimientoMin.Text);
            //DoPresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(DoPresionTuberiaRevestimientoMax.Text);

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionAperturaCampo

            //DoPresionAperturaCampo.Text = $"{Languages.Pozo.DoPresionAperturaCampo} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            //DoPresionAperturaCampoMin.Text = Condicionantes.Wrote_Formating(DoPresionAperturaCampoMin.Text);
            //DoPresionAperturaCampoMax.Text = Condicionantes.Wrote_Formating(DoPresionAperturaCampoMax.Text);

            #endregion DoPresionAperturaCampo

            #region DoPresionLineaDescarga

            //DoPresionLineaDescarga.Text = $"{Languages.Pozo.DoPresionLineaDescarga} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            //DoPresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(DoPresionLineaDescargaMin.Text);
            //DoPresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(DoPresionLineaDescargaMax.Text);

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            //DoTemperaturaSuperficie.Text = $"{Languages.Pozo.DoTemperaturaSuperficie} ({ Configuracion.GetSigla(Siglas.Temperatura, Referencias.Unidades)})";
            //DoTemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(DoTemperaturaSuperficieMin.Text);
            //DoTemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(DoTemperaturaSuperficieMax.Text);

            #endregion DoTemperaturaSuperficie

            #region DoSumergenciaEfectivaBomba

            //DoSumergenciaEfectivaBomba.Text = $"{Languages.Pozo.DoSumergenciaEfectivaBomba} ({ Configuracion.GetSigla(Siglas.Distancia, Referencias.Unidades)})";
            //DoSumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(DoSumergenciaEfectivaBombaMin.Text);
            //DoSumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(DoSumergenciaEfectivaBombaMax.Text);

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTp

            //DoNivelFluidoPozoTp.Text = $"{Languages.Pozo.DoNivelFluidoPozoTp} ({ Configuracion.GetSigla(Siglas.Distancia, Referencias.Unidades)})";
            //DoNivelFluidoPozoTpMin.Text = Condicionantes.Wrote_Formating(DoNivelFluidoPozoTpMin.Text);
            //DoNivelFluidoPozoTpMax.Text = Condicionantes.Wrote_Formating(DoNivelFluidoPozoTpMax.Text);

            #endregion DoNivelFluidoPozoTp

            #region DoNivelFluidoPozoTr

            //DoNivelFluidoPozoTr.Text = $"{Languages.Pozo.DoNivelFluidoPozoTr} ({ Configuracion.GetSigla(Siglas.Distancia, Referencias.Unidades)})";
            //DoNivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(DoNivelFluidoPozoTrMin.Text);
            //DoNivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(DoNivelFluidoPozoTrMax.Text);

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            //DoPresionEntradaBomba.Text = $"{Languages.Pozo.DoPresionEntradaBomba} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            //DoPresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(DoPresionEntradaBombaMin.Text);
            //DoPresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(DoPresionEntradaBombaMax.Text);

            #endregion DoPresionEntradaBomba

            #region DoVelocidadBomba

            //DoVelocidadBomba.Text = $"{Languages.Pozo.DoVelocidadBomba} ({ Configuracion.GetSigla(Siglas.Velocidad, Referencias.Unidades)})";
            //DoVelocidadBombaMin.Text = Condicionantes.Wrote_Formating(DoVelocidadBombaMin.Text);
            //DoVelocidadBombaMax.Text = Condicionantes.Wrote_Formating(DoVelocidadBombaMax.Text);

            #endregion DoVelocidadBomba

            #region DoVelocidadUnidadBombeo

            //DoVelocidadUnidadBombeo.Text = $"{Languages.Pozo.DoVelocidadUnidadBombeo} ({ Configuracion.GetSigla(Siglas.Embolada, Referencias.Unidades)})";
            //DoVelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(DoVelocidadUnidadBombeoMin.Text);
            //DoVelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(DoVelocidadUnidadBombeoMax.Text);

            #endregion DoVelocidadUnidadBombeo

            #region DoFrecuenciaOperacionBomba

            //DoFrecuenciaOperacionBomba.Text = $"{Languages.Pozo.DoFrecuenciaOperacionBomba} ({ Configuracion.GetSigla(Siglas.Frecuencia, Referencias.Unidades)})";
            //DoFrecuenciaOperacionBombaMin.Text = Condicionantes.Wrote_Formating(DoFrecuenciaOperacionBombaMin.Text);
            //DoFrecuenciaOperacionBombaMax.Text = Condicionantes.Wrote_Formating(DoFrecuenciaOperacionBombaMax.Text);

            #endregion DoFrecuenciaOperacionBomba

            #region DoVelocidadMotor

            //DoVelocidadMotor.Text = $"{Languages.Pozo.DoVelocidadMotor} ({ Configuracion.GetSigla(Siglas.Velocidad, Referencias.Unidades)})";
            //DoVelocidadMotorMin.Text = Condicionantes.Wrote_Formating(DoVelocidadMotorMin.Text);
            //DoVelocidadMotorMax.Text = Condicionantes.Wrote_Formating(DoVelocidadMotorMax.Text);

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            //DoLongitudCarrera.Text = $"{Languages.Pozo.DoLongitudCarrera} ({ Configuracion.GetSigla(Siglas.Distancia, Referencias.Unidades)})";
            //DoLongitudCarreraMin.Text = Condicionantes.Wrote_Formating(DoLongitudCarreraMin.Text);
            //DoLongitudCarreraMax.Text = Condicionantes.Wrote_Formating(DoLongitudCarreraMax.Text);

            #endregion DoLongitudCarrera

            #region DoPresionDisponible

            //DoPresionDisponible.Text = $"{Languages.Pozo.DoPresionDisponible} ({ Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)})";
            //DoPresionDisponibleMin.Text = Condicionantes.Wrote_Formating(DoPresionDisponibleMin.Text);
            //DoPresionDisponibleMax.Text = Condicionantes.Wrote_Formating(DoPresionDisponibleMax.Text);

            #endregion DoPresionDisponible

            #region DoGastoInyeccionFluidoPotencia

            //DoGastoInyeccionFluidoPotencia.Text = $"{Languages.Pozo.DoGastoInyeccionFluidoPotencia} ({ Configuracion.GetSigla(Siglas.GastoGas, Referencias.Unidades)})";
            //DoGastoInyeccionFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(DoGastoInyeccionFluidoPotenciaMin.Text);
            //DoGastoInyeccionFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(DoGastoInyeccionFluidoPotenciaMax.Text);

            #endregion DoGastoInyeccionFluidoPotencia

            #region DoGravedadEspecificaFluidoPotencia

            //DoGravedadEspecificaFluidoPotencia.Text = $"{Languages.Pozo.DoGravedadEspecificaFluidoPotencia} (-)";
            //DoGravedadEspecificaFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(DoGravedadEspecificaFluidoPotenciaMin.Text);
            //DoGravedadEspecificaFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(DoGravedadEspecificaFluidoPotenciaMax.Text);

            #endregion DoGravedadEspecificaFluidoPotencia

            #region DoGastoGasInyeccion

            //DoGastoGasInyeccion.Text = $"{Languages.Pozo.DoGastoGasInyeccion} ({ Configuracion.GetSigla(Siglas.GastoGas, Referencias.Unidades)})";
            //DoGastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(DoGastoGasInyeccionMin.Text);
            //DoGastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(DoGastoGasInyeccionMax.Text);

            #endregion DoGastoGasInyeccion

            #region DoGravedadEspecificaGasInyeccion

            //DoGravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.DoGravedadEspecificaGasInyeccion} (-)";
            //DoGravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(DoGravedadEspecificaGasInyeccionMin.Text);
            //DoGravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(DoGravedadEspecificaGasInyeccionMax.Text);

            #endregion DoGravedadEspecificaGasInyeccion

            #region DoTorque

            //DoTorque.Text = $"{Languages.Pozo.DoTorque} ({ Configuracion.GetSigla(Siglas.Torque, Referencias.Unidades)})";
            //DoTorqueMin.Text = Condicionantes.Wrote_Formating(DoTorqueMin.Text);
            //DoTorqueMax.Text = Condicionantes.Wrote_Formating(DoTorqueMax.Text);

            #endregion DoTorque

            #region DoCorriente

            //DoCorriente.Text = $"{Languages.Pozo.DoCorriente} ({ Configuracion.GetSigla(Siglas.Corriente, Referencias.Unidades)})";
            //DoCorrienteMin.Text = Condicionantes.Wrote_Formating(DoCorrienteMin.Text);
            //DoCorrienteMax.Text = Condicionantes.Wrote_Formating(DoCorrienteMax.Text);

            #endregion DoCorriente

            #region DoDiametroEstrangulador

            //DoDiametroEstrangulador.Text = $"{Languages.Pozo.DoDiametroEstrangulador} ({ Configuracion.GetSigla(Siglas.Diametro, Referencias.Unidades)})";
            //DoDiametroEstranguladorMin.Text = Condicionantes.Wrote_Formating(DoDiametroEstranguladorMin.Text);
            //DoDiametroEstranguladorMax.Text = Condicionantes.Wrote_Formating(DoDiametroEstranguladorMax.Text);

            #endregion DoDiametroEstrangulador

            #region DoTiempoCiclo

            //DoTiempoCiclo.Text = $"{Languages.Pozo.DoTiempoCiclo} ({ Configuracion.GetSigla(Siglas.Segundo, Referencias.Unidades)})";
            //DoTiempoCicloMin.Text = Condicionantes.Wrote_Formating(DoTiempoCicloMin.Text);
            //DoTiempoCicloMax.Text = Condicionantes.Wrote_Formating(DoTiempoCicloMax.Text);

            #endregion DoTiempoCiclo

            #region DoTiempoRecuperacion

            //DoTiempoRecuperacion.Text = $"{Languages.Pozo.DoTiempoRecuperacion} ({ Configuracion.GetSigla(Siglas.Segundo, Referencias.Unidades)})";
            //DoTiempoRecuperacionMin.Text = Condicionantes.Wrote_Formating(DoTiempoRecuperacionMin.Text);
            //DoTiempoRecuperacionMax.Text = Condicionantes.Wrote_Formating(DoTiempoRecuperacionMax.Text);

            #endregion DoTiempoRecuperacion

            #region DoTiempoInyeccion

            //DoTiempoInyeccion.Text = $"{Languages.Pozo.DoTiempoInyeccion} ({ Configuracion.GetSigla(Siglas.Segundo, Referencias.Unidades)})";
            //DoTiempoInyeccionMin.Text = Condicionantes.Wrote_Formating(DoTiempoInyeccionMin.Text);
            //DoTiempoInyeccionMax.Text = Condicionantes.Wrote_Formating(DoTiempoInyeccionMax.Text);

            #endregion DoTiempoInyeccion

            #region DoTiempoDesplazamientoTapon

            //DoTiempoDesplazamientoTapon.Text = $"{Languages.Pozo.DoTiempoDesplazamientoTapon} ({ Configuracion.GetSigla(Siglas.Segundo, Referencias.Unidades)})";
            //DoTiempoDesplazamientoTaponMin.Text = Condicionantes.Wrote_Formating(DoTiempoDesplazamientoTaponMin.Text);
            //DoTiempoDesplazamientoTaponMax.Text = Condicionantes.Wrote_Formating(DoTiempoDesplazamientoTaponMax.Text);

            #endregion DoTiempoDesplazamientoTapon

            #region DoEficienciaLlenado

            //DoEficienciaLlenado.Text = $"{Languages.Pozo.DoEficienciaLlenado} ({ Configuracion.GetSigla(Siglas.Porcentaje, Referencias.Unidades)})";
            //DoEficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(DoEficienciaLlenadoMin.Text);
            //DoEficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(DoEficienciaLlenadoMax.Text);

            #endregion DoEficienciaLlenado

            #region Temporizador

            //lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosOperativos} ({Languages.Siglas.Segundo})";
            //DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosOperativos

            #region CartaDinagrafica

            //CCartaDinagrafica.Text = $"{Languages.Pozo.CCartaDinagrafica} ({ Configuracion.GetSigla(Siglas.Longitud_Carta, Referencias.Unidades)}/{ Configuracion.GetSigla(Siglas.Fuerza, Referencias.Unidades)})";

            #region Temporizador

            //lbTemporizador2.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.CartaDinagrafica} ({Languages.Siglas.Segundo})";
            //CartaDinagrafica.Text = Condicionantes.Wrote_Formating(CartaDinagrafica.Text);

            #endregion Temporizador

            #endregion CartaDinagrafica
        }

        internal TomaBasica SaveTomaInformacion()
        {
            TomaBasica Range = new TomaBasica();

            #region DatosOperativos

            #region DoPresionTuberiaProduccion

            //Range.DoPresionTuberiaProduccion = DoPresionTuberiaProduccion.Checked;
            //Range.DoPresionTuberiaProduccionMin = Convert.ToDecimal(DoPresionTuberiaProduccionMin.Text);
            //Range.DoPresionTuberiaProduccionMax = Convert.ToDecimal(DoPresionTuberiaProduccionMax.Text);

            //if (Range.DoPresionTuberiaProduccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoPresionTuberiaProduccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoPresionTuberiaProduccionMin >= Range.DoPresionTuberiaProduccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoPresionTuberiaProduccion)
            //                 .Replace("{1}", $"{Range.DoPresionTuberiaProduccionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoPresionTuberiaProduccionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoPresionTuberiaProduccion = false;
            //    }
            //}

            #endregion DoPresionTuberiaProduccion

            #region DoPresionTuberiaRevestimiento

            //Range.DoPresionTuberiaRevestimiento = DoPresionTuberiaRevestimiento.Checked;
            //Range.DoPresionTuberiaRevestimientoMin = Convert.ToDecimal(DoPresionTuberiaRevestimientoMin.Text);
            //Range.DoPresionTuberiaRevestimientoMax = Convert.ToDecimal(DoPresionTuberiaRevestimientoMax.Text);

            //if (Range.DoPresionTuberiaRevestimiento)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoPresionTuberiaRevestimientoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoPresionTuberiaRevestimientoMin >= Range.DoPresionTuberiaRevestimientoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoPresionTuberiaRevestimiento)
            //                 .Replace("{1}", $"{Range.DoPresionTuberiaRevestimientoMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoPresionTuberiaRevestimientoMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoPresionTuberiaRevestimiento = false;
            //    }
            //}

            #endregion DoPresionTuberiaRevestimiento

            #region DoPresionAperturaCampo

            //Range.DoPresionAperturaCampo = DoPresionAperturaCampo.Checked;
            //Range.DoPresionAperturaCampoMin = Convert.ToDecimal(DoPresionAperturaCampoMin.Text);
            //Range.DoPresionAperturaCampoMax = Convert.ToDecimal(DoPresionAperturaCampoMax.Text);

            //if (Range.DoPresionAperturaCampo)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoPresionAperturaCampoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoPresionAperturaCampoMin >= Range.DoPresionAperturaCampoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoPresionAperturaCampo)
            //                 .Replace("{1}", $"{Range.DoPresionAperturaCampoMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoPresionAperturaCampoMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoPresionAperturaCampo = false;
            //    }
            //}

            #endregion DoPresionAperturaCampo

            #region DoPresionLineaDescarga

            //Range.DoPresionLineaDescarga = DoPresionLineaDescarga.Checked;
            //Range.DoPresionLineaDescargaMin = Convert.ToDecimal(DoPresionLineaDescargaMin.Text);
            //Range.DoPresionLineaDescargaMax = Convert.ToDecimal(DoPresionLineaDescargaMax.Text);

            //if (Range.DoPresionLineaDescarga)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoPresionLineaDescargaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoPresionLineaDescargaMin >= Range.DoPresionLineaDescargaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoPresionLineaDescarga)
            //                 .Replace("{1}", $"{Range.DoPresionLineaDescargaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoPresionLineaDescargaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoPresionLineaDescarga = false;
            //    }
            //}

            #endregion DoPresionLineaDescarga

            #region DoTemperaturaSuperficie

            //Range.DoTemperaturaSuperficie = DoTemperaturaSuperficie.Checked;
            //Range.DoTemperaturaSuperficieMin = Convert.ToDecimal(DoTemperaturaSuperficieMin.Text);
            //Range.DoTemperaturaSuperficieMax = Convert.ToDecimal(DoTemperaturaSuperficieMax.Text);

            //if (Range.DoTemperaturaSuperficie)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoTemperaturaSuperficieMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoTemperaturaSuperficieMin >= Range.DoTemperaturaSuperficieMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoTemperaturaSuperficie)
            //                 .Replace("{1}", $"{Range.DoTemperaturaSuperficieMin} { Configuracion.GetSigla(Siglas.Temperatura, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoTemperaturaSuperficieMax} { Configuracion.GetSigla(Siglas.Temperatura, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoTemperaturaSuperficie = false;
            //    }
            //}

            #endregion DoTemperaturaSuperficie

            #region DoSumergenciaEfectivaBomba

            //Range.DoSumergenciaEfectivaBomba = DoSumergenciaEfectivaBomba.Checked;
            //Range.DoSumergenciaEfectivaBombaMin = Convert.ToDecimal(DoSumergenciaEfectivaBombaMin.Text);
            //Range.DoSumergenciaEfectivaBombaMax = Convert.ToDecimal(DoSumergenciaEfectivaBombaMax.Text);

            //if (Range.DoSumergenciaEfectivaBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoSumergenciaEfectivaBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoSumergenciaEfectivaBombaMin >= Range.DoSumergenciaEfectivaBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoSumergenciaEfectivaBomba)
            //                 .Replace("{1}", $"{Range.DoSumergenciaEfectivaBombaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoSumergenciaEfectivaBombaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoSumergenciaEfectivaBomba = false;
            //    }
            //}

            #endregion DoSumergenciaEfectivaBomba

            #region DoNivelFluidoPozoTp

            //Range.DoNivelFluidoPozoTp = DoNivelFluidoPozoTp.Checked;
            //Range.DoNivelFluidoPozoTpMin = Convert.ToDecimal(DoNivelFluidoPozoTpMin.Text);
            //Range.DoNivelFluidoPozoTpMax = Convert.ToDecimal(DoNivelFluidoPozoTpMax.Text);

            //if (Range.DoNivelFluidoPozoTp)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoNivelFluidoPozoTpMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoNivelFluidoPozoTpMin >= Range.DoNivelFluidoPozoTpMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoNivelFluidoPozoTp)
            //                 .Replace("{1}", $"{Range.DoNivelFluidoPozoTpMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoNivelFluidoPozoTpMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoNivelFluidoPozoTp = false;
            //    }
            //}

            #endregion DoNivelFluidoPozoTp

            #region DoNivelFluidoPozoTr

            //Range.DoNivelFluidoPozoTr = DoNivelFluidoPozoTr.Checked;
            //Range.DoNivelFluidoPozoTrMin = Convert.ToDecimal(DoNivelFluidoPozoTrMin.Text);
            //Range.DoNivelFluidoPozoTrMax = Convert.ToDecimal(DoNivelFluidoPozoTrMax.Text);

            //if (Range.DoNivelFluidoPozoTr)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoNivelFluidoPozoTrMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoNivelFluidoPozoTrMin >= Range.DoNivelFluidoPozoTrMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoNivelFluidoPozoTr)
            //                 .Replace("{1}", $"{Range.DoNivelFluidoPozoTrMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoNivelFluidoPozoTrMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoNivelFluidoPozoTr = false;
            //    }
            //}

            #endregion DoNivelFluidoPozoTr

            #region DoPresionEntradaBomba

            //Range.DoPresionEntradaBomba = DoPresionEntradaBomba.Checked;
            //Range.DoPresionEntradaBombaMin = Convert.ToDecimal(DoPresionEntradaBombaMin.Text);
            //Range.DoPresionEntradaBombaMax = Convert.ToDecimal(DoPresionEntradaBombaMax.Text);

            //if (Range.DoPresionEntradaBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoPresionEntradaBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoPresionEntradaBombaMin >= Range.DoPresionEntradaBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoPresionEntradaBomba)
            //                 .Replace("{1}", $"{Range.DoPresionEntradaBombaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoPresionEntradaBombaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoPresionEntradaBomba = false;
            //    }
            //}

            #endregion DoPresionEntradaBomba

            #region DoVelocidadBomba

            //Range.DoVelocidadBomba = DoVelocidadBomba.Checked;
            //Range.DoVelocidadBombaMin = Convert.ToDecimal(DoVelocidadBombaMin.Text);
            //Range.DoVelocidadBombaMax = Convert.ToDecimal(DoVelocidadBombaMax.Text);

            //if (Range.DoVelocidadBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoVelocidadBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoVelocidadBombaMin >= Range.DoVelocidadBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoVelocidadBomba)
            //                 .Replace("{1}", $"{Range.DoVelocidadBombaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoVelocidadBombaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoVelocidadBomba = false;
            //    }
            //}

            #endregion DoVelocidadBomba

            #region DoVelocidadUnidadBombeo

            //Range.DoVelocidadUnidadBombeo = DoVelocidadUnidadBombeo.Checked;
            //Range.DoVelocidadUnidadBombeoMin = Convert.ToDecimal(DoVelocidadUnidadBombeoMin.Text);
            //Range.DoVelocidadUnidadBombeoMax = Convert.ToDecimal(DoVelocidadUnidadBombeoMax.Text);

            //if (Range.DoVelocidadUnidadBombeo)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoVelocidadUnidadBombeoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoVelocidadUnidadBombeoMin >= Range.DoVelocidadUnidadBombeoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoVelocidadUnidadBombeo)
            //                 .Replace("{1}", $"{Range.DoVelocidadUnidadBombeoMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoVelocidadUnidadBombeoMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoVelocidadUnidadBombeo = false;
            //    }
            //}

            #endregion DoVelocidadUnidadBombeo

            #region DoFrecuenciaOperacionBomba

            //Range.DoFrecuenciaOperacionBomba = DoFrecuenciaOperacionBomba.Checked;
            //Range.DoFrecuenciaOperacionBombaMin = Convert.ToDecimal(DoFrecuenciaOperacionBombaMin.Text);
            //Range.DoFrecuenciaOperacionBombaMax = Convert.ToDecimal(DoFrecuenciaOperacionBombaMax.Text);

            //if (Range.DoFrecuenciaOperacionBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoFrecuenciaOperacionBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoFrecuenciaOperacionBombaMin >= Range.DoFrecuenciaOperacionBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoFrecuenciaOperacionBomba)
            //                 .Replace("{1}", $"{Range.DoFrecuenciaOperacionBombaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoFrecuenciaOperacionBombaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoFrecuenciaOperacionBomba = false;
            //    }
            //}

            #endregion DoFrecuenciaOperacionBomba

            #region DoVelocidadMotor

            //Range.DoVelocidadMotor = DoVelocidadMotor.Checked;
            //Range.DoVelocidadMotorMin = Convert.ToDecimal(DoVelocidadMotorMin.Text);
            //Range.DoVelocidadMotorMax = Convert.ToDecimal(DoVelocidadMotorMax.Text);

            //if (Range.DoVelocidadMotor)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoVelocidadMotorMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoVelocidadMotorMin >= Range.DoVelocidadMotorMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoVelocidadMotor)
            //                 .Replace("{1}", $"{Range.DoVelocidadMotorMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoVelocidadMotorMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoVelocidadMotor = false;
            //    }
            //}

            #endregion DoVelocidadMotor

            #region DoLongitudCarrera

            //Range.DoLongitudCarrera = DoLongitudCarrera.Checked;
            //Range.DoLongitudCarreraMin = Convert.ToDecimal(DoLongitudCarreraMin.Text);
            //Range.DoLongitudCarreraMax = Convert.ToDecimal(DoLongitudCarreraMax.Text);

            //if (Range.DoLongitudCarrera)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoLongitudCarreraMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoLongitudCarreraMin >= Range.DoLongitudCarreraMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoLongitudCarrera)
            //                 .Replace("{1}", $"{Range.DoLongitudCarreraMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoLongitudCarreraMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoLongitudCarrera = false;
            //    }
            //}

            #endregion DoLongitudCarrera

            #region DoPresionDisponible

            //Range.DoPresionDisponible = DoPresionDisponible.Checked;
            //Range.DoPresionDisponibleMin = Convert.ToDecimal(DoPresionDisponibleMin.Text);
            //Range.DoPresionDisponibleMax = Convert.ToDecimal(DoPresionDisponibleMax.Text);

            //if (Range.DoPresionDisponible)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoPresionDisponibleMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoPresionDisponibleMin >= Range.DoPresionDisponibleMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoPresionDisponible)
            //                 .Replace("{1}", $"{Range.DoPresionDisponibleMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoPresionDisponibleMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoPresionDisponible = false;
            //    }
            //}

            #endregion DoPresionDisponible

            #region DoGastoInyeccionFluidoPotencia

            //Range.DoGastoInyeccionFluidoPotencia = DoGastoInyeccionFluidoPotencia.Checked;
            //Range.DoGastoInyeccionFluidoPotenciaMin = Convert.ToDecimal(DoGastoInyeccionFluidoPotenciaMin.Text);
            //Range.DoGastoInyeccionFluidoPotenciaMax = Convert.ToDecimal(DoGastoInyeccionFluidoPotenciaMax.Text);

            //if (Range.DoGastoInyeccionFluidoPotencia)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoGastoInyeccionFluidoPotenciaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoGastoInyeccionFluidoPotenciaMin >= Range.DoGastoInyeccionFluidoPotenciaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoGastoInyeccionFluidoPotencia)
            //                 .Replace("{1}", $"{Range.DoGastoInyeccionFluidoPotenciaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoGastoInyeccionFluidoPotenciaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoGastoInyeccionFluidoPotencia = false;
            //    }
            //}

            #endregion DoGastoInyeccionFluidoPotencia

            #region DoGravedadEspecificaFluidoPotencia

            //Range.DoGravedadEspecificaFluidoPotencia = DoGravedadEspecificaFluidoPotencia.Checked;
            //Range.DoGravedadEspecificaFluidoPotenciaMin = Convert.ToDecimal(DoGravedadEspecificaFluidoPotenciaMin.Text);
            //Range.DoGravedadEspecificaFluidoPotenciaMax = Convert.ToDecimal(DoGravedadEspecificaFluidoPotenciaMax.Text);

            //if (Range.DoGravedadEspecificaFluidoPotencia)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoGravedadEspecificaFluidoPotenciaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoGravedadEspecificaFluidoPotenciaMin >= Range.DoGravedadEspecificaFluidoPotenciaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoGravedadEspecificaFluidoPotencia)
            //                 .Replace("{1}", $"{Range.DoGravedadEspecificaFluidoPotenciaMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoGravedadEspecificaFluidoPotenciaMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoGravedadEspecificaFluidoPotencia = false;
            //    }
            //}

            #endregion DoGravedadEspecificaFluidoPotencia

            #region DoGastoGasInyeccion

            //Range.DoGastoGasInyeccion = DoGastoGasInyeccion.Checked;
            //Range.DoGastoGasInyeccionMin = Convert.ToDecimal(DoGastoGasInyeccionMin.Text);
            //Range.DoGastoGasInyeccionMax = Convert.ToDecimal(DoGastoGasInyeccionMax.Text);

            //if (Range.DoGastoGasInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoGastoGasInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoGastoGasInyeccionMin >= Range.DoGastoGasInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoGastoGasInyeccion)
            //                 .Replace("{1}", $"{Range.DoGastoGasInyeccionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoGastoGasInyeccionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoGastoGasInyeccion = false;
            //    }
            //}

            #endregion DoGastoGasInyeccion

            #region DoGravedadEspecificaGasInyeccion

            //Range.DoGravedadEspecificaGasInyeccion = DoGravedadEspecificaGasInyeccion.Checked;
            //Range.DoGravedadEspecificaGasInyeccionMin = Convert.ToDecimal(DoGravedadEspecificaGasInyeccionMin.Text);
            //Range.DoGravedadEspecificaGasInyeccionMax = Convert.ToDecimal(DoGravedadEspecificaGasInyeccionMax.Text);

            //if (Range.DoGravedadEspecificaGasInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoGravedadEspecificaGasInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoGravedadEspecificaGasInyeccionMin >= Range.DoGravedadEspecificaGasInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoGravedadEspecificaGasInyeccion)
            //                 .Replace("{1}", $"{Range.DoGravedadEspecificaGasInyeccionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoGravedadEspecificaGasInyeccionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoGravedadEspecificaGasInyeccion = false;
            //    }
            //}

            #endregion DoGravedadEspecificaGasInyeccion

            #region DoTorque

            //Range.DoTorque = DoTorque.Checked;
            //Range.DoTorqueMin = Convert.ToDecimal(DoTorqueMin.Text);
            //Range.DoTorqueMax = Convert.ToDecimal(DoTorqueMax.Text);

            //if (Range.DoTorque)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoTorqueMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoTorqueMin >= Range.DoTorqueMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoTorque)
            //                 .Replace("{1}", $"{Range.DoTorqueMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoTorqueMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoTorque = false;
            //    }
            //}

            #endregion DoTorque

            #region DoCorriente

            //Range.DoCorriente = DoCorriente.Checked;
            //Range.DoCorrienteMin = Convert.ToDecimal(DoCorrienteMin.Text);
            //Range.DoCorrienteMax = Convert.ToDecimal(DoCorrienteMax.Text);

            //if (Range.DoCorriente)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoCorrienteMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoCorrienteMin >= Range.DoCorrienteMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoCorriente)
            //                 .Replace("{1}", $"{Range.DoCorrienteMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoCorrienteMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoCorriente = false;
            //    }
            //}

            #endregion DoCorriente

            #region DoDiametroEstrangulador

            //Range.DoDiametroEstrangulador = DoDiametroEstrangulador.Checked;
            //Range.DoDiametroEstranguladorMin = Convert.ToDecimal(DoDiametroEstranguladorMin.Text);
            //Range.DoDiametroEstranguladorMax = Convert.ToDecimal(DoDiametroEstranguladorMax.Text);

            //if (Range.DoDiametroEstrangulador)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoDiametroEstranguladorMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoDiametroEstranguladorMin >= Range.DoDiametroEstranguladorMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoDiametroEstrangulador)
            //                 .Replace("{1}", $"{Range.DoDiametroEstranguladorMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoDiametroEstranguladorMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoDiametroEstrangulador = false;
            //    }
            //}

            #endregion DoDiametroEstrangulador

            #region DoTiempoCiclo

            //Range.DoTiempoCiclo = DoTiempoCiclo.Checked;
            //Range.DoTiempoCicloMin = Convert.ToDecimal(DoTiempoCicloMin.Text);
            //Range.DoTiempoCicloMax = Convert.ToDecimal(DoTiempoCicloMax.Text);

            //if (Range.DoTiempoCiclo)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoTiempoCicloMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoTiempoCicloMin >= Range.DoTiempoCicloMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoTiempoCiclo)
            //                 .Replace("{1}", $"{Range.DoTiempoCicloMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoTiempoCicloMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoTiempoCiclo = false;
            //    }
            //}

            #endregion DoTiempoCiclo

            #region DoTiempoRecuperacion

            //Range.DoTiempoRecuperacion = DoTiempoRecuperacion.Checked;
            //Range.DoTiempoRecuperacionMin = Convert.ToDecimal(DoTiempoRecuperacionMin.Text);
            //Range.DoTiempoRecuperacionMax = Convert.ToDecimal(DoTiempoRecuperacionMax.Text);

            //if (Range.DoTiempoRecuperacion)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoTiempoRecuperacionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoTiempoRecuperacionMin >= Range.DoTiempoRecuperacionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoTiempoRecuperacion)
            //                 .Replace("{1}", $"{Range.DoTiempoRecuperacionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoTiempoRecuperacionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoTiempoRecuperacion = false;
            //    }
            //}

            #endregion DoTiempoRecuperacion

            #region DoTiempoInyeccion

            //Range.DoTiempoInyeccion = DoTiempoInyeccion.Checked;
            //Range.DoTiempoInyeccionMin = Convert.ToDecimal(DoTiempoInyeccionMin.Text);
            //Range.DoTiempoInyeccionMax = Convert.ToDecimal(DoTiempoInyeccionMax.Text);

            //if (Range.DoTiempoInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoTiempoInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoTiempoInyeccionMin >= Range.DoTiempoInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoTiempoInyeccion)
            //                 .Replace("{1}", $"{Range.DoTiempoInyeccionMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoTiempoInyeccionMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoTiempoInyeccion = false;
            //    }
            //}

            #endregion DoTiempoInyeccion

            #region DoTiempoDesplazamientoTapon

            //Range.DoTiempoDesplazamientoTapon = DoTiempoDesplazamientoTapon.Checked;
            //Range.DoTiempoDesplazamientoTaponMin = Convert.ToDecimal(DoTiempoDesplazamientoTaponMin.Text);
            //Range.DoTiempoDesplazamientoTaponMax = Convert.ToDecimal(DoTiempoDesplazamientoTaponMax.Text);

            //if (Range.DoTiempoDesplazamientoTapon)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoTiempoDesplazamientoTaponMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoTiempoDesplazamientoTaponMin >= Range.DoTiempoDesplazamientoTaponMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoTiempoDesplazamientoTapon)
            //                 .Replace("{1}", $"{Range.DoTiempoDesplazamientoTaponMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoTiempoDesplazamientoTaponMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoTiempoDesplazamientoTapon = false;
            //    }
            //}

            #endregion DoTiempoDesplazamientoTapon

            #region DoEficienciaLlenado

            //Range.DoEficienciaLlenado = DoEficienciaLlenado.Checked;
            //Range.DoEficienciaLlenadoMin = Convert.ToDecimal(DoEficienciaLlenadoMin.Text);
            //Range.DoEficienciaLlenadoMax = Convert.ToDecimal(DoEficienciaLlenadoMax.Text);

            //if (Range.DoEficienciaLlenado)
            //{
            //    string msn = string.Empty;
            //    if (Range.DoEficienciaLlenadoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DoEficienciaLlenadoMin >= Range.DoEficienciaLlenadoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.DoEficienciaLlenado)
            //                 .Replace("{1}", $"{Range.DoEficienciaLlenadoMin} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DoEficienciaLlenadoMax} { Configuracion.GetSigla(Siglas.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DoEficienciaLlenado = false;
            //    }
            //}

            #endregion DoEficienciaLlenado

            #region Temporizador

            //Range.DatosOperativos = TimeSpan.FromSeconds(Convert.ToDouble(DatosOperativos.Text));

            #endregion Temporizador

            #endregion DatosOperativos

            #region CCartaDinagrafica

            //Range.CCartaDinagrafica = CCartaDinagrafica.Check;
            //List<OCartaDinagrafica.CCartaDinagrafica> ListCCartaDinagrafica = new List<OCartaDinagrafica.CCartaDinagrafica>();

            #region Temporizador

            //Range.CartaDinagrafica = TimeSpan.FromSeconds(Convert.ToDouble(CartaDinagrafica.Text));

            #endregion Temporizador

            #endregion CCartaDinagrafica

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

        private void TomaInformacion_Load(object sender, EventArgs e)
        {
        }
    }
}