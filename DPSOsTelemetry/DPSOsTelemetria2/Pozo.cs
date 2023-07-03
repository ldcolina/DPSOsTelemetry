using DPSOsTelemetria2.Properties;
using Languages;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2
{
    public partial class Pozo : Form
    {
        public ReferenciasI _Telemetria = new ReferenciasI();

        public ReferenciasII Referencias = new ReferenciasII();

        public string select;

        public bool status;

        private static readonly ResourceManager SystemWell = new ResourceManager(typeof(SystemWell));

        public Pozo()
        {
            InitializeComponent();
        }

        public Pozo(ReferenciasII _referencias) : this()
        {
            Referencias = _referencias;
            Refrescar();
        }

        internal static int Decimales => Main.Decimales;

        public void Refrescar()
        {
            switch (select)
            {
                case "1": //InformationGathering
                    {
                        Text = $"{Referencias.Name} ({SystemWell.GetString(Referencias.Type)}) - {General.InformationGathering}";
                        lblOnOff.Text = DPSOsTelemetria.Off;

                        RefrescarInformationGathering();
                        break;
                    }
                case "2": //VirtualMonitoring
                    {
                        Text = $"{Referencias.Name} ({SystemWell.GetString(Referencias.Type)}) - {General.VirtualMonitoring}";
                        lblOnOff.Text = DPSOsTelemetria.On;

                        RefrescarVirtualMonitoring();
                        break;
                    }
            }
        }

        #region Toma de información

        internal void Guardar_Info()
        {
            if (select == "1") //InformationGathering
            {
                switch (Referencias.Type)
                {
                    case "FL":
                        {
                            Pozos.PozoBombeoFluyente.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoFluyente.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }

                    case "FLG":
                        {
                            Pozos.PozoBombeoFluyenteGas.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoFluyenteGas.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }

                    case "BN":
                        {
                            Pozos.PozoBombeoNeumatico.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoNeumatico.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }

                    case "BNI":
                        {
                            Pozos.PozoBombeoNeumaticoIntermitente.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoNeumaticoIntermitente.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }

                    case "BM":
                        {
                            Pozos.PozoBombeoMecanico.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoMecanico.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }

                    case "BCP":
                        {
                            Pozos.PozoBombeoCavidadProgresiva.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoCavidadProgresiva.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }

                    case "BEC":
                        {
                            Pozos.PozoBombeoElectroCentrifugo.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoElectroCentrifugo.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }

                    case "BJP":
                        {
                            Pozos.PozoBombeoJetPump.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoJetPump.TomaInformacion>().FirstOrDefault();
                            Referencias.Range = TomaInformacion.SaveTomaInformacion();

                            break;
                        }
                }

                string newDatas = JsonConvert.SerializeObject(Referencias.Copy<ReferenciasII, Referencias>(), Formatting.Indented);

                if (newDatas != File.ReadAllText(Referencias.ID))
                    File.WriteAllText(Referencias.ID, newDatas);
            }
        }

        private void InformationGathering()
        {
            lblOnOff.Text = DPSOsTelemetria.Off;
            pictureBox1.Image = Resources.off_button;

            panel2.Controls.Clear();

            switch (Referencias.Type)
            {
                case "FL":
                    {
                        Pozos.PozoBombeoFluyente.TomaInformacion TomaInformacion = new Pozos.PozoBombeoFluyente.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.TomaInformacion TomaInformacion = new Pozos.PozoBombeoFluyenteGas.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.TomaInformacion TomaInformacion = new Pozos.PozoBombeoNeumatico.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.TomaInformacion TomaInformacion = new Pozos.PozoBombeoNeumaticoIntermitente.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.TomaInformacion TomaInformacion = new Pozos.PozoBombeoMecanico.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.TomaInformacion TomaInformacion = new Pozos.PozoBombeoCavidadProgresiva.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.TomaInformacion TomaInformacion = new Pozos.PozoBombeoElectroCentrifugo.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.TomaInformacion TomaInformacion = new Pozos.PozoBombeoJetPump.TomaInformacion(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }
            }

            select = "1";
        }

        private void RefrescarInformationGathering()
        {
            switch (Referencias.Type)
            {
                case "FL":
                    {
                        Pozos.PozoBombeoFluyente.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoFluyente.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoFluyenteGas.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoNeumatico.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoNeumaticoIntermitente.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoMecanico.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoCavidadProgresiva.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoElectroCentrifugo.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.TomaInformacion TomaInformacion = panel2.Controls.OfType<Pozos.PozoBombeoJetPump.TomaInformacion>().FirstOrDefault();
                        TomaInformacion.Recargar();
                        break;
                    }
            }
        }

        #endregion Toma de información

        #region Monitoreo virtual

        public async void SendTelemetria()
        {
            status = false;

            _Telemetria = await Telemetria();

            status = true;
        }

        internal async Task<ReferenciasI> Telemetria()
        {
            return await Task.Run(async () =>
            {
                #region DatosOperativos

                DateTime time1 = _Telemetria.Started.AddMilliseconds(_Telemetria.Range.DatosOperativos.TotalMilliseconds * _Telemetria.DatosOperativosSends);
                if ((_Telemetria.Range.DatosOperativos.TotalMilliseconds != 0) & (time1 <= DateTime.UtcNow))
                {
                    OTomaInformacion.CTomaBasica DatosOperativos = new OTomaInformacion.CTomaBasica();

                    #region Read

                    #region presionTuberiaProduccion

                    if (_Telemetria.Range.presionTuberiaProduccion)
                        DatosOperativos.presionTuberiaProduccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.presionTuberiaProduccionMax - _Telemetria.Range.presionTuberiaProduccionMin) + _Telemetria.Range.presionTuberiaProduccionMin;

                    #endregion presionTuberiaProduccion

                    #region presionTuberiaRevestimiento

                    if (_Telemetria.Range.presionTuberiaRevestimiento)
                        DatosOperativos.presionTuberiaRevestimiento = (decimal)new Random().NextDouble() * (_Telemetria.Range.presionTuberiaRevestimientoMax - _Telemetria.Range.presionTuberiaRevestimientoMin) + _Telemetria.Range.presionTuberiaRevestimientoMin;

                    #endregion presionTuberiaRevestimiento

                    #region presionAperturaCampo

                    if (_Telemetria.Range.presionAperturaCampo)
                        DatosOperativos.presionAperturaCampo = (decimal)new Random().NextDouble() * (_Telemetria.Range.presionAperturaCampoMax - _Telemetria.Range.presionAperturaCampoMin) + _Telemetria.Range.presionAperturaCampoMin;

                    #endregion presionAperturaCampo

                    #region presionLineaDescarga

                    if (_Telemetria.Range.presionLineaDescarga)
                        DatosOperativos.presionLineaDescarga = (decimal)new Random().NextDouble() * (_Telemetria.Range.presionLineaDescargaMax - _Telemetria.Range.presionLineaDescargaMin) + _Telemetria.Range.presionLineaDescargaMin;

                    #endregion presionLineaDescarga

                    #region temperaturaSuperficie

                    if (_Telemetria.Range.temperaturaSuperficie)
                        DatosOperativos.temperaturaSuperficie = (decimal)new Random().NextDouble() * (_Telemetria.Range.temperaturaSuperficieMax - _Telemetria.Range.temperaturaSuperficieMin) + _Telemetria.Range.temperaturaSuperficieMin;

                    #endregion temperaturaSuperficie

                    #region sumergenciaEfectivaBomba

                    if (_Telemetria.Range.sumergenciaEfectivaBomba)
                        DatosOperativos.sumergenciaEfectivaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.sumergenciaEfectivaBombaMax - _Telemetria.Range.sumergenciaEfectivaBombaMin) + _Telemetria.Range.sumergenciaEfectivaBombaMin;

                    #endregion sumergenciaEfectivaBomba

                    #region nivelFluidoPozoTp

                    if (_Telemetria.Range.nivelFluidoPozoTp)
                        DatosOperativos.nivelFluidoPozoTp = (decimal)new Random().NextDouble() * (_Telemetria.Range.nivelFluidoPozoTpMax - _Telemetria.Range.nivelFluidoPozoTpMin) + _Telemetria.Range.nivelFluidoPozoTpMin;

                    #endregion nivelFluidoPozoTp

                    #region nivelFluidoPozoTr

                    if (_Telemetria.Range.nivelFluidoPozoTr)
                        DatosOperativos.nivelFluidoPozoTr = (decimal)new Random().NextDouble() * (_Telemetria.Range.nivelFluidoPozoTrMax - _Telemetria.Range.nivelFluidoPozoTrMin) + _Telemetria.Range.nivelFluidoPozoTrMin;

                    #endregion nivelFluidoPozoTr

                    #region presionEntradaBomba

                    if (_Telemetria.Range.presionEntradaBomba)
                        DatosOperativos.presionEntradaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.presionEntradaBombaMax - _Telemetria.Range.presionEntradaBombaMin) + _Telemetria.Range.presionEntradaBombaMin;

                    #endregion presionEntradaBomba

                    #region velocidadBomba

                    if (_Telemetria.Range.velocidadBomba)
                        DatosOperativos.velocidadBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.velocidadBombaMax - _Telemetria.Range.velocidadBombaMin) + _Telemetria.Range.velocidadBombaMin;

                    #endregion velocidadBomba

                    #region velocidadUnidadBombeo

                    if (_Telemetria.Range.velocidadUnidadBombeo)
                        DatosOperativos.velocidadUnidadBombeo = (decimal)new Random().NextDouble() * (_Telemetria.Range.velocidadUnidadBombeoMax - _Telemetria.Range.velocidadUnidadBombeoMin) + _Telemetria.Range.velocidadUnidadBombeoMin;

                    #endregion velocidadUnidadBombeo

                    #region frecuenciaOperacionBomba

                    if (_Telemetria.Range.frecuenciaOperacionBomba)
                        DatosOperativos.frecuenciaOperacionBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.frecuenciaOperacionBombaMax - _Telemetria.Range.frecuenciaOperacionBombaMin) + _Telemetria.Range.frecuenciaOperacionBombaMin;

                    #endregion frecuenciaOperacionBomba

                    #region velocidadMotor

                    if (_Telemetria.Range.velocidadMotor)
                        DatosOperativos.velocidadMotor = (decimal)new Random().NextDouble() * (_Telemetria.Range.velocidadMotorMax - _Telemetria.Range.velocidadMotorMin) + _Telemetria.Range.velocidadMotorMin;

                    #endregion velocidadMotor

                    #region longitudCarrera

                    if (_Telemetria.Range.longitudCarrera)
                        DatosOperativos.longitudCarrera = (decimal)new Random().NextDouble() * (_Telemetria.Range.longitudCarreraMax - _Telemetria.Range.longitudCarreraMin) + _Telemetria.Range.longitudCarreraMin;

                    #endregion longitudCarrera

                    #region presionDisponible

                    if (_Telemetria.Range.presionDisponible)
                        DatosOperativos.presionDisponible = (decimal)new Random().NextDouble() * (_Telemetria.Range.presionDisponibleMax - _Telemetria.Range.presionDisponibleMin) + _Telemetria.Range.presionDisponibleMin;

                    #endregion presionDisponible

                    #region gastoInyeccionFluidoPotencia

                    if (_Telemetria.Range.gastoInyeccionFluidoPotencia)
                        DatosOperativos.gastoInyeccionFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.gastoInyeccionFluidoPotenciaMax - _Telemetria.Range.gastoInyeccionFluidoPotenciaMin) + _Telemetria.Range.gastoInyeccionFluidoPotenciaMin;

                    #endregion gastoInyeccionFluidoPotencia

                    #region gravedadEspecificaFluidoPotencia

                    if (_Telemetria.Range.gravedadEspecificaFluidoPotencia)
                        DatosOperativos.gravedadEspecificaFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.gravedadEspecificaFluidoPotenciaMax - _Telemetria.Range.gravedadEspecificaFluidoPotenciaMin) + _Telemetria.Range.gravedadEspecificaFluidoPotenciaMin;

                    #endregion gravedadEspecificaFluidoPotencia

                    #region gastoGasInyeccion

                    if (_Telemetria.Range.gastoGasInyeccion)
                        DatosOperativos.gastoGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.gastoGasInyeccionMax - _Telemetria.Range.gastoGasInyeccionMin) + _Telemetria.Range.gastoGasInyeccionMin;

                    #endregion gastoGasInyeccion

                    #region gravedadEspecificaGasInyeccion

                    if (_Telemetria.Range.gravedadEspecificaGasInyeccion)
                        DatosOperativos.gravedadEspecificaGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.gravedadEspecificaGasInyeccionMax - _Telemetria.Range.gravedadEspecificaGasInyeccionMin) + _Telemetria.Range.gravedadEspecificaGasInyeccionMin;

                    #endregion gravedadEspecificaGasInyeccion

                    #region torque

                    if (_Telemetria.Range.torque)
                        DatosOperativos.torque = (decimal)new Random().NextDouble() * (_Telemetria.Range.torqueMax - _Telemetria.Range.torqueMin) + _Telemetria.Range.torqueMin;

                    #endregion torque

                    #region corriente

                    if (_Telemetria.Range.corriente)
                        DatosOperativos.corriente = (decimal)new Random().NextDouble() * (_Telemetria.Range.corrienteMax - _Telemetria.Range.corrienteMin) + _Telemetria.Range.corrienteMin;

                    #endregion corriente

                    #region diametroEstrangulador

                    if (_Telemetria.Range.diametroEstrangulador)
                        DatosOperativos.diametroEstrangulador = (decimal)new Random().NextDouble() * (_Telemetria.Range.diametroEstranguladorMax - _Telemetria.Range.diametroEstranguladorMin) + _Telemetria.Range.diametroEstranguladorMin;

                    #endregion diametroEstrangulador

                    #region tiempoCiclo

                    if (_Telemetria.Range.tiempoCiclo)
                        DatosOperativos.tiempoCiclo = (decimal)new Random().NextDouble() * (_Telemetria.Range.tiempoCicloMax - _Telemetria.Range.tiempoCicloMin) + _Telemetria.Range.tiempoCicloMin;

                    #endregion tiempoCiclo

                    #region tiempoRecuperacion

                    if (_Telemetria.Range.tiempoRecuperacion)
                        DatosOperativos.tiempoRecuperacion = (decimal)new Random().NextDouble() * (_Telemetria.Range.tiempoRecuperacionMax - _Telemetria.Range.tiempoRecuperacionMin) + _Telemetria.Range.tiempoRecuperacionMin;

                    #endregion tiempoRecuperacion

                    #region tiempoInyeccion

                    if (_Telemetria.Range.tiempoInyeccion)
                        DatosOperativos.tiempoInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.tiempoInyeccionMax - _Telemetria.Range.tiempoInyeccionMin) + _Telemetria.Range.tiempoInyeccionMin;

                    #endregion tiempoInyeccion

                    #region tiempoDesplazamientoTapon

                    if (_Telemetria.Range.tiempoDesplazamientoTapon)
                        DatosOperativos.tiempoDesplazamientoTapon = (decimal)new Random().NextDouble() * (_Telemetria.Range.tiempoDesplazamientoTaponMax - _Telemetria.Range.tiempoDesplazamientoTaponMin) + _Telemetria.Range.tiempoDesplazamientoTaponMin;

                    #endregion tiempoDesplazamientoTapon

                    #region eficienciaLlenado

                    if (_Telemetria.Range.eficienciaLlenado)
                        DatosOperativos.eficienciaLlenado = (decimal)new Random().NextDouble() * (_Telemetria.Range.eficienciaLlenadoMax - _Telemetria.Range.eficienciaLlenadoMin) + _Telemetria.Range.eficienciaLlenadoMin;

                    #endregion eficienciaLlenado

                    #endregion Read

                    if (JsonConvert.SerializeObject(DatosOperativos) != JsonConvert.SerializeObject(new OTomaInformacion.CTomaBasica()))
                    {
                        _Telemetria.DatosOperativos = DatosOperativos;

                        _Telemetria = await TelemetriaController.Post(_Telemetria, true);
                    }
                }

                #endregion DatosOperativos

                #region CartaDinagrafica

                DateTime time2 = _Telemetria.Started.AddMilliseconds(_Telemetria.Range.CartaDinagrafica.TotalMilliseconds * _Telemetria.DatosOperativosSends);
                if ((_Telemetria.Range.CartaDinagrafica.TotalMilliseconds != 0) & (time1 <= DateTime.UtcNow))
                {
                    OCartaDinagrafica.CCartaDinagrafica CCartaDinagrafica = new OCartaDinagrafica.CCartaDinagrafica();

                    #region Read

                    if (_Telemetria.Range.CCartaDinagrafica)
                    {
                        int index = new Random().Next(0, _Telemetria.Range.ListCCartaDinagrafica.Count);
                        CCartaDinagrafica = _Telemetria.Range.ListCCartaDinagrafica[index];
                    }

                    #endregion Read

                    if (JsonConvert.SerializeObject(CCartaDinagrafica) != JsonConvert.SerializeObject(new OCartaDinagrafica.CCartaDinagrafica()))
                    {
                        _Telemetria.CartaDinagrafica = CCartaDinagrafica;

                        _Telemetria = await TelemetriaController.Post(_Telemetria, false);
                    }
                }

                #endregion CartaDinagrafica

                return _Telemetria;
            });
        }

        private void RefrescarVirtualMonitoring()
        {
            switch (Referencias.Type)
            {
                case "FL":
                    {
                        Pozos.PozoBombeoFluyente.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoFluyente.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoNeumatico.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoMecanico.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoJetPump.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }
            }
        }

        private void VirtualMonitoring()
        {
            lblOnOff.Text = DPSOsTelemetria.On;
            pictureBox1.Image = Resources.on_button;

            _Telemetria = Referencias.Copy<ReferenciasII, ReferenciasI>();
            _Telemetria.Started = DateTime.UtcNow;

            panel2.Controls.Clear();
            switch (Referencias.Type)
            {
                case "FL":
                    {
                        Pozos.PozoBombeoFluyente.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoFluyente.MonitoreoVirtual() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoNeumatico.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoMecanico.MonitoreoVirtual() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoJetPump.MonitoreoVirtual() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }
            }

            SendTelemetria();
            select = "2";
        }

        #endregion Monitoreo virtual

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (select)
            {
                case "1": //InformationGathering
                    {
                        Guardar_Info();

                        if (Referencias.Range.DatosOperativos == TimeSpan.Zero && Referencias.Range.CartaDinagrafica == TimeSpan.Zero)
                            return;

                        VirtualMonitoring();
                        break;
                    }
                case "2": //VirtualMonitoring
                    {
                        InformationGathering();
                        break;
                    }
            }
        }

        private void Pozo_FormClosing(object sender, FormClosingEventArgs e) => Guardar_Info();

        private void Pozo_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Size = MdiParent.ClientSize;
                Location = new Point(0, 0);
            }
        }

        private void Pozo_Load(object sender, EventArgs e)
        {
            Text = $"{Referencias.Name} ({SystemWell.GetString(Referencias.Type)}) - {General.InformationGathering}";
            InformationGathering();
        }
    }
}
