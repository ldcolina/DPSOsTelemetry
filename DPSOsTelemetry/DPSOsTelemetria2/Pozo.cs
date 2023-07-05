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

                if ((_Telemetria.Range.DatosOperativos.TotalSeconds != 0) && (_Telemetria.DatosOperativosTime <= DateTime.UtcNow))
                {
                    OTomaInformacion.CTomaBasica DatosOperativos = new OTomaInformacion.CTomaBasica();

                    #region Read

                    #region PresionTuberiaProduccion

                    if (_Telemetria.Range.PresionTuberiaProduccion)
                        DatosOperativos.PresionTuberiaProduccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionTuberiaProduccionMax - _Telemetria.Range.PresionTuberiaProduccionMin) + _Telemetria.Range.PresionTuberiaProduccionMin;

                    #endregion PresionTuberiaProduccion

                    #region PresionTuberiaRevestimiento

                    if (_Telemetria.Range.PresionTuberiaRevestimiento)
                        DatosOperativos.PresionTuberiaRevestimiento = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionTuberiaRevestimientoMax - _Telemetria.Range.PresionTuberiaRevestimientoMin) + _Telemetria.Range.PresionTuberiaRevestimientoMin;

                    #endregion PresionTuberiaRevestimiento

                    #region PresionAperturaCampo

                    if (_Telemetria.Range.PresionAperturaCampo)
                        DatosOperativos.PresionAperturaCampo = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionAperturaCampoMax - _Telemetria.Range.PresionAperturaCampoMin) + _Telemetria.Range.PresionAperturaCampoMin;

                    #endregion PresionAperturaCampo

                    #region PresionLineaDescarga

                    if (_Telemetria.Range.PresionLineaDescarga)
                        DatosOperativos.PresionLineaDescarga = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionLineaDescargaMax - _Telemetria.Range.PresionLineaDescargaMin) + _Telemetria.Range.PresionLineaDescargaMin;

                    #endregion PresionLineaDescarga

                    #region TemperaturaSuperficie

                    if (_Telemetria.Range.TemperaturaSuperficie)
                        DatosOperativos.TemperaturaSuperficie = (decimal)new Random().NextDouble() * (_Telemetria.Range.TemperaturaSuperficieMax - _Telemetria.Range.TemperaturaSuperficieMin) + _Telemetria.Range.TemperaturaSuperficieMin;

                    #endregion TemperaturaSuperficie

                    #region sumergenciaEfectivaBomba

                    if (_Telemetria.Range.SumergenciaEfectivaBomba)
                        DatosOperativos.SumergenciaEfectivaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.SumergenciaEfectivaBombaMax - _Telemetria.Range.SumergenciaEfectivaBombaMin) + _Telemetria.Range.SumergenciaEfectivaBombaMin;

                    #endregion sumergenciaEfectivaBomba

                    #region NivelFluidoPozoTp

                    if (_Telemetria.Range.NivelFluidoPozoTp)
                        DatosOperativos.NivelFluidoPozoTp = (decimal)new Random().NextDouble() * (_Telemetria.Range.NivelFluidoPozoTpMax - _Telemetria.Range.NivelFluidoPozoTpMin) + _Telemetria.Range.NivelFluidoPozoTpMin;

                    #endregion NivelFluidoPozoTp

                    #region NivelFluidoPozoTr

                    if (_Telemetria.Range.NivelFluidoPozoTr)
                        DatosOperativos.NivelFluidoPozoTr = (decimal)new Random().NextDouble() * (_Telemetria.Range.NivelFluidoPozoTrMax - _Telemetria.Range.NivelFluidoPozoTrMin) + _Telemetria.Range.NivelFluidoPozoTrMin;

                    #endregion NivelFluidoPozoTr

                    #region PresionEntradaBomba

                    if (_Telemetria.Range.PresionEntradaBomba)
                        DatosOperativos.PresionEntradaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionEntradaBombaMax - _Telemetria.Range.PresionEntradaBombaMin) + _Telemetria.Range.PresionEntradaBombaMin;

                    #endregion PresionEntradaBomba

                    #region VelocidadBomba

                    if (_Telemetria.Range.VelocidadBomba)
                        DatosOperativos.VelocidadBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.VelocidadBombaMax - _Telemetria.Range.VelocidadBombaMin) + _Telemetria.Range.VelocidadBombaMin;

                    #endregion VelocidadBomba

                    #region VelocidadUnidadBombeo

                    if (_Telemetria.Range.VelocidadUnidadBombeo)
                        DatosOperativos.VelocidadUnidadBombeo = (decimal)new Random().NextDouble() * (_Telemetria.Range.VelocidadUnidadBombeoMax - _Telemetria.Range.VelocidadUnidadBombeoMin) + _Telemetria.Range.VelocidadUnidadBombeoMin;

                    #endregion VelocidadUnidadBombeo

                    #region frecuenciaOperacionBomba

                    if (_Telemetria.Range.FrecuenciaOperacionBomba)
                        DatosOperativos.FrecuenciaOperacionBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.FrecuenciaOperacionBombaMax - _Telemetria.Range.FrecuenciaOperacionBombaMin) + _Telemetria.Range.FrecuenciaOperacionBombaMin;

                    #endregion frecuenciaOperacionBomba

                    #region VelocidadMotor

                    if (_Telemetria.Range.VelocidadMotor)
                        DatosOperativos.VelocidadMotor = (decimal)new Random().NextDouble() * (_Telemetria.Range.VelocidadMotorMax - _Telemetria.Range.VelocidadMotorMin) + _Telemetria.Range.VelocidadMotorMin;

                    #endregion VelocidadMotor

                    #region LongitudCarrera

                    if (_Telemetria.Range.LongitudCarrera)
                        DatosOperativos.LongitudCarrera = (decimal)new Random().NextDouble() * (_Telemetria.Range.LongitudCarreraMax - _Telemetria.Range.LongitudCarreraMin) + _Telemetria.Range.LongitudCarreraMin;

                    #endregion LongitudCarrera

                    #region PresionDisponible

                    if (_Telemetria.Range.PresionDisponible)
                        DatosOperativos.PresionDisponible = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionDisponibleMax - _Telemetria.Range.PresionDisponibleMin) + _Telemetria.Range.PresionDisponibleMin;

                    #endregion PresionDisponible

                    #region gastoInyeccionFluidoPotencia

                    if (_Telemetria.Range.GastoInyeccionFluidoPotencia)
                        DatosOperativos.GastoInyeccionFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoInyeccionFluidoPotenciaMax - _Telemetria.Range.GastoInyeccionFluidoPotenciaMin) + _Telemetria.Range.GastoInyeccionFluidoPotenciaMin;

                    #endregion gastoInyeccionFluidoPotencia

                    #region gravedadEspecificaFluidoPotencia

                    if (_Telemetria.Range.GravedadEspecificaFluidoPotencia)
                        DatosOperativos.GravedadEspecificaFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.GravedadEspecificaFluidoPotenciaMax - _Telemetria.Range.GravedadEspecificaFluidoPotenciaMin) + _Telemetria.Range.GravedadEspecificaFluidoPotenciaMin;

                    #endregion gravedadEspecificaFluidoPotencia

                    #region gastoGasInyeccion

                    if (_Telemetria.Range.GastoGasInyeccion)
                        DatosOperativos.GastoGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoGasInyeccionMax - _Telemetria.Range.GastoGasInyeccionMin) + _Telemetria.Range.GastoGasInyeccionMin;

                    #endregion gastoGasInyeccion

                    #region gravedadEspecificaGasInyeccion

                    if (_Telemetria.Range.GravedadEspecificaGasInyeccion)
                        DatosOperativos.GravedadEspecificaGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.GravedadEspecificaGasInyeccionMax - _Telemetria.Range.GravedadEspecificaGasInyeccionMin) + _Telemetria.Range.GravedadEspecificaGasInyeccionMin;

                    #endregion gravedadEspecificaGasInyeccion

                    #region torque

                    if (_Telemetria.Range.Torque)
                        DatosOperativos.Torque = (decimal)new Random().NextDouble() * (_Telemetria.Range.TorqueMax - _Telemetria.Range.TorqueMin) + _Telemetria.Range.TorqueMin;

                    #endregion torque

                    #region corriente

                    if (_Telemetria.Range.Corriente)
                        DatosOperativos.Corriente = (decimal)new Random().NextDouble() * (_Telemetria.Range.CorrienteMax - _Telemetria.Range.CorrienteMin) + _Telemetria.Range.CorrienteMin;

                    #endregion corriente

                    #region diametroEstrangulador

                    if (_Telemetria.Range.DiametroEstrangulador)
                        DatosOperativos.DiametroEstrangulador = (decimal)new Random().NextDouble() * (_Telemetria.Range.DiametroEstranguladorMax - _Telemetria.Range.DiametroEstranguladorMin) + _Telemetria.Range.DiametroEstranguladorMin;

                    #endregion diametroEstrangulador

                    #region tiempoCiclo

                    if (_Telemetria.Range.TiempoCiclo)
                        DatosOperativos.TiempoCiclo = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoCicloMax - _Telemetria.Range.TiempoCicloMin) + _Telemetria.Range.TiempoCicloMin;

                    #endregion tiempoCiclo

                    #region tiempoRecuperacion

                    if (_Telemetria.Range.TiempoRecuperacion)
                        DatosOperativos.TiempoRecuperacion = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoRecuperacionMax - _Telemetria.Range.TiempoRecuperacionMin) + _Telemetria.Range.TiempoRecuperacionMin;

                    #endregion tiempoRecuperacion

                    #region tiempoInyeccion

                    if (_Telemetria.Range.TiempoInyeccion)
                        DatosOperativos.TiempoInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoInyeccionMax - _Telemetria.Range.TiempoInyeccionMin) + _Telemetria.Range.TiempoInyeccionMin;

                    #endregion tiempoInyeccion

                    #region tiempoDesplazamientoTapon

                    if (_Telemetria.Range.TiempoDesplazamientoTapon)
                        DatosOperativos.TiempoDesplazamientoTapon = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoDesplazamientoTaponMax - _Telemetria.Range.TiempoDesplazamientoTaponMin) + _Telemetria.Range.TiempoDesplazamientoTaponMin;

                    #endregion tiempoDesplazamientoTapon

                    #region EficienciaLlenado

                    if (_Telemetria.Range.EficienciaLlenado)
                        DatosOperativos.EficienciaLlenado = (decimal)new Random().NextDouble() * (_Telemetria.Range.EficienciaLlenadoMax - _Telemetria.Range.EficienciaLlenadoMin) + _Telemetria.Range.EficienciaLlenadoMin;

                    #endregion EficienciaLlenado

                    #endregion Read

                    if (JsonConvert.SerializeObject(DatosOperativos) != JsonConvert.SerializeObject(new OTomaInformacion.CTomaBasica()))
                    {
                        _Telemetria.DatosOperativos = DatosOperativos;

                        _Telemetria = await TelemetriaController.Post(_Telemetria, true);
                    }
                    _Telemetria.DatosOperativosTime = _Telemetria.DatosOperativosTime.AddSeconds(_Telemetria.Range.DatosOperativos.TotalSeconds);
                }

                #endregion DatosOperativos

                #region CartaDinagrafica

                if ((_Telemetria.Range.CartaDinagrafica.TotalSeconds != 0) && (_Telemetria.CartaDinagraficaTime <= DateTime.UtcNow))
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

                    _Telemetria.CartaDinagraficaTime = _Telemetria.CartaDinagraficaTime.AddSeconds(_Telemetria.Range.CartaDinagrafica.TotalSeconds);
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
            _Telemetria.DatosOperativosTime = _Telemetria.Started;
            _Telemetria.CartaDinagraficaTime = _Telemetria.Started;

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
