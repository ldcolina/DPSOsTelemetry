using DPSOsTelemetria2.Properties;
using Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        internal ReferenciasI _Telemetria = new ReferenciasI();

        internal List<ReferenciasI> _Telemetrias = new List<ReferenciasI>();

        internal ReferenciasII Referencias = new ReferenciasII();

        internal string select;

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
            if (_Telemetrias.Exists(val => val.DatosOperativosTime == _Telemetria.DatosOperativosTime && val.CartaDinagraficaTime == _Telemetria.CartaDinagraficaTime))
                return;

            _Telemetria.Sent = new List<string>();
            _Telemetria.DatosOperativosBool = false;
            _Telemetria.DatosOperativosFinish = false;
            _Telemetria.CartaDinagraficaBool = false;
            _Telemetria.CartaDinagraficaFinish = false;
            _Telemetrias.Add(_Telemetria.Copy());

            int i = _Telemetrias.FindIndex(val => JsonConvert.SerializeObject(val) == JsonConvert.SerializeObject(_Telemetria));

            if ((_Telemetria.Range.DatosOperativos.TotalSeconds != 0) && (_Telemetria.DatosOperativosTime <= DateTime.UtcNow))
            {
                _Telemetria.Sent.Add("DatosOperativos");
                _Telemetria.DatosOperativos = DatosOperativos();
                _Telemetrias[i].Sent = _Telemetria.Sent.Copy();
                _Telemetrias[i].DatosOperativos = _Telemetria.DatosOperativos.Copy();
            }

            if ((_Telemetria.Range.CartaDinagrafica.TotalSeconds != 0) && (_Telemetria.CartaDinagraficaTime <= DateTime.UtcNow))
            {
                _Telemetria.Sent.Add("CartaDinagrafica");
                _Telemetria.DatosCarta = DatosCarta();
                _Telemetrias[i].Sent = _Telemetria.Sent.Copy();
                _Telemetrias[i].DatosCarta = _Telemetria.DatosCarta.Copy();
            }

            _Telemetria = await Telemetria();

            _Telemetrias[i].DatosOperativosBool = _Telemetria.DatosOperativosBool;
            _Telemetrias[i].DatosOperativosFinish = _Telemetria.DatosOperativosFinish;
            _Telemetrias[i].DatosOperativosPromedio = _Telemetria.DatosOperativosPromedio;

            _Telemetrias[i].CartaDinagraficaBool = _Telemetria.CartaDinagraficaBool;
            _Telemetrias[i].CartaDinagraficaFinish = _Telemetria.CartaDinagraficaFinish;
            _Telemetrias[i].CartaDinagraficaPromedio = _Telemetria.CartaDinagraficaPromedio;
        }

        public OTomaInformacion.CTomaBasica DatosOperativos()
        {
            OTomaInformacion.CTomaBasica DatosOperativos = new OTomaInformacion.CTomaBasica();

            #region CargaSobreBarraPulida

            if (_Telemetria.Range.CargaSobreBarraPulida)
                DatosOperativos.CargaSobreBarraPulida = (decimal)new Random().NextDouble() * (_Telemetria.Range.CargaSobreBarraPulidaMax - _Telemetria.Range.CargaSobreBarraPulidaMin) + _Telemetria.Range.CargaSobreBarraPulidaMin;

            #endregion CargaSobreBarraPulida

            #region Corriente

            if (_Telemetria.Range.Corriente)
                DatosOperativos.Corriente = (decimal)new Random().NextDouble() * (_Telemetria.Range.CorrienteMax - _Telemetria.Range.CorrienteMin) + _Telemetria.Range.CorrienteMin;

            #endregion Corriente

            #region DiametroEstrangulador

            if (_Telemetria.Range.DiametroEstrangulador)
                DatosOperativos.DiametroEstrangulador = (decimal)new Random().NextDouble() * (_Telemetria.Range.DiametroEstranguladorMax - _Telemetria.Range.DiametroEstranguladorMin) + _Telemetria.Range.DiametroEstranguladorMin;

            #endregion DiametroEstrangulador

            #region EficienciaLlenado

            if (_Telemetria.Range.EficienciaLlenado)
                DatosOperativos.EficienciaLlenado = (decimal)new Random().NextDouble() * (_Telemetria.Range.EficienciaLlenadoMax - _Telemetria.Range.EficienciaLlenadoMin) + _Telemetria.Range.EficienciaLlenadoMin;

            #endregion EficienciaLlenado

            #region Emulsion

            if (_Telemetria.Range.Emulsion)
                DatosOperativos.Emulsion = (decimal)new Random().NextDouble() * (_Telemetria.Range.EmulsionMax - _Telemetria.Range.EmulsionMin) + _Telemetria.Range.EmulsionMin;

            #endregion Emulsion

            #region FrecuenciaOperacionBomba

            if (_Telemetria.Range.FrecuenciaOperacionBomba)
                DatosOperativos.FrecuenciaOperacionBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.FrecuenciaOperacionBombaMax - _Telemetria.Range.FrecuenciaOperacionBombaMin) + _Telemetria.Range.FrecuenciaOperacionBombaMin;

            #endregion FrecuenciaOperacionBomba

            #region GastoAceite

            if (_Telemetria.Range.GastoAceite)
                DatosOperativos.GastoAceite = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoAceiteMax - _Telemetria.Range.GastoAceiteMin) + _Telemetria.Range.GastoAceiteMin;

            #endregion GastoAceite

            #region GastoGas

            if (_Telemetria.Range.GastoGas)
                DatosOperativos.GastoGas = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoGasMax - _Telemetria.Range.GastoGasMin) + _Telemetria.Range.GastoGasMin;

            #endregion GastoGas

            #region GastoGasInyeccion

            if (_Telemetria.Range.GastoGasInyeccion)
                DatosOperativos.GastoGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoGasInyeccionMax - _Telemetria.Range.GastoGasInyeccionMin) + _Telemetria.Range.GastoGasInyeccionMin;

            #endregion GastoGasInyeccion

            #region GastoInyeccionFluidoPotencia

            if (_Telemetria.Range.GastoInyeccionFluidoPotencia)
                DatosOperativos.GastoInyeccionFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoInyeccionFluidoPotenciaMax - _Telemetria.Range.GastoInyeccionFluidoPotenciaMin) + _Telemetria.Range.GastoInyeccionFluidoPotenciaMin;

            #endregion GastoInyeccionFluidoPotencia

            #region GastoLiquido

            if (_Telemetria.Range.GastoLiquido)
                DatosOperativos.GastoLiquido = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoLiquidoMax - _Telemetria.Range.GastoLiquidoMin) + _Telemetria.Range.GastoLiquidoMin;

            #endregion GastoLiquido

            #region GastoLiquidoPruebaProduccion

            if (_Telemetria.Range.GastoLiquidoPruebaProduccion)
                DatosOperativos.GastoLiquidoPruebaProduccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.GastoLiquidoPruebaProduccionMax - _Telemetria.Range.GastoLiquidoPruebaProduccionMin) + _Telemetria.Range.GastoLiquidoPruebaProduccionMin;

            #endregion GastoLiquidoPruebaProduccion

            #region GravedadEspecificaFluidoPotencia

            if (_Telemetria.Range.GravedadEspecificaFluidoPotencia)
                DatosOperativos.GravedadEspecificaFluidoPotencia = (decimal)new Random().NextDouble() * (_Telemetria.Range.GravedadEspecificaFluidoPotenciaMax - _Telemetria.Range.GravedadEspecificaFluidoPotenciaMin) + _Telemetria.Range.GravedadEspecificaFluidoPotenciaMin;

            #endregion GravedadEspecificaFluidoPotencia

            #region GravedadEspecificaGasProducido

            if (_Telemetria.Range.GravedadEspecificaGasProducido)
                DatosOperativos.GravedadEspecificaGasProducido = (decimal)new Random().NextDouble() * (_Telemetria.Range.GravedadEspecificaGasProducidoMax - _Telemetria.Range.GravedadEspecificaGasProducidoMin) + _Telemetria.Range.GravedadEspecificaGasProducidoMin;

            #endregion GravedadEspecificaGasProducido

            #region GravedadPetroleo

            if (_Telemetria.Range.GravedadPetroleo)
                DatosOperativos.GravedadPetroleo = (decimal)new Random().NextDouble() * (_Telemetria.Range.GravedadPetroleoMax - _Telemetria.Range.GravedadPetroleoMin) + _Telemetria.Range.GravedadPetroleoMin;

            #endregion GravedadPetroleo

            #region LongitudCarrera

            if (_Telemetria.Range.LongitudCarrera)
                DatosOperativos.LongitudCarrera = (decimal)new Random().NextDouble() * (_Telemetria.Range.LongitudCarreraMax - _Telemetria.Range.LongitudCarreraMin) + _Telemetria.Range.LongitudCarreraMin;

            #endregion LongitudCarrera

            #region NivelFluidoPozoTp

            if (_Telemetria.Range.NivelFluidoPozoTp)
                DatosOperativos.NivelFluidoPozoTp = (decimal)new Random().NextDouble() * (_Telemetria.Range.NivelFluidoPozoTpMax - _Telemetria.Range.NivelFluidoPozoTpMin) + _Telemetria.Range.NivelFluidoPozoTpMin;

            #endregion NivelFluidoPozoTp

            #region NivelFluidoPozoTr

            if (_Telemetria.Range.NivelFluidoPozoTr)
                DatosOperativos.NivelFluidoPozoTr = (decimal)new Random().NextDouble() * (_Telemetria.Range.NivelFluidoPozoTrMax - _Telemetria.Range.NivelFluidoPozoTrMin) + _Telemetria.Range.NivelFluidoPozoTrMin;

            #endregion NivelFluidoPozoTr

            #region PorcentajeAguaSedimento

            if (_Telemetria.Range.PorcentajeAguaSedimento)
                DatosOperativos.PorcentajeAguaSedimento = (decimal)new Random().NextDouble() * (_Telemetria.Range.PorcentajeAguaSedimentoMax - _Telemetria.Range.PorcentajeAguaSedimentoMin) + _Telemetria.Range.PorcentajeAguaSedimentoMin;

            #endregion PorcentajeAguaSedimento

            #region PresionAperturaCampo

            if (_Telemetria.Range.PresionAperturaCampo)
                DatosOperativos.PresionAperturaCampo = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionAperturaCampoMax - _Telemetria.Range.PresionAperturaCampoMin) + _Telemetria.Range.PresionAperturaCampoMin;

            #endregion PresionAperturaCampo

            #region PresionEntradaBomba

            if (_Telemetria.Range.PresionEntradaBomba)
                DatosOperativos.PresionEntradaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionEntradaBombaMax - _Telemetria.Range.PresionEntradaBombaMin) + _Telemetria.Range.PresionEntradaBombaMin;

            #endregion PresionEntradaBomba

            #region PresionLineaDescarga

            if (_Telemetria.Range.PresionLineaDescarga)
                DatosOperativos.PresionLineaDescarga = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionLineaDescargaMax - _Telemetria.Range.PresionLineaDescargaMin) + _Telemetria.Range.PresionLineaDescargaMin;

            #endregion PresionLineaDescarga

            #region PresionTuberiaProduccion

            if (_Telemetria.Range.PresionTuberiaProduccion)
                DatosOperativos.PresionTuberiaProduccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionTuberiaProduccionMax - _Telemetria.Range.PresionTuberiaProduccionMin) + _Telemetria.Range.PresionTuberiaProduccionMin;

            #endregion PresionTuberiaProduccion

            #region PresionTuberiaRevestimiento

            if (_Telemetria.Range.PresionTuberiaRevestimiento)
                DatosOperativos.PresionTuberiaRevestimiento = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionTuberiaRevestimientoMax - _Telemetria.Range.PresionTuberiaRevestimientoMin) + _Telemetria.Range.PresionTuberiaRevestimientoMin;

            #endregion PresionTuberiaRevestimiento

            #region RelacionGasAceite

            if (_Telemetria.Range.RelacionGasAceite)
                DatosOperativos.RelacionGasAceite = (decimal)new Random().NextDouble() * (_Telemetria.Range.RelacionGasAceiteMax - _Telemetria.Range.RelacionGasAceiteMin) + _Telemetria.Range.RelacionGasAceiteMin;

            #endregion RelacionGasAceite

            #region SalinidadAgua

            if (_Telemetria.Range.SalinidadAgua)
                DatosOperativos.SalinidadAgua = (decimal)new Random().NextDouble() * (_Telemetria.Range.SalinidadAguaMax - _Telemetria.Range.SalinidadAguaMin) + _Telemetria.Range.SalinidadAguaMin;

            #endregion SalinidadAgua

            #region SumergenciaEfectivaBomba

            if (_Telemetria.Range.SumergenciaEfectivaBomba)
                DatosOperativos.SumergenciaEfectivaBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.SumergenciaEfectivaBombaMax - _Telemetria.Range.SumergenciaEfectivaBombaMin) + _Telemetria.Range.SumergenciaEfectivaBombaMin;

            #endregion SumergenciaEfectivaBomba

            #region TemperaturaSuperficie

            if (_Telemetria.Range.TemperaturaSuperficie)
                DatosOperativos.TemperaturaSuperficie = (decimal)new Random().NextDouble() * (_Telemetria.Range.TemperaturaSuperficieMax - _Telemetria.Range.TemperaturaSuperficieMin) + _Telemetria.Range.TemperaturaSuperficieMin;

            #endregion TemperaturaSuperficie

            #region PresionSeparacion

            if (_Telemetria.Range.PresionSeparacion)
                DatosOperativos.PresionSeparacion = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionSeparacionMax - _Telemetria.Range.PresionSeparacionMin) + _Telemetria.Range.PresionSeparacionMin;

            #endregion PresionSeparacion

            #region TiempoCiclo

            if (_Telemetria.Range.TiempoCiclo)
                DatosOperativos.TiempoCiclo = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoCicloMax - _Telemetria.Range.TiempoCicloMin) + _Telemetria.Range.TiempoCicloMin;

            #endregion TiempoCiclo

            #region TiempoDesplazamientoTapon

            if (_Telemetria.Range.TiempoDesplazamientoTapon)
                DatosOperativos.TiempoDesplazamientoTapon = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoDesplazamientoTaponMax - _Telemetria.Range.TiempoDesplazamientoTaponMin) + _Telemetria.Range.TiempoDesplazamientoTaponMin;

            #endregion TiempoDesplazamientoTapon

            #region TiempoInyeccion

            if (_Telemetria.Range.TiempoInyeccion)
                DatosOperativos.TiempoInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoInyeccionMax - _Telemetria.Range.TiempoInyeccionMin) + _Telemetria.Range.TiempoInyeccionMin;

            #endregion TiempoInyeccion

            #region TiempoRecuperacion

            if (_Telemetria.Range.TiempoRecuperacion)
                DatosOperativos.TiempoRecuperacion = (decimal)new Random().NextDouble() * (_Telemetria.Range.TiempoRecuperacionMax - _Telemetria.Range.TiempoRecuperacionMin) + _Telemetria.Range.TiempoRecuperacionMin;

            #endregion TiempoRecuperacion

            #region Torque

            if (_Telemetria.Range.Torque)
                DatosOperativos.Torque = (decimal)new Random().NextDouble() * (_Telemetria.Range.TorqueMax - _Telemetria.Range.TorqueMin) + _Telemetria.Range.TorqueMin;

            #endregion Torque

            #region VelocidadBomba

            if (_Telemetria.Range.VelocidadBomba)
                DatosOperativos.VelocidadBomba = (decimal)new Random().NextDouble() * (_Telemetria.Range.VelocidadBombaMax - _Telemetria.Range.VelocidadBombaMin) + _Telemetria.Range.VelocidadBombaMin;

            #endregion VelocidadBomba

            #region VelocidadMotor

            if (_Telemetria.Range.VelocidadMotor)
                DatosOperativos.VelocidadMotor = (decimal)new Random().NextDouble() * (_Telemetria.Range.VelocidadMotorMax - _Telemetria.Range.VelocidadMotorMin) + _Telemetria.Range.VelocidadMotorMin;

            #endregion VelocidadMotor

            #region VelocidadUnidadBombeo

            if (_Telemetria.Range.VelocidadUnidadBombeo)
                DatosOperativos.VelocidadUnidadBombeo = (decimal)new Random().NextDouble() * (_Telemetria.Range.VelocidadUnidadBombeoMax - _Telemetria.Range.VelocidadUnidadBombeoMin) + _Telemetria.Range.VelocidadUnidadBombeoMin;

            #endregion VelocidadUnidadBombeo

            #region Metodo QGI

            switch (_Telemetria.MetodoQGI)
            {
                case "0":
                    {
                        #region PresionDisponible

                        if (_Telemetria.Range.PresionDisponible)
                            DatosOperativos.QgiPresionDisponible = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionDisponibleMax - _Telemetria.Range.PresionDisponibleMin) + _Telemetria.Range.PresionDisponibleMin;

                        #endregion PresionDisponible

                        #region NroVuelta

                        if (_Telemetria.Range.NroVuelta)
                            DatosOperativos.QgiNroVuelta = (decimal)new Random().NextDouble() * (_Telemetria.Range.NroVueltaMax - _Telemetria.Range.NroVueltaMin) + _Telemetria.Range.NroVueltaMin;

                        #endregion NroVuelta

                        break;
                    }
                case "1":
                    {
                        #region PresionDisponible

                        if (_Telemetria.Range.PresionDisponible)
                            DatosOperativos.QgiPresionDisponible = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionDisponibleMax - _Telemetria.Range.PresionDisponibleMin) + _Telemetria.Range.PresionDisponibleMin;

                        #endregion PresionDisponible

                        #region PresionDiferencial

                        if (_Telemetria.Range.PresionDiferencial)
                            DatosOperativos.QgiPresionDiferencial = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionDiferencialMax - _Telemetria.Range.PresionDiferencialMin) + _Telemetria.Range.PresionDiferencialMin;

                        #endregion PresionDiferencial

                        #region DiametroOrificio

                        if (_Telemetria.Range.DiametroOrificio)
                            DatosOperativos.QgiDiametroOrificio = (decimal)new Random().NextDouble() * (_Telemetria.Range.DiametroOrificioMax - _Telemetria.Range.DiametroOrificioMin) + _Telemetria.Range.DiametroOrificioMin;

                        #endregion DiametroOrificio

                        break;
                    }
                case "2":
                    {
                        #region PresionDisponible

                        if (_Telemetria.Range.PresionDisponible)
                            DatosOperativos.QgiPresionDisponible = (decimal)new Random().NextDouble() * (_Telemetria.Range.PresionDisponibleMax - _Telemetria.Range.PresionDisponibleMin) + _Telemetria.Range.PresionDisponibleMin;

                        #endregion PresionDisponible

                        #region AjusteValvula

                        if (_Telemetria.Range.AjusteValvula)
                            DatosOperativos.QgiAjusteValvula = (decimal)new Random().NextDouble() * (_Telemetria.Range.AjusteValvulaMax - _Telemetria.Range.AjusteValvulaMin) + _Telemetria.Range.AjusteValvulaMin;

                        #endregion AjusteValvula

                        break;
                    }
                case "3":
                    {
                        #region GravedadEspecificaGasInyeccion

                        if (_Telemetria.Range.GravedadEspecificaGasInyeccion)
                            DatosOperativos.QgiGravedadEspecificaGasInyeccion = (decimal)new Random().NextDouble() * (_Telemetria.Range.GravedadEspecificaGasInyeccionMax - _Telemetria.Range.GravedadEspecificaGasInyeccionMin) + _Telemetria.Range.GravedadEspecificaGasInyeccionMin;

                        #endregion GravedadEspecificaGasInyeccion

                        break;
                    }
            }

            #endregion Metodo QGI

            return DatosOperativos;
        }

        public OCartaDinagrafica.CTomaCarta DatosCarta()
        {
            OCartaDinagrafica.CTomaCarta DatosCarta = new OCartaDinagrafica.CTomaCarta();

            if (_Telemetria.Range.CCartaDinagrafica)
            {
                int index = new Random().Next(0, _Telemetria.Range.ListCCartaDinagrafica.Count);
                DatosCarta.CartaSuperficie = _Telemetria.Range.ListCCartaDinagrafica[index].CartaSuperficie;
            }

            return DatosCarta;
        }

        internal async Task<ReferenciasI> Telemetria()
        {
            return await Task.Run(async () =>
            {
                if (JsonConvert.SerializeObject(_Telemetria.DatosOperativos) != JsonConvert.SerializeObject(new OTomaInformacion.CTomaBasica()))
                {
                    DateTime lastTime = _Telemetria.DatosOperativosTime;
                    _Telemetria = await TelemetriaController.Post(_Telemetria, true);
                    _Telemetria.DatosOperativosPromedio = DateTime.UtcNow - lastTime;
                }

                if (JsonConvert.SerializeObject(_Telemetria.DatosCarta) != JsonConvert.SerializeObject(new OCartaDinagrafica.CTomaCarta()))
                {
                    DateTime lastTime = _Telemetria.CartaDinagraficaTime;
                    _Telemetria = await TelemetriaController.Post(_Telemetria, false);
                    _Telemetria.CartaDinagraficaPromedio = DateTime.UtcNow - lastTime;
                }

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
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoNeumatico.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoMecanico.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.MonitoreoVirtual MonitoreoVirtual = panel2.Controls.OfType<Pozos.PozoBombeoJetPump.MonitoreoVirtual>().FirstOrDefault();
                        MonitoreoVirtual.Recargar(Decimales, _Telemetrias);
                        break;
                    }
            }
        }

        private void VirtualMonitoring()
        {
            lblOnOff.Text = DPSOsTelemetria.On;
            pictureBox1.Image = Resources.on_button;
            _Telemetrias.Clear();

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
                        break;
                    }

                case "FLG":
                    {
                        Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoFluyenteGas.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        break;
                    }

                case "BN":
                    {
                        Pozos.PozoBombeoNeumatico.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoNeumatico.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        break;
                    }

                case "BNI":
                    {
                        Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoNeumaticoIntermitente.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        break;
                    }

                case "BM":
                    {
                        Pozos.PozoBombeoMecanico.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoMecanico.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        break;
                    }

                case "BCP":
                    {
                        Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoCavidadProgresiva.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        break;
                    }

                case "BEC":
                    {
                        Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoElectroCentrifugo.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        break;
                    }

                case "BJP":
                    {
                        Pozos.PozoBombeoJetPump.MonitoreoVirtual MonitoreoVirtual = new Pozos.PozoBombeoJetPump.MonitoreoVirtual() { Dock = DockStyle.Fill };
                        panel2.Controls.Add(MonitoreoVirtual);
                        break;
                    }
            }

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