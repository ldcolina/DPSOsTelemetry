using System;
using System.Linq;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria.Pozos.PozoBombeoCavidadProgresiva
{
    public partial class TomaInformacion : UserControl
    {
        private readonly ReferenciasII Referencias;
        int decimales = 0;

        public TomaInformacion()
        {
            InitializeComponent();
        }

        public TomaInformacion(int _decimales, ReferenciasII referencias) : this()
        {
            decimales = _decimales;
            Referencias = referencias;

            #region DatosOperativos

            #region PresionTuberiaProduccion

            //PresionTuberiaProduccion.Checked = referencias.Range.PresionTuberiaProduccion;
            //PresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaProduccionMin.ToString(), decimales);
            //PresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaProduccionMax.ToString(), decimales);

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            //PresionTuberiaRevestimiento.Checked = referencias.Range.PresionTuberiaRevestimiento;
            //PresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaRevestimientoMin.ToString(), decimales);
            //PresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionTuberiaRevestimientoMax.ToString(), decimales);

            #endregion PresionTuberiaRevestimiento

            #region PresionAperturaCampo

            //PresionAperturaCampo.Checked = referencias.Range.PresionAperturaCampo;
            //PresionAperturaCampoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionAperturaCampoMin.ToString(), decimales);
            //PresionAperturaCampoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionAperturaCampoMax.ToString(), decimales);

            #endregion PresionAperturaCampo

            #region PresionLineaDescarga

            //PresionLineaDescarga.Checked = referencias.Range.PresionLineaDescarga;
            //PresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionLineaDescargaMin.ToString(), decimales);
            //PresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionLineaDescargaMax.ToString(), decimales);

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            //TemperaturaSuperficie.Checked = referencias.Range.TemperaturaSuperficie;
            //TemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(referencias.Range.TemperaturaSuperficieMin.ToString(), decimales);
            //TemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(referencias.Range.TemperaturaSuperficieMax.ToString(), decimales);

            #endregion TemperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //sumergenciaEfectivaBomba.Checked = referencias.Range.SumergenciaEfectivaBomba;
            //sumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.SumergenciaEfectivaBombaMin.ToString(), decimales);
            //sumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.SumergenciaEfectivaBombaMax.ToString(), decimales);

            #endregion sumergenciaEfectivaBomba

            #region NivelFluidoPozoTp

            //NivelFluidoPozoTp.Checked = referencias.Range.NivelFluidoPozoTp;
            //NivelFluidoPozoTpMin.Text = Condicionantes.Wrote_Formating(referencias.Range.NivelFluidoPozoTpMin.ToString(), decimales);
            //NivelFluidoPozoTpMax.Text = Condicionantes.Wrote_Formating(referencias.Range.NivelFluidoPozoTpMax.ToString(), decimales);

            #endregion NivelFluidoPozoTp

            #region NivelFluidoPozoTr

            //NivelFluidoPozoTr.Checked = referencias.Range.NivelFluidoPozoTr;
            //NivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(referencias.Range.NivelFluidoPozoTrMin.ToString(), decimales);
            //NivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(referencias.Range.NivelFluidoPozoTrMax.ToString(), decimales);

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            //PresionEntradaBomba.Checked = referencias.Range.PresionEntradaBomba;
            //PresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionEntradaBombaMin.ToString(), decimales);
            //PresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionEntradaBombaMax.ToString(), decimales);

            #endregion PresionEntradaBomba

            #region VelocidadBomba

            //VelocidadBomba.Checked = referencias.Range.VelocidadBomba;
            //VelocidadBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadBombaMin.ToString(), decimales);
            //VelocidadBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadBombaMax.ToString(), decimales);

            #endregion VelocidadBomba

            #region VelocidadUnidadBombeo

            //VelocidadUnidadBombeo.Checked = referencias.Range.VelocidadUnidadBombeo;
            //VelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadUnidadBombeoMin.ToString(), decimales);
            //VelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadUnidadBombeoMax.ToString(), decimales);

            #endregion VelocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //frecuenciaOperacionBomba.Checked = referencias.Range.FrecuenciaOperacionBomba;
            //frecuenciaOperacionBombaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.FrecuenciaOperacionBombaMin.ToString(), decimales);
            //frecuenciaOperacionBombaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.FrecuenciaOperacionBombaMax.ToString(), decimales);

            #endregion frecuenciaOperacionBomba

            #region VelocidadMotor

            //VelocidadMotor.Checked = referencias.Range.VelocidadMotor;
            //VelocidadMotorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadMotorMin.ToString(), decimales);
            //VelocidadMotorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.VelocidadMotorMax.ToString(), decimales);

            #endregion VelocidadMotor

            #region LongitudCarrera

            //LongitudCarrera.Checked = referencias.Range.LongitudCarrera;
            //LongitudCarreraMin.Text = Condicionantes.Wrote_Formating(referencias.Range.LongitudCarreraMin.ToString(), decimales);
            //LongitudCarreraMax.Text = Condicionantes.Wrote_Formating(referencias.Range.LongitudCarreraMax.ToString(), decimales);

            #endregion LongitudCarrera

            #region PresionDisponible

            //PresionDisponible.Checked = referencias.Range.PresionDisponible;
            //PresionDisponibleMin.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionDisponibleMin.ToString(), decimales);
            //PresionDisponibleMax.Text = Condicionantes.Wrote_Formating(referencias.Range.PresionDisponibleMax.ToString(), decimales);

            #endregion PresionDisponible

            #region gastoInyeccionFluidoPotencia

            //gastoInyeccionFluidoPotencia.Checked = referencias.Range.GastoInyeccionFluidoPotencia;
            //gastoInyeccionFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoInyeccionFluidoPotenciaMin.ToString(), decimales);
            //gastoInyeccionFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoInyeccionFluidoPotenciaMax.ToString(), decimales);

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //gravedadEspecificaFluidoPotencia.Checked = referencias.Range.GravedadEspecificaFluidoPotencia;
            //gravedadEspecificaFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaFluidoPotenciaMin.ToString(), decimales);
            //gravedadEspecificaFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaFluidoPotenciaMax.ToString(), decimales);

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //gastoGasInyeccion.Checked = referencias.Range.GastoGasInyeccion;
            //gastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoGasInyeccionMin.ToString(), decimales);
            //gastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GastoGasInyeccionMax.ToString(), decimales);

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //gravedadEspecificaGasInyeccion.Checked = referencias.Range.GravedadEspecificaGasInyeccion;
            //gravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaGasInyeccionMin.ToString(), decimales);
            //gravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.GravedadEspecificaGasInyeccionMax.ToString(), decimales);

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //torque.Checked = referencias.Range.Torque;
            //torqueMin.Text = Condicionantes.Wrote_Formating(referencias.Range.TorqueMin.ToString(), decimales);
            //torqueMax.Text = Condicionantes.Wrote_Formating(referencias.Range.TorqueMax.ToString(), decimales);

            #endregion torque

            #region corriente

            //corriente.Checked = referencias.Range.Corriente;
            //corrienteMin.Text = Condicionantes.Wrote_Formating(referencias.Range.CorrienteMin.ToString(), decimales);
            //corrienteMax.Text = Condicionantes.Wrote_Formating(referencias.Range.CorrienteMax.ToString(), decimales);

            #endregion corriente

            #region diametroEstrangulador

            //diametroEstrangulador.Checked = referencias.Range.DiametroEstrangulador;
            //diametroEstranguladorMin.Text = Condicionantes.Wrote_Formating(referencias.Range.DiametroEstranguladorMin.ToString(), decimales);
            //diametroEstranguladorMax.Text = Condicionantes.Wrote_Formating(referencias.Range.DiametroEstranguladorMax.ToString(), decimales);

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //tiempoCiclo.Checked = referencias.Range.TiempoCiclo;
            //tiempoCicloMin.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoCicloMin.ToString(), decimales);
            //tiempoCicloMax.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoCicloMax.ToString(), decimales);

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //tiempoRecuperacion.Checked = referencias.Range.TiempoRecuperacion;
            //tiempoRecuperacionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoRecuperacionMin.ToString(), decimales);
            //tiempoRecuperacionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoRecuperacionMax.ToString(), decimales);

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //tiempoInyeccion.Checked = referencias.Range.TiempoInyeccion;
            //tiempoInyeccionMin.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoInyeccionMin.ToString(), decimales);
            //tiempoInyeccionMax.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoInyeccionMax.ToString(), decimales);

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //tiempoDesplazamientoTapon.Checked = referencias.Range.TiempoDesplazamientoTapon;
            //tiempoDesplazamientoTaponMin.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoDesplazamientoTaponMin.ToString(), decimales);
            //tiempoDesplazamientoTaponMax.Text = Condicionantes.Wrote_Formating(referencias.Range.TiempoDesplazamientoTaponMax.ToString(), decimales);

            #endregion tiempoDesplazamientoTapon

            #region EficienciaLlenado

            //EficienciaLlenado.Checked = referencias.Range.EficienciaLlenado;
            //EficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(referencias.Range.EficienciaLlenadoMin.ToString(), decimales);
            //EficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(referencias.Range.EficienciaLlenadoMax.ToString(), decimales);

            #endregion EficienciaLlenado

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
        }

        internal void Recargar(int _decimales)
        {
            decimales = _decimales;

            #region DatosOperativos

            #region PresionTuberiaProduccion

            //PresionTuberiaProduccion.Text = $"{Languages.Pozo.PresionTuberiaProduccion} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //PresionTuberiaProduccionMin.Text = Condicionantes.Wrote_Formating(PresionTuberiaProduccionMin.Text,decimales);
            //PresionTuberiaProduccionMax.Text = Condicionantes.Wrote_Formating(PresionTuberiaProduccionMax.Text,decimales);

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            //PresionTuberiaRevestimiento.Text = $"{Languages.Pozo.PresionTuberiaRevestimiento} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //PresionTuberiaRevestimientoMin.Text = Condicionantes.Wrote_Formating(PresionTuberiaRevestimientoMin.Text,decimales);
            //PresionTuberiaRevestimientoMax.Text = Condicionantes.Wrote_Formating(PresionTuberiaRevestimientoMax.Text,decimales);

            #endregion PresionTuberiaRevestimiento

            #region PresionAperturaCampo

            //PresionAperturaCampo.Text = $"{Languages.Pozo.PresionAperturaCampo} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //PresionAperturaCampoMin.Text = Condicionantes.Wrote_Formating(PresionAperturaCampoMin.Text,decimales);
            //PresionAperturaCampoMax.Text = Condicionantes.Wrote_Formating(PresionAperturaCampoMax.Text,decimales);

            #endregion PresionAperturaCampo

            #region PresionLineaDescarga

            //PresionLineaDescarga.Text = $"{Languages.Pozo.PresionLineaDescarga} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //PresionLineaDescargaMin.Text = Condicionantes.Wrote_Formating(PresionLineaDescargaMin.Text,decimales);
            //PresionLineaDescargaMax.Text = Condicionantes.Wrote_Formating(PresionLineaDescargaMax.Text,decimales);

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            //TemperaturaSuperficie.Text = $"{Languages.Pozo.TemperaturaSuperficie} ({ Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)})";
            //TemperaturaSuperficieMin.Text = Condicionantes.Wrote_Formating(TemperaturaSuperficieMin.Text,decimales);
            //TemperaturaSuperficieMax.Text = Condicionantes.Wrote_Formating(TemperaturaSuperficieMax.Text,decimales);

            #endregion TemperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //sumergenciaEfectivaBomba.Text = $"{Languages.Pozo.sumergenciaEfectivaBomba} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //sumergenciaEfectivaBombaMin.Text = Condicionantes.Wrote_Formating(sumergenciaEfectivaBombaMin.Text,decimales);
            //sumergenciaEfectivaBombaMax.Text = Condicionantes.Wrote_Formating(sumergenciaEfectivaBombaMax.Text,decimales);

            #endregion sumergenciaEfectivaBomba

            #region NivelFluidoPozoTp

            //NivelFluidoPozoTp.Text = $"{Languages.Pozo.NivelFluidoPozoTp} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //NivelFluidoPozoTpMin.Text = Condicionantes.Wrote_Formating(NivelFluidoPozoTpMin.Text,decimales);
            //NivelFluidoPozoTpMax.Text = Condicionantes.Wrote_Formating(NivelFluidoPozoTpMax.Text,decimales);

            #endregion NivelFluidoPozoTp

            #region NivelFluidoPozoTr

            //NivelFluidoPozoTr.Text = $"{Languages.Pozo.NivelFluidoPozoTr} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //NivelFluidoPozoTrMin.Text = Condicionantes.Wrote_Formating(NivelFluidoPozoTrMin.Text,decimales);
            //NivelFluidoPozoTrMax.Text = Condicionantes.Wrote_Formating(NivelFluidoPozoTrMax.Text,decimales);

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            //PresionEntradaBomba.Text = $"{Languages.Pozo.PresionEntradaBomba} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //PresionEntradaBombaMin.Text = Condicionantes.Wrote_Formating(PresionEntradaBombaMin.Text,decimales);
            //PresionEntradaBombaMax.Text = Condicionantes.Wrote_Formating(PresionEntradaBombaMax.Text,decimales);

            #endregion PresionEntradaBomba

            #region VelocidadBomba

            //VelocidadBomba.Text = $"{Languages.Pozo.VelocidadBomba} ({ Configuracion.GetSigla(Referencia.Velocidad, Referencias.Unidades)})";
            //VelocidadBombaMin.Text = Condicionantes.Wrote_Formating(VelocidadBombaMin.Text,decimales);
            //VelocidadBombaMax.Text = Condicionantes.Wrote_Formating(VelocidadBombaMax.Text,decimales);

            #endregion VelocidadBomba

            #region VelocidadUnidadBombeo

            //VelocidadUnidadBombeo.Text = $"{Languages.Pozo.VelocidadUnidadBombeo} ({ Configuracion.GetSigla(Referencia.Embolada, Referencias.Unidades)})";
            //VelocidadUnidadBombeoMin.Text = Condicionantes.Wrote_Formating(VelocidadUnidadBombeoMin.Text,decimales);
            //VelocidadUnidadBombeoMax.Text = Condicionantes.Wrote_Formating(VelocidadUnidadBombeoMax.Text,decimales);

            #endregion VelocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //frecuenciaOperacionBomba.Text = $"{Languages.Pozo.frecuenciaOperacionBomba} ({ Configuracion.GetSigla(Referencia.Frecuencia, Referencias.Unidades)})";
            //frecuenciaOperacionBombaMin.Text = Condicionantes.Wrote_Formating(frecuenciaOperacionBombaMin.Text,decimales);
            //frecuenciaOperacionBombaMax.Text = Condicionantes.Wrote_Formating(frecuenciaOperacionBombaMax.Text,decimales);

            #endregion frecuenciaOperacionBomba

            #region VelocidadMotor

            //VelocidadMotor.Text = $"{Languages.Pozo.VelocidadMotor} ({ Configuracion.GetSigla(Referencia.Velocidad, Referencias.Unidades)})";
            //VelocidadMotorMin.Text = Condicionantes.Wrote_Formating(VelocidadMotorMin.Text,decimales);
            //VelocidadMotorMax.Text = Condicionantes.Wrote_Formating(VelocidadMotorMax.Text,decimales);

            #endregion VelocidadMotor

            #region LongitudCarrera

            //LongitudCarrera.Text = $"{Languages.Pozo.LongitudCarrera} ({ Configuracion.GetSigla(Referencia.Distancia, Referencias.Unidades)})";
            //LongitudCarreraMin.Text = Condicionantes.Wrote_Formating(LongitudCarreraMin.Text,decimales);
            //LongitudCarreraMax.Text = Condicionantes.Wrote_Formating(LongitudCarreraMax.Text,decimales);

            #endregion LongitudCarrera

            #region PresionDisponible

            //PresionDisponible.Text = $"{Languages.Pozo.PresionDisponible} ({ Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)})";
            //PresionDisponibleMin.Text = Condicionantes.Wrote_Formating(PresionDisponibleMin.Text,decimales);
            //PresionDisponibleMax.Text = Condicionantes.Wrote_Formating(PresionDisponibleMax.Text,decimales);

            #endregion PresionDisponible

            #region gastoInyeccionFluidoPotencia

            //gastoInyeccionFluidoPotencia.Text = $"{Languages.Pozo.GastoInyeccionFluidoPotencia} ({ Configuracion.GetSigla(Referencia.GastoGas, Referencias.Unidades)})";
            //gastoInyeccionFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(gastoInyeccionFluidoPotenciaMin.Text,decimales);
            //gastoInyeccionFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(gastoInyeccionFluidoPotenciaMax.Text,decimales);

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //gravedadEspecificaFluidoPotencia.Text = $"{Languages.Pozo.GravedadEspecificaFluidoPotencia} (-)";
            //gravedadEspecificaFluidoPotenciaMin.Text = Condicionantes.Wrote_Formating(gravedadEspecificaFluidoPotenciaMin.Text,decimales);
            //gravedadEspecificaFluidoPotenciaMax.Text = Condicionantes.Wrote_Formating(gravedadEspecificaFluidoPotenciaMax.Text,decimales);

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //gastoGasInyeccion.Text = $"{Languages.Pozo.GastoGasInyeccion} ({ Configuracion.GetSigla(Referencia.GastoGas, Referencias.Unidades)})";
            //gastoGasInyeccionMin.Text = Condicionantes.Wrote_Formating(gastoGasInyeccionMin.Text,decimales);
            //gastoGasInyeccionMax.Text = Condicionantes.Wrote_Formating(gastoGasInyeccionMax.Text,decimales);

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //gravedadEspecificaGasInyeccion.Text = $"{Languages.Pozo.GravedadEspecificaGasInyeccion} (-)";
            //gravedadEspecificaGasInyeccionMin.Text = Condicionantes.Wrote_Formating(gravedadEspecificaGasInyeccionMin.Text,decimales);
            //gravedadEspecificaGasInyeccionMax.Text = Condicionantes.Wrote_Formating(gravedadEspecificaGasInyeccionMax.Text,decimales);

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //torque.Text = $"{Languages.Pozo.torque} ({ Configuracion.GetSigla(Referencia.Torque, Referencias.Unidades)})";
            //torqueMin.Text = Condicionantes.Wrote_Formating(torqueMin.Text,decimales);
            //torqueMax.Text = Condicionantes.Wrote_Formating(torqueMax.Text,decimales);

            #endregion torque

            #region corriente

            //corriente.Text = $"{Languages.Pozo.corriente} ({ Configuracion.GetSigla(Referencia.Corriente, Referencias.Unidades)})";
            //corrienteMin.Text = Condicionantes.Wrote_Formating(corrienteMin.Text,decimales);
            //corrienteMax.Text = Condicionantes.Wrote_Formating(corrienteMax.Text,decimales);

            #endregion corriente

            #region diametroEstrangulador

            //diametroEstrangulador.Text = $"{Languages.Pozo.diametroEstrangulador} ({ Configuracion.GetSigla(Referencia.Diametro, Referencias.Unidades)})";
            //diametroEstranguladorMin.Text = Condicionantes.Wrote_Formating(diametroEstranguladorMin.Text,decimales);
            //diametroEstranguladorMax.Text = Condicionantes.Wrote_Formating(diametroEstranguladorMax.Text,decimales);

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //tiempoCiclo.Text = $"{Languages.Pozo.tiempoCiclo} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoCicloMin.Text = Condicionantes.Wrote_Formating(tiempoCicloMin.Text,decimales);
            //tiempoCicloMax.Text = Condicionantes.Wrote_Formating(tiempoCicloMax.Text,decimales);

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //tiempoRecuperacion.Text = $"{Languages.Pozo.tiempoRecuperacion} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoRecuperacionMin.Text = Condicionantes.Wrote_Formating(tiempoRecuperacionMin.Text,decimales);
            //tiempoRecuperacionMax.Text = Condicionantes.Wrote_Formating(tiempoRecuperacionMax.Text,decimales);

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //tiempoInyeccion.Text = $"{Languages.Pozo.tiempoInyeccion} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoInyeccionMin.Text = Condicionantes.Wrote_Formating(tiempoInyeccionMin.Text,decimales);
            //tiempoInyeccionMax.Text = Condicionantes.Wrote_Formating(tiempoInyeccionMax.Text,decimales);

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //tiempoDesplazamientoTapon.Text = $"{Languages.Pozo.tiempoDesplazamientoTapon} ({ Configuracion.GetSigla(Referencia.Segundo, Referencias.Unidades)})";
            //tiempoDesplazamientoTaponMin.Text = Condicionantes.Wrote_Formating(tiempoDesplazamientoTaponMin.Text,decimales);
            //tiempoDesplazamientoTaponMax.Text = Condicionantes.Wrote_Formating(tiempoDesplazamientoTaponMax.Text,decimales);

            #endregion tiempoDesplazamientoTapon

            #region EficienciaLlenado

            //EficienciaLlenado.Text = $"{Languages.Pozo.EficienciaLlenado} ({ Configuracion.GetSigla(Referencia.Porcentaje, Referencias.Unidades)})";
            //EficienciaLlenadoMin.Text = Condicionantes.Wrote_Formating(EficienciaLlenadoMin.Text,decimales);
            //EficienciaLlenadoMax.Text = Condicionantes.Wrote_Formating(EficienciaLlenadoMax.Text,decimales);

            #endregion EficienciaLlenado

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

            #region PresionTuberiaProduccion

            //Range.PresionTuberiaProduccion = PresionTuberiaProduccion.Checked;
            //Range.PresionTuberiaProduccionMin = Convert.ToDecimal(PresionTuberiaProduccionMin.Text);
            //Range.PresionTuberiaProduccionMax = Convert.ToDecimal(PresionTuberiaProduccionMax.Text);

            //if (Range.PresionTuberiaProduccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.PresionTuberiaProduccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.PresionTuberiaProduccionMin >= Range.PresionTuberiaProduccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.PresionTuberiaProduccion)
            //                 .Replace("{1}", $"{Range.PresionTuberiaProduccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.PresionTuberiaProduccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.PresionTuberiaProduccion = false;
            //    }
            //}

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            //Range.PresionTuberiaRevestimiento = PresionTuberiaRevestimiento.Checked;
            //Range.PresionTuberiaRevestimientoMin = Convert.ToDecimal(PresionTuberiaRevestimientoMin.Text);
            //Range.PresionTuberiaRevestimientoMax = Convert.ToDecimal(PresionTuberiaRevestimientoMax.Text);

            //if (Range.PresionTuberiaRevestimiento)
            //{
            //    string msn = string.Empty;
            //    if (Range.PresionTuberiaRevestimientoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.PresionTuberiaRevestimientoMin >= Range.PresionTuberiaRevestimientoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.PresionTuberiaRevestimiento)
            //                 .Replace("{1}", $"{Range.PresionTuberiaRevestimientoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.PresionTuberiaRevestimientoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.PresionTuberiaRevestimiento = false;
            //    }
            //}

            #endregion PresionTuberiaRevestimiento

            #region PresionAperturaCampo

            //Range.PresionAperturaCampo = PresionAperturaCampo.Checked;
            //Range.PresionAperturaCampoMin = Convert.ToDecimal(PresionAperturaCampoMin.Text);
            //Range.PresionAperturaCampoMax = Convert.ToDecimal(PresionAperturaCampoMax.Text);

            //if (Range.PresionAperturaCampo)
            //{
            //    string msn = string.Empty;
            //    if (Range.PresionAperturaCampoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.PresionAperturaCampoMin >= Range.PresionAperturaCampoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.PresionAperturaCampo)
            //                 .Replace("{1}", $"{Range.PresionAperturaCampoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.PresionAperturaCampoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.PresionAperturaCampo = false;
            //    }
            //}

            #endregion PresionAperturaCampo

            #region PresionLineaDescarga

            //Range.PresionLineaDescarga = PresionLineaDescarga.Checked;
            //Range.PresionLineaDescargaMin = Convert.ToDecimal(PresionLineaDescargaMin.Text);
            //Range.PresionLineaDescargaMax = Convert.ToDecimal(PresionLineaDescargaMax.Text);

            //if (Range.PresionLineaDescarga)
            //{
            //    string msn = string.Empty;
            //    if (Range.PresionLineaDescargaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.PresionLineaDescargaMin >= Range.PresionLineaDescargaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.PresionLineaDescarga)
            //                 .Replace("{1}", $"{Range.PresionLineaDescargaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.PresionLineaDescargaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.PresionLineaDescarga = false;
            //    }
            //}

            #endregion PresionLineaDescarga

            #region TemperaturaSuperficie

            //Range.TemperaturaSuperficie = TemperaturaSuperficie.Checked;
            //Range.TemperaturaSuperficieMin = Convert.ToDecimal(TemperaturaSuperficieMin.Text);
            //Range.TemperaturaSuperficieMax = Convert.ToDecimal(TemperaturaSuperficieMax.Text);

            //if (Range.TemperaturaSuperficie)
            //{
            //    string msn = string.Empty;
            //    if (Range.TemperaturaSuperficieMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.TemperaturaSuperficieMin >= Range.TemperaturaSuperficieMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.TemperaturaSuperficie)
            //                 .Replace("{1}", $"{Range.TemperaturaSuperficieMin} { Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.TemperaturaSuperficieMax} { Configuracion.GetSigla(Referencia.Temperatura, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.TemperaturaSuperficie = false;
            //    }
            //}

            #endregion TemperaturaSuperficie

            #region sumergenciaEfectivaBomba

            //Range.SumergenciaEfectivaBomba = sumergenciaEfectivaBomba.Checked;
            //Range.SumergenciaEfectivaBombaMin = Convert.ToDecimal(sumergenciaEfectivaBombaMin.Text);
            //Range.SumergenciaEfectivaBombaMax = Convert.ToDecimal(sumergenciaEfectivaBombaMax.Text);

            //if (Range.SumergenciaEfectivaBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.SumergenciaEfectivaBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.SumergenciaEfectivaBombaMin >= Range.SumergenciaEfectivaBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.sumergenciaEfectivaBomba)
            //                 .Replace("{1}", $"{Range.SumergenciaEfectivaBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.SumergenciaEfectivaBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.SumergenciaEfectivaBomba = false;
            //    }
            //}

            #endregion sumergenciaEfectivaBomba

            #region NivelFluidoPozoTp

            //Range.NivelFluidoPozoTp = NivelFluidoPozoTp.Checked;
            //Range.NivelFluidoPozoTpMin = Convert.ToDecimal(NivelFluidoPozoTpMin.Text);
            //Range.NivelFluidoPozoTpMax = Convert.ToDecimal(NivelFluidoPozoTpMax.Text);

            //if (Range.NivelFluidoPozoTp)
            //{
            //    string msn = string.Empty;
            //    if (Range.NivelFluidoPozoTpMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.NivelFluidoPozoTpMin >= Range.NivelFluidoPozoTpMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.NivelFluidoPozoTp)
            //                 .Replace("{1}", $"{Range.NivelFluidoPozoTpMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.NivelFluidoPozoTpMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.NivelFluidoPozoTp = false;
            //    }
            //}

            #endregion NivelFluidoPozoTp

            #region NivelFluidoPozoTr

            //Range.NivelFluidoPozoTr = NivelFluidoPozoTr.Checked;
            //Range.NivelFluidoPozoTrMin = Convert.ToDecimal(NivelFluidoPozoTrMin.Text);
            //Range.NivelFluidoPozoTrMax = Convert.ToDecimal(NivelFluidoPozoTrMax.Text);

            //if (Range.NivelFluidoPozoTr)
            //{
            //    string msn = string.Empty;
            //    if (Range.NivelFluidoPozoTrMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.NivelFluidoPozoTrMin >= Range.NivelFluidoPozoTrMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.NivelFluidoPozoTr)
            //                 .Replace("{1}", $"{Range.NivelFluidoPozoTrMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.NivelFluidoPozoTrMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.NivelFluidoPozoTr = false;
            //    }
            //}

            #endregion NivelFluidoPozoTr

            #region PresionEntradaBomba

            //Range.PresionEntradaBomba = PresionEntradaBomba.Checked;
            //Range.PresionEntradaBombaMin = Convert.ToDecimal(PresionEntradaBombaMin.Text);
            //Range.PresionEntradaBombaMax = Convert.ToDecimal(PresionEntradaBombaMax.Text);

            //if (Range.PresionEntradaBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.PresionEntradaBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.PresionEntradaBombaMin >= Range.PresionEntradaBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.PresionEntradaBomba)
            //                 .Replace("{1}", $"{Range.PresionEntradaBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.PresionEntradaBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.PresionEntradaBomba = false;
            //    }
            //}

            #endregion PresionEntradaBomba

            #region VelocidadBomba

            //Range.VelocidadBomba = VelocidadBomba.Checked;
            //Range.VelocidadBombaMin = Convert.ToDecimal(VelocidadBombaMin.Text);
            //Range.VelocidadBombaMax = Convert.ToDecimal(VelocidadBombaMax.Text);

            //if (Range.VelocidadBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.VelocidadBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.VelocidadBombaMin >= Range.VelocidadBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.VelocidadBomba)
            //                 .Replace("{1}", $"{Range.VelocidadBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.VelocidadBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.VelocidadBomba = false;
            //    }
            //}

            #endregion VelocidadBomba

            #region VelocidadUnidadBombeo

            //Range.VelocidadUnidadBombeo = VelocidadUnidadBombeo.Checked;
            //Range.VelocidadUnidadBombeoMin = Convert.ToDecimal(VelocidadUnidadBombeoMin.Text);
            //Range.VelocidadUnidadBombeoMax = Convert.ToDecimal(VelocidadUnidadBombeoMax.Text);

            //if (Range.VelocidadUnidadBombeo)
            //{
            //    string msn = string.Empty;
            //    if (Range.VelocidadUnidadBombeoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.VelocidadUnidadBombeoMin >= Range.VelocidadUnidadBombeoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.VelocidadUnidadBombeo)
            //                 .Replace("{1}", $"{Range.VelocidadUnidadBombeoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.VelocidadUnidadBombeoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.VelocidadUnidadBombeo = false;
            //    }
            //}

            #endregion VelocidadUnidadBombeo

            #region frecuenciaOperacionBomba

            //Range.FrecuenciaOperacionBomba = frecuenciaOperacionBomba.Checked;
            //Range.FrecuenciaOperacionBombaMin = Convert.ToDecimal(frecuenciaOperacionBombaMin.Text);
            //Range.FrecuenciaOperacionBombaMax = Convert.ToDecimal(frecuenciaOperacionBombaMax.Text);

            //if (Range.FrecuenciaOperacionBomba)
            //{
            //    string msn = string.Empty;
            //    if (Range.FrecuenciaOperacionBombaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.FrecuenciaOperacionBombaMin >= Range.FrecuenciaOperacionBombaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.frecuenciaOperacionBomba)
            //                 .Replace("{1}", $"{Range.FrecuenciaOperacionBombaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.FrecuenciaOperacionBombaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.FrecuenciaOperacionBomba = false;
            //    }
            //}

            #endregion frecuenciaOperacionBomba

            #region VelocidadMotor

            //Range.VelocidadMotor = VelocidadMotor.Checked;
            //Range.VelocidadMotorMin = Convert.ToDecimal(VelocidadMotorMin.Text);
            //Range.VelocidadMotorMax = Convert.ToDecimal(VelocidadMotorMax.Text);

            //if (Range.VelocidadMotor)
            //{
            //    string msn = string.Empty;
            //    if (Range.VelocidadMotorMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.VelocidadMotorMin >= Range.VelocidadMotorMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.VelocidadMotor)
            //                 .Replace("{1}", $"{Range.VelocidadMotorMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.VelocidadMotorMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.VelocidadMotor = false;
            //    }
            //}

            #endregion VelocidadMotor

            #region LongitudCarrera

            //Range.LongitudCarrera = LongitudCarrera.Checked;
            //Range.LongitudCarreraMin = Convert.ToDecimal(LongitudCarreraMin.Text);
            //Range.LongitudCarreraMax = Convert.ToDecimal(LongitudCarreraMax.Text);

            //if (Range.LongitudCarrera)
            //{
            //    string msn = string.Empty;
            //    if (Range.LongitudCarreraMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.LongitudCarreraMin >= Range.LongitudCarreraMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.LongitudCarrera)
            //                 .Replace("{1}", $"{Range.LongitudCarreraMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.LongitudCarreraMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.LongitudCarrera = false;
            //    }
            //}

            #endregion LongitudCarrera

            #region PresionDisponible

            //Range.PresionDisponible = PresionDisponible.Checked;
            //Range.PresionDisponibleMin = Convert.ToDecimal(PresionDisponibleMin.Text);
            //Range.PresionDisponibleMax = Convert.ToDecimal(PresionDisponibleMax.Text);

            //if (Range.PresionDisponible)
            //{
            //    string msn = string.Empty;
            //    if (Range.PresionDisponibleMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.PresionDisponibleMin >= Range.PresionDisponibleMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.PresionDisponible)
            //                 .Replace("{1}", $"{Range.PresionDisponibleMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.PresionDisponibleMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.PresionDisponible = false;
            //    }
            //}

            #endregion PresionDisponible

            #region gastoInyeccionFluidoPotencia

            //Range.GastoInyeccionFluidoPotencia = gastoInyeccionFluidoPotencia.Checked;
            //Range.GastoInyeccionFluidoPotenciaMin = Convert.ToDecimal(gastoInyeccionFluidoPotenciaMin.Text);
            //Range.GastoInyeccionFluidoPotenciaMax = Convert.ToDecimal(gastoInyeccionFluidoPotenciaMax.Text);

            //if (Range.GastoInyeccionFluidoPotencia)
            //{
            //    string msn = string.Empty;
            //    if (Range.GastoInyeccionFluidoPotenciaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.GastoInyeccionFluidoPotenciaMin >= Range.GastoInyeccionFluidoPotenciaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.GastoInyeccionFluidoPotencia)
            //                 .Replace("{1}", $"{Range.GastoInyeccionFluidoPotenciaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.GastoInyeccionFluidoPotenciaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.GastoInyeccionFluidoPotencia = false;
            //    }
            //}

            #endregion gastoInyeccionFluidoPotencia

            #region gravedadEspecificaFluidoPotencia

            //Range.GravedadEspecificaFluidoPotencia = gravedadEspecificaFluidoPotencia.Checked;
            //Range.GravedadEspecificaFluidoPotenciaMin = Convert.ToDecimal(gravedadEspecificaFluidoPotenciaMin.Text);
            //Range.GravedadEspecificaFluidoPotenciaMax = Convert.ToDecimal(gravedadEspecificaFluidoPotenciaMax.Text);

            //if (Range.GravedadEspecificaFluidoPotencia)
            //{
            //    string msn = string.Empty;
            //    if (Range.GravedadEspecificaFluidoPotenciaMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.GravedadEspecificaFluidoPotenciaMin >= Range.GravedadEspecificaFluidoPotenciaMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.GravedadEspecificaFluidoPotencia)
            //                 .Replace("{1}", $"{Range.GravedadEspecificaFluidoPotenciaMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.GravedadEspecificaFluidoPotenciaMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.GravedadEspecificaFluidoPotencia = false;
            //    }
            //}

            #endregion gravedadEspecificaFluidoPotencia

            #region gastoGasInyeccion

            //Range.GastoGasInyeccion = gastoGasInyeccion.Checked;
            //Range.GastoGasInyeccionMin = Convert.ToDecimal(gastoGasInyeccionMin.Text);
            //Range.GastoGasInyeccionMax = Convert.ToDecimal(gastoGasInyeccionMax.Text);

            //if (Range.GastoGasInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.GastoGasInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.GastoGasInyeccionMin >= Range.GastoGasInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.GastoGasInyeccion)
            //                 .Replace("{1}", $"{Range.GastoGasInyeccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.GastoGasInyeccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.GastoGasInyeccion = false;
            //    }
            //}

            #endregion gastoGasInyeccion

            #region gravedadEspecificaGasInyeccion

            //Range.GravedadEspecificaGasInyeccion = gravedadEspecificaGasInyeccion.Checked;
            //Range.GravedadEspecificaGasInyeccionMin = Convert.ToDecimal(gravedadEspecificaGasInyeccionMin.Text);
            //Range.GravedadEspecificaGasInyeccionMax = Convert.ToDecimal(gravedadEspecificaGasInyeccionMax.Text);

            //if (Range.GravedadEspecificaGasInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.GravedadEspecificaGasInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.GravedadEspecificaGasInyeccionMin >= Range.GravedadEspecificaGasInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.GravedadEspecificaGasInyeccion)
            //                 .Replace("{1}", $"{Range.GravedadEspecificaGasInyeccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.GravedadEspecificaGasInyeccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.GravedadEspecificaGasInyeccion = false;
            //    }
            //}

            #endregion gravedadEspecificaGasInyeccion

            #region torque

            //Range.Torque = torque.Checked;
            //Range.TorqueMin = Convert.ToDecimal(torqueMin.Text);
            //Range.TorqueMax = Convert.ToDecimal(torqueMax.Text);

            //if (Range.Torque)
            //{
            //    string msn = string.Empty;
            //    if (Range.TorqueMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.TorqueMin >= Range.TorqueMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.torque)
            //                 .Replace("{1}", $"{Range.TorqueMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.TorqueMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.Torque = false;
            //    }
            //}

            #endregion torque

            #region corriente

            //Range.Corriente = corriente.Checked;
            //Range.CorrienteMin = Convert.ToDecimal(corrienteMin.Text);
            //Range.CorrienteMax = Convert.ToDecimal(corrienteMax.Text);

            //if (Range.Corriente)
            //{
            //    string msn = string.Empty;
            //    if (Range.CorrienteMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.CorrienteMin >= Range.CorrienteMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.corriente)
            //                 .Replace("{1}", $"{Range.CorrienteMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.CorrienteMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.Corriente = false;
            //    }
            //}

            #endregion corriente

            #region diametroEstrangulador

            //Range.DiametroEstrangulador = diametroEstrangulador.Checked;
            //Range.DiametroEstranguladorMin = Convert.ToDecimal(diametroEstranguladorMin.Text);
            //Range.DiametroEstranguladorMax = Convert.ToDecimal(diametroEstranguladorMax.Text);

            //if (Range.DiametroEstrangulador)
            //{
            //    string msn = string.Empty;
            //    if (Range.DiametroEstranguladorMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.DiametroEstranguladorMin >= Range.DiametroEstranguladorMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.diametroEstrangulador)
            //                 .Replace("{1}", $"{Range.DiametroEstranguladorMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.DiametroEstranguladorMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.DiametroEstrangulador = false;
            //    }
            //}

            #endregion diametroEstrangulador

            #region tiempoCiclo

            //Range.TiempoCiclo = tiempoCiclo.Checked;
            //Range.TiempoCicloMin = Convert.ToDecimal(tiempoCicloMin.Text);
            //Range.TiempoCicloMax = Convert.ToDecimal(tiempoCicloMax.Text);

            //if (Range.TiempoCiclo)
            //{
            //    string msn = string.Empty;
            //    if (Range.TiempoCicloMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.TiempoCicloMin >= Range.TiempoCicloMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoCiclo)
            //                 .Replace("{1}", $"{Range.TiempoCicloMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.TiempoCicloMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.TiempoCiclo = false;
            //    }
            //}

            #endregion tiempoCiclo

            #region tiempoRecuperacion

            //Range.TiempoRecuperacion = tiempoRecuperacion.Checked;
            //Range.TiempoRecuperacionMin = Convert.ToDecimal(tiempoRecuperacionMin.Text);
            //Range.TiempoRecuperacionMax = Convert.ToDecimal(tiempoRecuperacionMax.Text);

            //if (Range.TiempoRecuperacion)
            //{
            //    string msn = string.Empty;
            //    if (Range.TiempoRecuperacionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.TiempoRecuperacionMin >= Range.TiempoRecuperacionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoRecuperacion)
            //                 .Replace("{1}", $"{Range.TiempoRecuperacionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.TiempoRecuperacionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.TiempoRecuperacion = false;
            //    }
            //}

            #endregion tiempoRecuperacion

            #region tiempoInyeccion

            //Range.TiempoInyeccion = tiempoInyeccion.Checked;
            //Range.TiempoInyeccionMin = Convert.ToDecimal(tiempoInyeccionMin.Text);
            //Range.TiempoInyeccionMax = Convert.ToDecimal(tiempoInyeccionMax.Text);

            //if (Range.TiempoInyeccion)
            //{
            //    string msn = string.Empty;
            //    if (Range.TiempoInyeccionMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.TiempoInyeccionMin >= Range.TiempoInyeccionMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoInyeccion)
            //                 .Replace("{1}", $"{Range.TiempoInyeccionMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.TiempoInyeccionMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.TiempoInyeccion = false;
            //    }
            //}

            #endregion tiempoInyeccion

            #region tiempoDesplazamientoTapon

            //Range.TiempoDesplazamientoTapon = tiempoDesplazamientoTapon.Checked;
            //Range.TiempoDesplazamientoTaponMin = Convert.ToDecimal(tiempoDesplazamientoTaponMin.Text);
            //Range.TiempoDesplazamientoTaponMax = Convert.ToDecimal(tiempoDesplazamientoTaponMax.Text);

            //if (Range.TiempoDesplazamientoTapon)
            //{
            //    string msn = string.Empty;
            //    if (Range.TiempoDesplazamientoTaponMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.TiempoDesplazamientoTaponMin >= Range.TiempoDesplazamientoTaponMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.tiempoDesplazamientoTapon)
            //                 .Replace("{1}", $"{Range.TiempoDesplazamientoTaponMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.TiempoDesplazamientoTaponMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.TiempoDesplazamientoTapon = false;
            //    }
            //}

            #endregion tiempoDesplazamientoTapon

            #region EficienciaLlenado

            //Range.EficienciaLlenado = EficienciaLlenado.Checked;
            //Range.EficienciaLlenadoMin = Convert.ToDecimal(EficienciaLlenadoMin.Text);
            //Range.EficienciaLlenadoMax = Convert.ToDecimal(EficienciaLlenadoMax.Text);

            //if (Range.EficienciaLlenado)
            //{
            //    string msn = string.Empty;
            //    if (Range.EficienciaLlenadoMin < 0)
            //    {
            //        msn = Languages.Pozo.GreaterThan;
            //    }
            //    if (Range.EficienciaLlenadoMin >= Range.EficienciaLlenadoMax)
            //    {
            //        msn = Languages.Pozo.GreaterThanValue;
            //    }

            //    if (!string.IsNullOrEmpty(msn))
            //    {
            //        msn = msn.Replace("{0}", Languages.Pozo.EficienciaLlenado)
            //                 .Replace("{1}", $"{Range.EficienciaLlenadoMin} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}")
            //                 .Replace("{2}", $"{Range.EficienciaLlenadoMax} { Configuracion.GetSigla(Referencia.Presion, Referencias.Unidades)}");
            //        MessageBox.Show(msn, Languages.Pozo.Aviso, MessageBoxButtons.OK);
            //        Range.EficienciaLlenado = false;
            //    }
            //}

            #endregion EficienciaLlenado

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

        private void Wrote_Leave(object sender, EventArgs e) => ((TextBox)sender).Text = Condicionantes.Wrote_Formating(((TextBox)sender).Text, decimales);

        private void TomaInformacion_Load(object sender, EventArgs e) => Recargar(decimales);
    }
}