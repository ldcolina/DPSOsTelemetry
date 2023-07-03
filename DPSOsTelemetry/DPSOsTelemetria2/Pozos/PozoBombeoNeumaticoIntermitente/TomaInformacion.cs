using System;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

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

            #region presionTuberiaProduccion

            //presionTuberiaProduccion.Checked = referencias.Range.presionTuberiaProduccion;
            //presionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaProduccionMin.ToString());
            //presionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaProduccionMax.ToString());

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            //presionTuberiaRevestimiento.Checked = referencias.Range.presionTuberiaRevestimiento;
            //presionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaRevestimientoMin.ToString());
            //presionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionTuberiaRevestimientoMax.ToString());

            #endregion presionTuberiaRevestimiento

            #region presionAperturaCampo

            //presionAperturaCampo.Checked = referencias.Range.presionAperturaCampo;
            //presionAperturaCampoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionAperturaCampoMin.ToString());
            //presionAperturaCampoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionAperturaCampoMax.ToString());

            #endregion presionAperturaCampo

            #region presionLineaDescarga

            //presionLineaDescarga.Checked = referencias.Range.presionLineaDescarga;
            //presionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionLineaDescargaMin.ToString());
            //presionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionLineaDescargaMax.ToString());

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            //temperaturaSuperficie.Checked = referencias.Range.temperaturaSuperficie;
            //temperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(referencias.Range.temperaturaSuperficieMin.ToString());
            //temperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(referencias.Range.temperaturaSuperficieMax.ToString());

            #endregion temperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //sumergenciaEfectivaBomba.Checked = referencias.Range.sumergenciaEfectivaBomba;
            //sumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.sumergenciaEfectivaBombaMin.ToString());
            //sumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.sumergenciaEfectivaBombaMax.ToString());

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTp

            //nivelFluidoPozoTp.Checked = referencias.Range.nivelFluidoPozoTp;
            //nivelFluidoPozoTpMin.Text = Condicionantes.Wrote_Formating(referencias.Range.nivelFluidoPozoTpMin.ToString());
            //nivelFluidoPozoTpMax.Text = Condicionantes.Wrote_Formating(referencias.Range.nivelFluidoPozoTpMax.ToString());

            #endregion nivelFluidoPozoTp

            #region nivelFluidoPozoTr

            //nivelFluidoPozoTr.Checked = referencias.Range.nivelFluidoPozoTr;
            //nivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(referencias.Range.nivelFluidoPozoTrMin.ToString());
            //nivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(referencias.Range.nivelFluidoPozoTrMax.ToString());

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            //presionEntradaBomba.Checked = referencias.Range.presionEntradaBomba;
            //presionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionEntradaBombaMin.ToString());
            //presionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionEntradaBombaMax.ToString());

            #endregion presionEntradaBomba

            #region velocidadBomba

            //velocidadBomba.Checked = referencias.Range.velocidadBomba;
            //velocidadBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadBombaMin.ToString());
            //velocidadBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadBombaMax.ToString());

            #endregion velocidadBomba

            #region velocidadUnidadBombeo

            //velocidadUnidadBombeo.Checked = referencias.Range.velocidadUnidadBombeo;
            //velocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadUnidadBombeoMin.ToString());
            //velocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadUnidadBombeoMax.ToString());

            #endregion velocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //frecuenciaOperacionBomba.Checked = referencias.Range.frecuenciaOperacionBomba;
            //frecuenciaOperacionBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.frecuenciaOperacionBombaMin.ToString());
            //frecuenciaOperacionBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.frecuenciaOperacionBombaMax.ToString());

            #endregion frecuenciaOperacionBomba

            #region velocidadMotor

            //velocidadMotor.Checked = referencias.Range.velocidadMotor;
            //velocidadMotorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadMotorMin.ToString());
            //velocidadMotorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.velocidadMotorMax.ToString());

            #endregion velocidadMotor

            #region longitudCarrera

            //longitudCarrera.Checked = referencias.Range.longitudCarrera;
            //longitudCarreraMin.Text = Condicionantes.Wrote_Formating(referencias.Range.longitudCarreraMin.ToString());
            //longitudCarreraMax.Text = Condicionantes.Wrote_Formating(referencias.Range.longitudCarreraMax.ToString());

            #endregion longitudCarrera

            #region presionDisponible

            //presionDisponible.Checked = referencias.Range.presionDisponible;
            //presionDisponibleMin.Text = Condicionantes.Wrote_Formating(referencias.Range.presionDisponibleMin.ToString());
            //presionDisponibleMax.Text = Condicionantes.Wrote_Formating(referencias.Range.presionDisponibleMax.ToString());

            #endregion presionDisponible

            #region gastoInyeccionFluidoPotencia

            //gastoInyeccionFluidoPotencia.Checked = referencias.Range.gastoInyeccionFluidoPotencia;
            //gastoInyeccionFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.gastoInyeccionFluidoPotenciaMin.ToString());
            //gastoInyeccionFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.gastoInyeccionFluidoPotenciaMax.ToString());

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //gravedadEspecificaFluidoPotencia.Checked = referencias.Range.gravedadEspecificaFluidoPotencia;
            //gravedadEspecificaFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.gravedadEspecificaFluidoPotenciaMin.ToString());
            //gravedadEspecificaFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.gravedadEspecificaFluidoPotenciaMax.ToString());

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //gastoGasInyeccion.Checked = referencias.Range.gastoGasInyeccion;
            //gastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.gastoGasInyeccionMin.ToString());
            //gastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.gastoGasInyeccionMax.ToString());

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //gravedadEspecificaGasInyeccion.Checked = referencias.Range.gravedadEspecificaGasInyeccion;
            //gravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.gravedadEspecificaGasInyeccionMin.ToString());
            //gravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.gravedadEspecificaGasInyeccionMax.ToString());

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //torque.Checked = referencias.Range.torque;
            //torqueMin.Text = Condicionantes.Wrote_Formating(referencias.Range.torqueMin.ToString());
            //torqueMax.Text = Condicionantes.Wrote_Formating(referencias.Range.torqueMax.ToString());

            #endregion torque

            #region corriente

            //corriente.Checked = referencias.Range.corriente;
            //corrienteMin.Text = Condicionantes.Wrote_Formating(referencias.Range.corrienteMin.ToString());
            //corrienteMax.Text = Condicionantes.Wrote_Formating(referencias.Range.corrienteMax.ToString());

            #endregion corriente

            #region diametroEstrangulador

            //diametroEstrangulador.Checked = referencias.Range.diametroEstrangulador;
            //diametroEstranguladorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.diametroEstranguladorMin.ToString());
            //diametroEstranguladorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.diametroEstranguladorMax.ToString());

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //tiempoCiclo.Checked = referencias.Range.tiempoCiclo;
            //tiempoCicloMin.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoCicloMin.ToString());
            //tiempoCicloMax.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoCicloMax.ToString());

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //tiempoRecuperacion.Checked = referencias.Range.tiempoRecuperacion;
            //tiempoRecuperacionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoRecuperacionMin.ToString());
            //tiempoRecuperacionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoRecuperacionMax.ToString());

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //tiempoInyeccion.Checked = referencias.Range.tiempoInyeccion;
            //tiempoInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoInyeccionMin.ToString());
            //tiempoInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoInyeccionMax.ToString());

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //tiempoDesplazamientoTapon.Checked = referencias.Range.tiempoDesplazamientoTapon;
            //tiempoDesplazamientoTaponMin.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoDesplazamientoTaponMin.ToString());
            //tiempoDesplazamientoTaponMax.Text = Condicionantes.Wrote_Formating(referencias.Range.tiempoDesplazamientoTaponMax.ToString());

            #endregion tiempoDesplazamientoTapon

            #region eficienciaLlenado

            //eficienciaLlenado.Checked = referencias.Range.eficienciaLlenado;
            //eficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.eficienciaLlenadoMin.ToString());
            //eficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.eficienciaLlenadoMax.ToString());

            #endregion eficienciaLlenado

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
        }

        internal void Recargar()
        {
            #region DatosOperativos

            #region presionTuberiaProduccion

            //presionTuberiaProduccion.Text = $"{Languages.Pozo.presionTuberiaProduccion} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //presionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(presionTuberiaProduccionMin.Text);
            //presionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(presionTuberiaProduccionMax.Text);

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            //presionTuberiaRevestimiento.Text = $"{Languages.Pozo.presionTuberiaRevestimiento} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //presionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(presionTuberiaRevestimientoMin.Text);
            //presionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(presionTuberiaRevestimientoMax.Text);

            #endregion presionTuberiaRevestimiento

            #region presionAperturaCampo

            //presionAperturaCampo.Text = $"{Languages.Pozo.presionAperturaCampo} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //presionAperturaCampoMin.Text = Condicionantes.Wrote_Formating(presionAperturaCampoMin.Text);
            //presionAperturaCampoMax.Text = Condicionantes.Wrote_Formating(presionAperturaCampoMax.Text);

            #endregion presionAperturaCampo

            #region presionLineaDescarga

            //presionLineaDescarga.Text = $"{Languages.Pozo.presionLineaDescarga} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //presionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(presionLineaDescargaMin.Text);
            //presionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(presionLineaDescargaMax.Text);

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            //temperaturaSuperficie.Text = $"{Languages.Pozo.temperaturaSuperficie} ({ Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)})";
            //temperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(temperaturaSuperficieMin.Text);
            //temperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(temperaturaSuperficieMax.Text);

            #endregion temperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //sumergenciaEfectivaBomba.Text = $"{Languages.Pozo.sumergenciaEfectivaBomba} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //sumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(sumergenciaEfectivaBombaMin.Text);
            //sumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(sumergenciaEfectivaBombaMax.Text);

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTp

            //nivelFluidoPozoTp.Text = $"{Languages.Pozo.nivelFluidoPozoTp} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //nivelFluidoPozoTpMin.Text = Condicionantes.Wrote_Formating(nivelFluidoPozoTpMin.Text);
            //nivelFluidoPozoTpMax.Text = Condicionantes.Wrote_Formating(nivelFluidoPozoTpMax.Text);

            #endregion nivelFluidoPozoTp

            #region nivelFluidoPozoTr

            //nivelFluidoPozoTr.Text = $"{Languages.Pozo.nivelFluidoPozoTr} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //nivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(nivelFluidoPozoTrMin.Text);
            //nivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(nivelFluidoPozoTrMax.Text);

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            //presionEntradaBomba.Text = $"{Languages.Pozo.presionEntradaBomba} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //presionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(presionEntradaBombaMin.Text);
            //presionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(presionEntradaBombaMax.Text);

            #endregion presionEntradaBomba

            #region velocidadBomba

            //velocidadBomba.Text = $"{Languages.Pozo.velocidadBomba} ({ Configuracion.GetSigla(Referencia.Velocidad, Referencias.Unidades)})";
            //velocidadBombaMin.Text = Condicionantes.Wrote_Formating(velocidadBombaMin.Text);
            //velocidadBombaMax.Text = Condicionantes.Wrote_Formating(velocidadBombaMax.Text);

            #endregion velocidadBomba

            #region velocidadUnidadBombeo

            //velocidadUnidadBombeo.Text = $"{Languages.Pozo.velocidadUnidadBombeo} ({ Configuracion.GetSigla(Referencia.Embolada, Referencias.Unidades)})";
            //velocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(velocidadUnidadBombeoMin.Text);
            //velocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(velocidadUnidadBombeoMax.Text);

            #endregion velocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //frecuenciaOperacionBomba.Text = $"{Languages.Pozo.frecuenciaOperacionBomba} ({ Configuracion.GetSigla(Referencia.Frecuencia, Referencias.Unidades)})";
            //frecuenciaOperacionBombaMin.Text = Condicionantes.Wrote_Formating(frecuenciaOperacionBombaMin.Text);
            //frecuenciaOperacionBombaMax.Text = Condicionantes.Wrote_Formating(frecuenciaOperacionBombaMax.Text);

            #endregion frecuenciaOperacionBomba

            #region velocidadMotor

            //velocidadMotor.Text = $"{Languages.Pozo.velocidadMotor} ({ Configuracion.GetSigla(Referencia.Velocidad, Referencias.Unidades)})";
            //velocidadMotorMin.Text = Condicionantes.Wrote_Formating(velocidadMotorMin.Text);
            //velocidadMotorMax.Text = Condicionantes.Wrote_Formating(velocidadMotorMax.Text);

            #endregion velocidadMotor

            #region longitudCarrera

            //longitudCarrera.Text = $"{Languages.Pozo.longitudCarrera} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //longitudCarreraMin.Text = Condicionantes.Wrote_Formating(longitudCarreraMin.Text);
            //longitudCarreraMax.Text = Condicionantes.Wrote_Formating(longitudCarreraMax.Text);

            #endregion longitudCarrera

            #region presionDisponible

            //presionDisponible.Text = $"{Languages.Pozo.presionDisponible} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //presionDisponibleMin.Text = Condicionantes.Wrote_Formating(presionDisponibleMin.Text);
            //presionDisponibleMax.Text = Condicionantes.Wrote_Formating(presionDisponibleMax.Text);

            #endregion presionDisponible

            #region gastoInyeccionFluidoPotencia

            //gastoInyeccionFluidoPotencia.Text = $"{Languages.Pozo.gastoInyeccionFluidoPotencia} ({ Configuracion.GetSigla(Referencia.GastoGas, Referencias.Unidades)})";
            //gastoInyeccionFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(gastoInyeccionFluidoPotenciaMin.Text);
            //gastoInyeccionFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(gastoInyeccionFluidoPotenciaMax.Text);

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //gravedadEspecificaFluidoPotencia.Text = $"{Languages.Pozo.gravedadEspecificaFluidoPotencia} (-)";
            //gravedadEspecificaFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(gravedadEspecificaFluidoPotenciaMin.Text);
            //gravedadEspecificaFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(gravedadEspecificaFluidoPotenciaMax.Text);

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //gastoGasInyeccion.Text = $"{Languages.Pozo.gastoGasInyeccion} ({ Configuracion.GetSigla(Referencia.GastoGas, Referencias.Unidades)})";
            //gastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(gastoGasInyeccionMin.Text);
            //gastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(gastoGasInyeccionMax.Text);

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //gravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.gravedadEspecificaGasInyeccion} (-)";
            //gravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(gravedadEspecificaGasInyeccionMin.Text);
            //gravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(gravedadEspecificaGasInyeccionMax.Text);

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //torque.Text = $"{Languages.Pozo.torque} ({ Configuracion.GetSigla(Referencia.Torque, Referencias.Unidades)})";
            //torqueMin.Text = Condicionantes.Wrote_Formating(torqueMin.Text);
            //torqueMax.Text = Condicionantes.Wrote_Formating(torqueMax.Text);

            #endregion torque

            #region corriente

            //corriente.Text = $"{Languages.Pozo.corriente} ({ Configuracion.GetSigla(Referencia.Corriente, Referencias.Unidades)})";
            //corrienteMin.Text = Condicionantes.Wrote_Formating(corrienteMin.Text);
            //corrienteMax.Text = Condicionantes.Wrote_Formating(corrienteMax.Text);

            #endregion corriente

            #region diametroEstrangulador

            //diametroEstrangulador.Text = $"{Languages.Pozo.diametroEstrangulador} ({ Configuracion.GetSigla(Referencia.Diametro, Referencias.Unidades)})";
            //diametroEstranguladorMin.Text = Condicionantes.Wrote_Formating(diametroEstranguladorMin.Text);
            //diametroEstranguladorMax.Text = Condicionantes.Wrote_Formating(diametroEstranguladorMax.Text);

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //tiempoCiclo.Text = $"{Languages.Pozo.tiempoCiclo} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoCicloMin.Text = Condicionantes.Wrote_Formating(tiempoCicloMin.Text);
            //tiempoCicloMax.Text = Condicionantes.Wrote_Formating(tiempoCicloMax.Text);

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //tiempoRecuperacion.Text = $"{Languages.Pozo.tiempoRecuperacion} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoRecuperacionMin.Text = Condicionantes.Wrote_Formating(tiempoRecuperacionMin.Text);
            //tiempoRecuperacionMax.Text = Condicionantes.Wrote_Formating(tiempoRecuperacionMax.Text);

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //tiempoInyeccion.Text = $"{Languages.Pozo.tiempoInyeccion} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoInyeccionMin.Text = Condicionantes.Wrote_Formating(tiempoInyeccionMin.Text);
            //tiempoInyeccionMax.Text = Condicionantes.Wrote_Formating(tiempoInyeccionMax.Text);

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //tiempoDesplazamientoTapon.Text = $"{Languages.Pozo.tiempoDesplazamientoTapon} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoDesplazamientoTaponMin.Text = Condicionantes.Wrote_Formating(tiempoDesplazamientoTaponMin.Text);
            //tiempoDesplazamientoTaponMax.Text = Condicionantes.Wrote_Formating(tiempoDesplazamientoTaponMax.Text);

            #endregion tiempoDesplazamientoTapon

            #region eficienciaLlenado

            //eficienciaLlenado.Text = $"{Languages.Pozo.eficienciaLlenado} ({ Configuracion.GetSigla(Referencia.Porcentaje, Referencias.Unidades)})";
            //eficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(eficienciaLlenadoMin.Text);
            //eficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(eficienciaLlenadoMax.Text);

            #endregion eficienciaLlenado

            #region Temporizador

            //lbTemporizador1.Text = $"{Languages.Pozo.Temporizador}-{Languages.Pozo.DatosOperativos} ({Languages.Siglas.Segundo})";
            //DatosOperativos.Text = Condicionantes.Wrote_Formating(DatosOperativos.Text);

            #endregion Temporizador

            #endregion DatosOperativos

            #region CartaDinagrafica

            //CCartaDinagrafica.Text = $"{Languages.Pozo.CCartaDinagrafica} ({ Configuracion.GetSigla(Referencia.Longitud_Carta, Referencias.Unidades)}/{ Configuracion.GetSigla(Referencia.Fuerza, Referencias.Unidades)})";

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

            #region presionTuberiaProduccion

            //Range.presionTuberiaProduccion = presionTuberiaProduccion.Checked;
            //Range.presionTuberiaProduccionMin = Convert.ToDecimal(presionTuberiaProduccionMin.Text);
            //Range.presionTuberiaProduccionMax = Convert.ToDecimal(presionTuberiaProduccionMax.Text);

            //if (Range.presionTuberiaProduccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.presionTuberiaProduccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.presionTuberiaProduccionMin >= Range.presionTuberiaProduccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.presionTuberiaProduccion)
            //                 .Replace("{1}", $"{Range.presionTuberiaProduccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.presionTuberiaProduccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.presionTuberiaProduccion = false;
            //    }
            //}

            #endregion presionTuberiaProduccion

            #region presionTuberiaRevestimiento

            //Range.presionTuberiaRevestimiento = presionTuberiaRevestimiento.Checked;
            //Range.presionTuberiaRevestimientoMin = Convert.ToDecimal(presionTuberiaRevestimientoMin.Text);
            //Range.presionTuberiaRevestimientoMax = Convert.ToDecimal(presionTuberiaRevestimientoMax.Text);

            //if (Range.presionTuberiaRevestimiento)
            //{
            //    string msn = string.Empty;
            //    if (Range.presionTuberiaRevestimientoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.presionTuberiaRevestimientoMin >= Range.presionTuberiaRevestimientoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.presionTuberiaRevestimiento)
            //                 .Replace("{1}", $"{Range.presionTuberiaRevestimientoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.presionTuberiaRevestimientoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.presionTuberiaRevestimiento = false;
            //    }
            //}

            #endregion presionTuberiaRevestimiento

            #region presionAperturaCampo

            //Range.presionAperturaCampo = presionAperturaCampo.Checked;
            //Range.presionAperturaCampoMin = Convert.ToDecimal(presionAperturaCampoMin.Text);
            //Range.presionAperturaCampoMax = Convert.ToDecimal(presionAperturaCampoMax.Text);

            //if (Range.presionAperturaCampo)
            //{
            //    string msn = string.Empty;
            //    if (Range.presionAperturaCampoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.presionAperturaCampoMin >= Range.presionAperturaCampoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.presionAperturaCampo)
            //                 .Replace("{1}", $"{Range.presionAperturaCampoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.presionAperturaCampoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.presionAperturaCampo = false;
            //    }
            //}

            #endregion presionAperturaCampo

            #region presionLineaDescarga

            //Range.presionLineaDescarga = presionLineaDescarga.Checked;
            //Range.presionLineaDescargaMin = Convert.ToDecimal(presionLineaDescargaMin.Text);
            //Range.presionLineaDescargaMax = Convert.ToDecimal(presionLineaDescargaMax.Text);

            //if (Range.presionLineaDescarga)
            //{
            //    string msn = string.Empty;
            //    if (Range.presionLineaDescargaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.presionLineaDescargaMin >= Range.presionLineaDescargaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.presionLineaDescarga)
            //                 .Replace("{1}", $"{Range.presionLineaDescargaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.presionLineaDescargaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.presionLineaDescarga = false;
            //    }
            //}

            #endregion presionLineaDescarga

            #region temperaturaSuperficie

            //Range.temperaturaSuperficie = temperaturaSuperficie.Checked;
            //Range.temperaturaSuperficieMin = Convert.ToDecimal(temperaturaSuperficieMin.Text);
            //Range.temperaturaSuperficieMax = Convert.ToDecimal(temperaturaSuperficieMax.Text);

            //if (Range.temperaturaSuperficie)
            //{
            //    string msn = string.Empty;
            //    if (Range.temperaturaSuperficieMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.temperaturaSuperficieMin >= Range.temperaturaSuperficieMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.temperaturaSuperficie)
            //                 .Replace("{1}", $"{Range.temperaturaSuperficieMin} { Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.temperaturaSuperficieMax} { Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.temperaturaSuperficie = false;
            //    }
            //}

            #endregion temperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //Range.sumergenciaEfectivaBomba = sumergenciaEfectivaBomba.Checked;
            //Range.sumergenciaEfectivaBombaMin = Convert.ToDecimal(sumergenciaEfectivaBombaMin.Text);
            //Range.sumergenciaEfectivaBombaMax = Convert.ToDecimal(sumergenciaEfectivaBombaMax.Text);

            //if (Range.sumergenciaEfectivaBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.sumergenciaEfectivaBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.sumergenciaEfectivaBombaMin >= Range.sumergenciaEfectivaBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.sumergenciaEfectivaBomba)
            //                 .Replace("{1}", $"{Range.sumergenciaEfectivaBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.sumergenciaEfectivaBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.sumergenciaEfectivaBomba = false;
            //    }
            //}

            #endregion sumergenciaEfectivaBomba

            #region nivelFluidoPozoTp

            //Range.nivelFluidoPozoTp = nivelFluidoPozoTp.Checked;
            //Range.nivelFluidoPozoTpMin = Convert.ToDecimal(nivelFluidoPozoTpMin.Text);
            //Range.nivelFluidoPozoTpMax = Convert.ToDecimal(nivelFluidoPozoTpMax.Text);

            //if (Range.nivelFluidoPozoTp)
            //{
            //    string msn = string.Empty;
            //    if (Range.nivelFluidoPozoTpMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.nivelFluidoPozoTpMin >= Range.nivelFluidoPozoTpMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.nivelFluidoPozoTp)
            //                 .Replace("{1}", $"{Range.nivelFluidoPozoTpMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.nivelFluidoPozoTpMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.nivelFluidoPozoTp = false;
            //    }
            //}

            #endregion nivelFluidoPozoTp

            #region nivelFluidoPozoTr

            //Range.nivelFluidoPozoTr = nivelFluidoPozoTr.Checked;
            //Range.nivelFluidoPozoTrMin = Convert.ToDecimal(nivelFluidoPozoTrMin.Text);
            //Range.nivelFluidoPozoTrMax = Convert.ToDecimal(nivelFluidoPozoTrMax.Text);

            //if (Range.nivelFluidoPozoTr)
            //{
            //    string msn = string.Empty;
            //    if (Range.nivelFluidoPozoTrMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.nivelFluidoPozoTrMin >= Range.nivelFluidoPozoTrMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.nivelFluidoPozoTr)
            //                 .Replace("{1}", $"{Range.nivelFluidoPozoTrMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.nivelFluidoPozoTrMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.nivelFluidoPozoTr = false;
            //    }
            //}

            #endregion nivelFluidoPozoTr

            #region presionEntradaBomba

            //Range.presionEntradaBomba = presionEntradaBomba.Checked;
            //Range.presionEntradaBombaMin = Convert.ToDecimal(presionEntradaBombaMin.Text);
            //Range.presionEntradaBombaMax = Convert.ToDecimal(presionEntradaBombaMax.Text);

            //if (Range.presionEntradaBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.presionEntradaBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.presionEntradaBombaMin >= Range.presionEntradaBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.presionEntradaBomba)
            //                 .Replace("{1}", $"{Range.presionEntradaBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.presionEntradaBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.presionEntradaBomba = false;
            //    }
            //}

            #endregion presionEntradaBomba

            #region velocidadBomba

            //Range.velocidadBomba = velocidadBomba.Checked;
            //Range.velocidadBombaMin = Convert.ToDecimal(velocidadBombaMin.Text);
            //Range.velocidadBombaMax = Convert.ToDecimal(velocidadBombaMax.Text);

            //if (Range.velocidadBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.velocidadBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.velocidadBombaMin >= Range.velocidadBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.velocidadBomba)
            //                 .Replace("{1}", $"{Range.velocidadBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.velocidadBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.velocidadBomba = false;
            //    }
            //}

            #endregion velocidadBomba

            #region velocidadUnidadBombeo

            //Range.velocidadUnidadBombeo = velocidadUnidadBombeo.Checked;
            //Range.velocidadUnidadBombeoMin = Convert.ToDecimal(velocidadUnidadBombeoMin.Text);
            //Range.velocidadUnidadBombeoMax = Convert.ToDecimal(velocidadUnidadBombeoMax.Text);

            //if (Range.velocidadUnidadBombeo)
            //{
            //    string msn = string.Empty;
            //    if (Range.velocidadUnidadBombeoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.velocidadUnidadBombeoMin >= Range.velocidadUnidadBombeoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.velocidadUnidadBombeo)
            //                 .Replace("{1}", $"{Range.velocidadUnidadBombeoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.velocidadUnidadBombeoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.velocidadUnidadBombeo = false;
            //    }
            //}

            #endregion velocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //Range.frecuenciaOperacionBomba = frecuenciaOperacionBomba.Checked;
            //Range.frecuenciaOperacionBombaMin = Convert.ToDecimal(frecuenciaOperacionBombaMin.Text);
            //Range.frecuenciaOperacionBombaMax = Convert.ToDecimal(frecuenciaOperacionBombaMax.Text);

            //if (Range.frecuenciaOperacionBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.frecuenciaOperacionBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.frecuenciaOperacionBombaMin >= Range.frecuenciaOperacionBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.frecuenciaOperacionBomba)
            //                 .Replace("{1}", $"{Range.frecuenciaOperacionBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.frecuenciaOperacionBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.frecuenciaOperacionBomba = false;
            //    }
            //}

            #endregion frecuenciaOperacionBomba

            #region velocidadMotor

            //Range.velocidadMotor = velocidadMotor.Checked;
            //Range.velocidadMotorMin = Convert.ToDecimal(velocidadMotorMin.Text);
            //Range.velocidadMotorMax = Convert.ToDecimal(velocidadMotorMax.Text);

            //if (Range.velocidadMotor)
            //{
            //    string msn = string.Empty;
            //    if (Range.velocidadMotorMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.velocidadMotorMin >= Range.velocidadMotorMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.velocidadMotor)
            //                 .Replace("{1}", $"{Range.velocidadMotorMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.velocidadMotorMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.velocidadMotor = false;
            //    }
            //}

            #endregion velocidadMotor

            #region longitudCarrera

            //Range.longitudCarrera = longitudCarrera.Checked;
            //Range.longitudCarreraMin = Convert.ToDecimal(longitudCarreraMin.Text);
            //Range.longitudCarreraMax = Convert.ToDecimal(longitudCarreraMax.Text);

            //if (Range.longitudCarrera)
            //{
            //    string msn = string.Empty;
            //    if (Range.longitudCarreraMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.longitudCarreraMin >= Range.longitudCarreraMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.longitudCarrera)
            //                 .Replace("{1}", $"{Range.longitudCarreraMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.longitudCarreraMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.longitudCarrera = false;
            //    }
            //}

            #endregion longitudCarrera

            #region presionDisponible

            //Range.presionDisponible = presionDisponible.Checked;
            //Range.presionDisponibleMin = Convert.ToDecimal(presionDisponibleMin.Text);
            //Range.presionDisponibleMax = Convert.ToDecimal(presionDisponibleMax.Text);

            //if (Range.presionDisponible)
            //{
            //    string msn = string.Empty;
            //    if (Range.presionDisponibleMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.presionDisponibleMin >= Range.presionDisponibleMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.presionDisponible)
            //                 .Replace("{1}", $"{Range.presionDisponibleMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.presionDisponibleMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.presionDisponible = false;
            //    }
            //}

            #endregion presionDisponible

            #region gastoInyeccionFluidoPotencia

            //Range.gastoInyeccionFluidoPotencia = gastoInyeccionFluidoPotencia.Checked;
            //Range.gastoInyeccionFluidoPotenciaMin = Convert.ToDecimal(gastoInyeccionFluidoPotenciaMin.Text);
            //Range.gastoInyeccionFluidoPotenciaMax = Convert.ToDecimal(gastoInyeccionFluidoPotenciaMax.Text);

            //if (Range.gastoInyeccionFluidoPotencia)
            //{
            //    string msn = string.Empty;
            //    if (Range.gastoInyeccionFluidoPotenciaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.gastoInyeccionFluidoPotenciaMin >= Range.gastoInyeccionFluidoPotenciaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.gastoInyeccionFluidoPotencia)
            //                 .Replace("{1}", $"{Range.gastoInyeccionFluidoPotenciaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.gastoInyeccionFluidoPotenciaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.gastoInyeccionFluidoPotencia = false;
            //    }
            //}

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //Range.gravedadEspecificaFluidoPotencia = gravedadEspecificaFluidoPotencia.Checked;
            //Range.gravedadEspecificaFluidoPotenciaMin = Convert.ToDecimal(gravedadEspecificaFluidoPotenciaMin.Text);
            //Range.gravedadEspecificaFluidoPotenciaMax = Convert.ToDecimal(gravedadEspecificaFluidoPotenciaMax.Text);

            //if (Range.gravedadEspecificaFluidoPotencia)
            //{
            //    string msn = string.Empty;
            //    if (Range.gravedadEspecificaFluidoPotenciaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.gravedadEspecificaFluidoPotenciaMin >= Range.gravedadEspecificaFluidoPotenciaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.gravedadEspecificaFluidoPotencia)
            //                 .Replace("{1}", $"{Range.gravedadEspecificaFluidoPotenciaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.gravedadEspecificaFluidoPotenciaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.gravedadEspecificaFluidoPotencia = false;
            //    }
            //}

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //Range.gastoGasInyeccion = gastoGasInyeccion.Checked;
            //Range.gastoGasInyeccionMin = Convert.ToDecimal(gastoGasInyeccionMin.Text);
            //Range.gastoGasInyeccionMax = Convert.ToDecimal(gastoGasInyeccionMax.Text);

            //if (Range.gastoGasInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.gastoGasInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.gastoGasInyeccionMin >= Range.gastoGasInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.gastoGasInyeccion)
            //                 .Replace("{1}", $"{Range.gastoGasInyeccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.gastoGasInyeccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.gastoGasInyeccion = false;
            //    }
            //}

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //Range.gravedadEspecificaGasInyeccion = gravedadEspecificaGasInyeccion.Checked;
            //Range.gravedadEspecificaGasInyeccionMin = Convert.ToDecimal(gravedadEspecificaGasInyeccionMin.Text);
            //Range.gravedadEspecificaGasInyeccionMax = Convert.ToDecimal(gravedadEspecificaGasInyeccionMax.Text);

            //if (Range.gravedadEspecificaGasInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.gravedadEspecificaGasInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.gravedadEspecificaGasInyeccionMin >= Range.gravedadEspecificaGasInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.gravedadEspecificaGasInyeccion)
            //                 .Replace("{1}", $"{Range.gravedadEspecificaGasInyeccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.gravedadEspecificaGasInyeccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.gravedadEspecificaGasInyeccion = false;
            //    }
            //}

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //Range.torque = torque.Checked;
            //Range.torqueMin = Convert.ToDecimal(torqueMin.Text);
            //Range.torqueMax = Convert.ToDecimal(torqueMax.Text);

            //if (Range.torque)
            //{
            //    string msn = string.Empty;
            //    if (Range.torqueMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.torqueMin >= Range.torqueMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.torque)
            //                 .Replace("{1}", $"{Range.torqueMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.torqueMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.torque = false;
            //    }
            //}

            #endregion torque

            #region corriente

            //Range.corriente = corriente.Checked;
            //Range.corrienteMin = Convert.ToDecimal(corrienteMin.Text);
            //Range.corrienteMax = Convert.ToDecimal(corrienteMax.Text);

            //if (Range.corriente)
            //{
            //    string msn = string.Empty;
            //    if (Range.corrienteMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.corrienteMin >= Range.corrienteMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.corriente)
            //                 .Replace("{1}", $"{Range.corrienteMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.corrienteMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.corriente = false;
            //    }
            //}

            #endregion corriente

            #region diametroEstrangulador

            //Range.diametroEstrangulador = diametroEstrangulador.Checked;
            //Range.diametroEstranguladorMin = Convert.ToDecimal(diametroEstranguladorMin.Text);
            //Range.diametroEstranguladorMax = Convert.ToDecimal(diametroEstranguladorMax.Text);

            //if (Range.diametroEstrangulador)
            //{
            //    string msn = string.Empty;
            //    if (Range.diametroEstranguladorMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.diametroEstranguladorMin >= Range.diametroEstranguladorMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.diametroEstrangulador)
            //                 .Replace("{1}", $"{Range.diametroEstranguladorMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.diametroEstranguladorMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.diametroEstrangulador = false;
            //    }
            //}

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //Range.tiempoCiclo = tiempoCiclo.Checked;
            //Range.tiempoCicloMin = Convert.ToDecimal(tiempoCicloMin.Text);
            //Range.tiempoCicloMax = Convert.ToDecimal(tiempoCicloMax.Text);

            //if (Range.tiempoCiclo)
            //{
            //    string msn = string.Empty;
            //    if (Range.tiempoCicloMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.tiempoCicloMin >= Range.tiempoCicloMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoCiclo)
            //                 .Replace("{1}", $"{Range.tiempoCicloMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.tiempoCicloMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.tiempoCiclo = false;
            //    }
            //}

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //Range.tiempoRecuperacion = tiempoRecuperacion.Checked;
            //Range.tiempoRecuperacionMin = Convert.ToDecimal(tiempoRecuperacionMin.Text);
            //Range.tiempoRecuperacionMax = Convert.ToDecimal(tiempoRecuperacionMax.Text);

            //if (Range.tiempoRecuperacion)
            //{
            //    string msn = string.Empty;
            //    if (Range.tiempoRecuperacionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.tiempoRecuperacionMin >= Range.tiempoRecuperacionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoRecuperacion)
            //                 .Replace("{1}", $"{Range.tiempoRecuperacionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.tiempoRecuperacionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.tiempoRecuperacion = false;
            //    }
            //}

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //Range.tiempoInyeccion = tiempoInyeccion.Checked;
            //Range.tiempoInyeccionMin = Convert.ToDecimal(tiempoInyeccionMin.Text);
            //Range.tiempoInyeccionMax = Convert.ToDecimal(tiempoInyeccionMax.Text);

            //if (Range.tiempoInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.tiempoInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.tiempoInyeccionMin >= Range.tiempoInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoInyeccion)
            //                 .Replace("{1}", $"{Range.tiempoInyeccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.tiempoInyeccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.tiempoInyeccion = false;
            //    }
            //}

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //Range.tiempoDesplazamientoTapon = tiempoDesplazamientoTapon.Checked;
            //Range.tiempoDesplazamientoTaponMin = Convert.ToDecimal(tiempoDesplazamientoTaponMin.Text);
            //Range.tiempoDesplazamientoTaponMax = Convert.ToDecimal(tiempoDesplazamientoTaponMax.Text);

            //if (Range.tiempoDesplazamientoTapon)
            //{
            //    string msn = string.Empty;
            //    if (Range.tiempoDesplazamientoTaponMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.tiempoDesplazamientoTaponMin >= Range.tiempoDesplazamientoTaponMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoDesplazamientoTapon)
            //                 .Replace("{1}", $"{Range.tiempoDesplazamientoTaponMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.tiempoDesplazamientoTaponMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.tiempoDesplazamientoTapon = false;
            //    }
            //}

            #endregion tiempoDesplazamientoTapon

            #region eficienciaLlenado

            //Range.eficienciaLlenado = eficienciaLlenado.Checked;
            //Range.eficienciaLlenadoMin = Convert.ToDecimal(eficienciaLlenadoMin.Text);
            //Range.eficienciaLlenadoMax = Convert.ToDecimal(eficienciaLlenadoMax.Text);

            //if (Range.eficienciaLlenado)
            //{
            //    string msn = string.Empty;
            //    if (Range.eficienciaLlenadoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.eficienciaLlenadoMin >= Range.eficienciaLlenadoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.eficienciaLlenado)
            //                 .Replace("{1}", $"{Range.eficienciaLlenadoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.eficienciaLlenadoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.eficienciaLlenado = false;
            //    }
            //}

            #endregion eficienciaLlenado

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

        private void TomaInformacion_Load(object sender, EventArgs e) => Recargar();
    }
}
