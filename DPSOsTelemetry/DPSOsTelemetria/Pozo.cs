using Languages;
using Newtonsoft.Json;
using System.Resources;
using Telemetria;

namespace DPSOsTelemetria
{
    public partial class Pozo : Form
    {
        public ReferenciasI _Telemetria = new();
        public ReferenciasII Referencias = new();
        public string select;
        public bool status;
        private static readonly ResourceManager SystemWell = new(typeof(Languages.SystemWell));

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
                        lblOnOff.Text = Languages.DPSOsTelemetria.Off;

                        RefrescarInformationGathering();
                        break;
                    }
                case "2": //VirtualMonitoring
                    {
                        Text = $"{Referencias.Name} ({SystemWell.GetString(Referencias.Type)}) - {General.VirtualMonitoring}";
                        lblOnOff.Text = Languages.DPSOsTelemetria.On;

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
            lblOnOff.Text = Languages.DPSOsTelemetria.Off;
            pictureBox1.Image = Resources.off_button1;

            panel2.Controls.Clear();

            switch (Referencias.Type)
            {
                case "FL":
                    {
                        Pozos.PozoBombeoFluyente.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

                        panel2.Controls.Add(TomaInformacion);
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.TomaInformacion TomaInformacion = new(Referencias) { Dock = DockStyle.Fill };

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
                    OTomaInformacion.CTomaBasica DatosOperativos = new();

                    #region Read

                    #region DoPresionTuberiaProduccion

                    if (_Telemetria.Range.DoPresionTuberiaProduccion)
                        DatosOperativos.DoPresionTuberiaProduccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoPresionTuberiaProduccionMax - _Telemetria.Range.DoPresionTuberiaProduccionMin) + _Telemetria.Range.DoPresionTuberiaProduccionMin;

                    #endregion DoPresionTuberiaProduccion

                    #region DoPresionTuberiaRevestimiento

                    if (_Telemetria.Range.DoPresionTuberiaRevestimiento)
                        DatosOperativos.DoPresionTuberiaRevestimiento = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoPresionTuberiaRevestimientoMax - _Telemetria.Range.DoPresionTuberiaRevestimientoMin) + _Telemetria.Range.DoPresionTuberiaRevestimientoMin;

                    #endregion DoPresionTuberiaRevestimiento

                    #region DoPresionAperturaCampo

                    if (_Telemetria.Range.DoPresionAperturaCampo)
                        DatosOperativos.DoPresionAperturaCampo = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoPresionAperturaCampoMax - _Telemetria.Range.DoPresionAperturaCampoMin) + _Telemetria.Range.DoPresionAperturaCampoMin;

                    #endregion DoPresionAperturaCampo

                    #region DoPresionLineaDescarga

                    if (_Telemetria.Range.DoPresionLineaDescarga)
                        DatosOperativos.DoPresionLineaDescarga = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoPresionLineaDescargaMax - _Telemetria.Range.DoPresionLineaDescargaMin) + _Telemetria.Range.DoPresionLineaDescargaMin;

                    #endregion DoPresionLineaDescarga

                    #region DoTemperaturaSuperficie

                    if (_Telemetria.Range.DoTemperaturaSuperficie)
                        DatosOperativos.DoTemperaturaSuperficie = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoTemperaturaSuperficieMax - _Telemetria.Range.DoTemperaturaSuperficieMin) + _Telemetria.Range.DoTemperaturaSuperficieMin;

                    #endregion DoTemperaturaSuperficie

                    #region DoSumergenciaEfectivaBomba

                    if (_Telemetria.Range.DoSumergenciaEfectivaBomba)
                        DatosOperativos.DoSumergenciaEfectivaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoSumergenciaEfectivaBombaMax - _Telemetria.Range.DoSumergenciaEfectivaBombaMin) + _Telemetria.Range.DoSumergenciaEfectivaBombaMin;

                    #endregion DoSumergenciaEfectivaBomba

                    #region DoNivelFluidoPozoTp

                    if (_Telemetria.Range.DoNivelFluidoPozoTp)
                        DatosOperativos.DoNivelFluidoPozoTp = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoNivelFluidoPozoTpMax - _Telemetria.Range.DoNivelFluidoPozoTpMin) + _Telemetria.Range.DoNivelFluidoPozoTpMin;

                    #endregion DoNivelFluidoPozoTp

                    #region DoNivelFluidoPozoTr

                    if (_Telemetria.Range.DoNivelFluidoPozoTr)
                        DatosOperativos.DoNivelFluidoPozoTr = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoNivelFluidoPozoTrMax - _Telemetria.Range.DoNivelFluidoPozoTrMin) + _Telemetria.Range.DoNivelFluidoPozoTrMin;

                    #endregion DoNivelFluidoPozoTr

                    #region DoPresionEntradaBomba

                    if (_Telemetria.Range.DoPresionEntradaBomba)
                        DatosOperativos.DoPresionEntradaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoPresionEntradaBombaMax - _Telemetria.Range.DoPresionEntradaBombaMin) + _Telemetria.Range.DoPresionEntradaBombaMin;

                    #endregion DoPresionEntradaBomba

                    #region DoVelocidadBomba

                    if (_Telemetria.Range.DoVelocidadBomba)
                        DatosOperativos.DoVelocidadBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoVelocidadBombaMax - _Telemetria.Range.DoVelocidadBombaMin) + _Telemetria.Range.DoVelocidadBombaMin;

                    #endregion DoVelocidadBomba

                    #region DoVelocidadUnidadBombeo

                    if (_Telemetria.Range.DoVelocidadUnidadBombeo)
                        DatosOperativos.DoVelocidadUnidadBombeo = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoVelocidadUnidadBombeoMax - _Telemetria.Range.DoVelocidadUnidadBombeoMin) + _Telemetria.Range.DoVelocidadUnidadBombeoMin;

                    #endregion DoVelocidadUnidadBombeo

                    #region DoFrecuenciaOperacionBomba

                    if (_Telemetria.Range.DoFrecuenciaOperacionBomba)
                        DatosOperativos.DoFrecuenciaOperacionBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoFrecuenciaOperacionBombaMax - _Telemetria.Range.DoFrecuenciaOperacionBombaMin) + _Telemetria.Range.DoFrecuenciaOperacionBombaMin;

                    #endregion DoFrecuenciaOperacionBomba

                    #region DoVelocidadMotor

                    if (_Telemetria.Range.DoVelocidadMotor)
                        DatosOperativos.DoVelocidadMotor = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoVelocidadMotorMax - _Telemetria.Range.DoVelocidadMotorMin) + _Telemetria.Range.DoVelocidadMotorMin;

                    #endregion DoVelocidadMotor

                    #region DoLongitudCarrera

                    if (_Telemetria.Range.DoLongitudCarrera)
                        DatosOperativos.DoLongitudCarrera = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoLongitudCarreraMax - _Telemetria.Range.DoLongitudCarreraMin) + _Telemetria.Range.DoLongitudCarreraMin;

                    #endregion DoLongitudCarrera

                    #region DoPresionDisponible

                    if (_Telemetria.Range.DoPresionDisponible)
                        DatosOperativos.DoPresionDisponible = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoPresionDisponibleMax - _Telemetria.Range.DoPresionDisponibleMin) + _Telemetria.Range.DoPresionDisponibleMin;

                    #endregion DoPresionDisponible

                    #region DoGastoInyeccionFluidoPotencia

                    if (_Telemetria.Range.DoGastoInyeccionFluidoPotencia)
                        DatosOperativos.DoGastoInyeccionFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoGastoInyeccionFluidoPotenciaMax - _Telemetria.Range.DoGastoInyeccionFluidoPotenciaMin) + _Telemetria.Range.DoGastoInyeccionFluidoPotenciaMin;

                    #endregion DoGastoInyeccionFluidoPotencia

                    #region DoGravedadEspecificaFluidoPotencia

                    if (_Telemetria.Range.DoGravedadEspecificaFluidoPotencia)
                        DatosOperativos.DoGravedadEspecificaFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoGravedadEspecificaFluidoPotenciaMax - _Telemetria.Range.DoGravedadEspecificaFluidoPotenciaMin) + _Telemetria.Range.DoGravedadEspecificaFluidoPotenciaMin;

                    #endregion DoGravedadEspecificaFluidoPotencia

                    #region DoGastoGasInyeccion

                    if (_Telemetria.Range.DoGastoGasInyeccion)
                        DatosOperativos.DoGastoGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoGastoGasInyeccionMax - _Telemetria.Range.DoGastoGasInyeccionMin) + _Telemetria.Range.DoGastoGasInyeccionMin;

                    #endregion DoGastoGasInyeccion

                    #region DoGravedadEspecificaGasInyeccion

                    if (_Telemetria.Range.DoGravedadEspecificaGasInyeccion)
                        DatosOperativos.DoGravedadEspecificaGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoGravedadEspecificaGasInyeccionMax - _Telemetria.Range.DoGravedadEspecificaGasInyeccionMin) + _Telemetria.Range.DoGravedadEspecificaGasInyeccionMin;

                    #endregion DoGravedadEspecificaGasInyeccion

                    #region DoTorque

                    if (_Telemetria.Range.DoTorque)
                        DatosOperativos.DoTorque = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoTorqueMax - _Telemetria.Range.DoTorqueMin) + _Telemetria.Range.DoTorqueMin;

                    #endregion DoTorque

                    #region DoCorriente

                    if (_Telemetria.Range.DoCorriente)
                        DatosOperativos.DoCorriente = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoCorrienteMax - _Telemetria.Range.DoCorrienteMin) + _Telemetria.Range.DoCorrienteMin;

                    #endregion DoCorriente

                    #region DoDiametroEstrangulador

                    if (_Telemetria.Range.DoDiametroEstrangulador)
                        DatosOperativos.DoDiametroEstrangulador = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoDiametroEstranguladorMax - _Telemetria.Range.DoDiametroEstranguladorMin) + _Telemetria.Range.DoDiametroEstranguladorMin;

                    #endregion DoDiametroEstrangulador

                    #region DoTiempoCiclo

                    if (_Telemetria.Range.DoTiempoCiclo)
                        DatosOperativos.DoTiempoCiclo = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoTiempoCicloMax - _Telemetria.Range.DoTiempoCicloMin) + _Telemetria.Range.DoTiempoCicloMin;

                    #endregion DoTiempoCiclo

                    #region DoTiempoRecuperacion

                    if (_Telemetria.Range.DoTiempoRecuperacion)
                        DatosOperativos.DoTiempoRecuperacion = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoTiempoRecuperacionMax - _Telemetria.Range.DoTiempoRecuperacionMin) + _Telemetria.Range.DoTiempoRecuperacionMin;

                    #endregion DoTiempoRecuperacion

                    #region DoTiempoInyeccion

                    if (_Telemetria.Range.DoTiempoInyeccion)
                        DatosOperativos.DoTiempoInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoTiempoInyeccionMax - _Telemetria.Range.DoTiempoInyeccionMin) + _Telemetria.Range.DoTiempoInyeccionMin;

                    #endregion DoTiempoInyeccion

                    #region DoTiempoDesplazamientoTapon

                    if (_Telemetria.Range.DoTiempoDesplazamientoTapon)
                        DatosOperativos.DoTiempoDesplazamientoTapon = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoTiempoDesplazamientoTaponMax - _Telemetria.Range.DoTiempoDesplazamientoTaponMin) + _Telemetria.Range.DoTiempoDesplazamientoTaponMin;

                    #endregion DoTiempoDesplazamientoTapon

                    #region DoEficienciaLlenado

                    if (_Telemetria.Range.DoEficienciaLlenado)
                        DatosOperativos.DoEficienciaLlenado = (decimal)new Random().NextDouble() * (_Telemetria.Range.DoEficienciaLlenadoMax - _Telemetria.Range.DoEficienciaLlenadoMin) + _Telemetria.Range.DoEficienciaLlenadoMin;

                    #endregion DoEficienciaLlenado

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
                if ((_Telemetria.Range.DatosOperativos.TotalMilliseconds != 0) & (time1 <= DateTime.UtcNow))
                {
                    OCartaDinagrafica.CCartaDinagrafica CCartaDinagrafica = new();

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

                        _Telemetria = await TelemetriaController.Post(_Telemetria, true);
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
            lblOnOff.Text = Languages.DPSOsTelemetria.On;
            pictureBox1.Image = Resources.on_button1;

            _Telemetria = Referencias.Copy<ReferenciasII, ReferenciasI>();
            _Telemetria.Started = DateTime.UtcNow;

            panel2.Controls.Clear();
            switch (Referencias.Type)
            {
                case "FL":
                    {
                        Pozos.PozoBombeoFluyente.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };

                        panel2.Controls.Add(MonitoreoVirtual);
                        MonitoreoVirtual.Recargar(Decimales, _Telemetria);
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.MonitoreoVirtual MonitoreoVirtual = new() { Dock = DockStyle.Fill };

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

        private void Pozo_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = this.MdiParent.ClientSize;
                this.Location = new Point(0, 0);
            }
        }

        private void Pozo_Shown(object sender, EventArgs e)
        {
            Text = $"{Referencias.Name} ({SystemWell.GetString(Referencias.Type)}) - {General.InformationGathering}";
            InformationGathering();
        }

        private void Pozo_FormClosing(object sender, FormClosingEventArgs e) => Guardar_Info();
    }
}