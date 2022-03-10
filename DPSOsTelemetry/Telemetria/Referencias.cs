using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Telemetria
{
    public enum Siglas
    {
        Presion,
        Temperatura,
        Distancia,
        Diametro,
        RelacionGasAceite,
        Fuerza,
        Potencia,
        Aceite,
        Angulo,
        Anio,
        Corriente,
        Densidad,
        Dia,
        Embolada,
        FactorVolumetrico,
        FactorVolumetricoAceite,
        FlujoVolumetricoGas,
        FlujoVolumetricoLiquido,
        Frecuencia,
        GastoGas,
        Hora,
        IndiceProductividad,
        Liquido,
        Mes,
        Minuto,
        Porcentaje,
        Presion2,
        Segundo,
        Tension,
        Torque,
        Velocidad,
        Longitud_Carta,
    }

    public static class Configuracion
    {
        /// <summary>
        /// Siglas para mostrar al usuario
        /// </summary>
        /// <param name="tipo">Enum _Siglas</param>
        /// <returns></returns>
        public static string GetSigla(Siglas tipo, string unidad)
        {
            try
            {
                switch (tipo)
                {
                    case Siglas.Presion:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Languages.Siglas.Psi;

                                case "1": //SI
                                    return Languages.Siglas.Pascal;

                                case "4": //Latin_SI
                                default: //Mexico
                                    return Languages.Siglas.KilogramoFuerza_CentimetroElevadoDos;
                            }
                        }
                    case Siglas.Temperatura:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Languages.Siglas.Fahrenheit;

                                case "1": //SI
                                    return Languages.Siglas.Kelvin;

                                case "4": //Latin_SI
                                default: //Mexico
                                    return Languages.Siglas.Celsius;
                            }
                        }
                    case Siglas.Distancia:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Languages.Siglas.Pie;

                                case "1": //SI
                                case "4": //Latin_SI
                                default: //Mexico
                                    return Languages.Siglas.Metro;
                            }
                        }
                    case Siglas.Diametro:
                        {
                            switch (unidad)
                            {
                                case "1": //SI
                                case "4": //Latin_SI
                                    return Languages.Siglas.Centimetro;

                                case "0": //Oilfield
                                case "3": //English
                                default: //Mexico
                                    return Languages.Siglas.Pulgada;
                            }
                        }
                    case Siglas.RelacionGasAceite:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Languages.Siglas.PieCubicoEstandarPorBarrilTanqueReserva;

                                case "1": //SI
                                case "4": //Latin_SI
                                default: //Mexico
                                    return Languages.Siglas.MetroCubicoPorMetroCubico;
                            }
                        }
                    case Siglas.Fuerza:
                        {
                            switch (unidad)
                            {
                                case "1": //SI
                                case "4": //Latin_SI
                                    return Languages.Siglas.Newton;

                                case "0": //Oilfield
                                case "3": //English
                                default: //Mexico
                                    return Languages.Siglas.KilolibraFuerza;
                            }
                        }
                    case Siglas.Potencia:
                        {
                            switch (unidad)
                            {
                                case "1": //SI
                                case "4": //Latin_SI
                                    return Languages.Siglas.Kilovatio;

                                case "0": //Oilfield
                                case "3": //English
                                default: //Mexico
                                    return Languages.Siglas.Caballo;
                            }
                        }

                    #region Valores fijos

                    case Siglas.Aceite:
                        {
                            return Languages.Siglas.BarrilesAceite;
                        }
                    case Siglas.Angulo:
                        {
                            return Languages.Siglas.Grado;
                        }
                    case Siglas.Anio:
                        {
                            return Languages.Siglas.Anio;
                        }
                    case Siglas.Corriente:
                        {
                            return Languages.Siglas.Amperios;
                        }
                    case Siglas.Densidad:
                        {
                            return Languages.Siglas.GradosApi;
                        }
                    case Siglas.Dia:
                        {
                            return Languages.Siglas.Dia;
                        }
                    case Siglas.Embolada:
                        {
                            return Languages.Siglas.EmboladaPorMinuto;
                        }
                    case Siglas.FactorVolumetrico:
                        {
                            return Languages.Siglas.BarrilPetroleoPorBarrilTanqueExistencias;
                        }
                    case Siglas.FactorVolumetricoAceite:
                        {
                            return Languages.Siglas.BarrilesAceitePorDia;
                        }
                    case Siglas.FlujoVolumetricoGas:
                        {
                            return Languages.Siglas.MilesPieElevadoTresPorDia;
                        }
                    case Siglas.FlujoVolumetricoLiquido:
                        {
                            return Languages.Siglas.BarrilesPetroleoPorDia;
                        }
                    case Siglas.Frecuencia:
                        {
                            return Languages.Siglas.Hercio;
                        }
                    case Siglas.GastoGas:
                        {
                            return Languages.Siglas.MillonesPieElevadoTresPorDia;
                        }
                    case Siglas.Hora:
                        {
                            return Languages.Siglas.Hora;
                        }
                    case Siglas.IndiceProductividad:
                        {
                            return $"{Languages.Siglas.BarrilesPetroleoPorDia}/{Languages.Siglas.Psi}";
                        }
                    case Siglas.Liquido:
                        {
                            return Languages.Siglas.BarrilesLiquido;
                        }
                    case Siglas.Longitud_Carta:
                        {
                            return Languages.Siglas.Pulgada;
                        }
                    case Siglas.Mes:
                        {
                            return Languages.Siglas.Mes;
                        }
                    case Siglas.Minuto:
                        {
                            return Languages.Siglas.Minuto;
                        }
                    case Siglas.Porcentaje:
                        {
                            return Languages.Siglas.Porcentaje;
                        }
                    case Siglas.Presion2:
                        {
                            return Languages.Siglas.PulgadaAgua60GradosF;
                        }
                    case Siglas.Segundo:
                        {
                            return Languages.Siglas.Segundo;
                        }
                    case Siglas.Tension:
                        {
                            return Languages.Siglas.Kpsi;
                        }
                    case Siglas.Torque:
                        {
                            return $"{Languages.Siglas.LibraFuerza}-{Languages.Siglas.Pie}";
                        }
                    case Siglas.Velocidad:
                        {
                            return Languages.Siglas.Revolucion_Minuto;
                        }

                        #endregion Valores fijos
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
    }

    public static class List_DataTable
    {
        #region Copy

        public static T Copy<T>(this T items) => JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(items));

        public static List<T> Copy<T>(this List<T> items) => JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(items));

        public static IEnumerable<T> Copy<T>(this IEnumerable<T> items) => JsonConvert.DeserializeObject<IEnumerable<T>>(JsonConvert.SerializeObject(items));

        public static D Copy<T, D>(this T items) => JsonConvert.DeserializeObject<D>(JsonConvert.SerializeObject(items));

        public static List<D> Copy<T, D>(this List<T> items) => JsonConvert.DeserializeObject<List<D>>(JsonConvert.SerializeObject(items));

        public static IEnumerable<D> Copy<T, D>(this IEnumerable<T> items) => JsonConvert.DeserializeObject<IEnumerable<D>>(JsonConvert.SerializeObject(items));

        #endregion Copy

        #region DataTable

        public static DataTable ToDataTable<T>(this List<T> items) => items.ToArray().ToDataTable();

        public static DataTable ToDataTable<T>(this IEnumerable<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                object[] values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        #endregion DataTable

        #region List<T>

        public static List<T> ConvertTo<T>(this DataTable datatable) where T : new()
        {
            List<T> Temp = new List<T>();
            try
            {
                List<string> columnsNames = new List<string>();
                foreach (DataColumn DataColumn in datatable.Columns)
                    columnsNames.Add(DataColumn.ColumnName);
                Temp = datatable.AsEnumerable().ToList().ConvertAll(row => getObject<T>(row, columnsNames));
                return Temp;
            }
            catch
            {
                return Temp;
            }
        }

        public static T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        {
            T obj = new T();
            try
            {
                string columnname = "";
                string value = "";
                PropertyInfo[] Properties;
                Properties = typeof(T).GetProperties();
                foreach (PropertyInfo objProperty in Properties)
                {
                    columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
                    if (!string.IsNullOrEmpty(columnname))
                    {
                        value = row[columnname].ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
                            {
                                value = row[columnname].ToString().Replace("$", "").Replace(",", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
                            }
                            else
                            {
                                value = row[columnname].ToString().Replace("%", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
                            }
                        }
                    }
                }
                return obj;
            }
            catch
            {
                return obj;
            }
        }

        #endregion List<T>
    }

    public class Referencias
    {
        public string Name { set; get; } = string.Empty;
        public TomaBasica Range { set; get; } = new TomaBasica();
        public string Token { set; get; } = string.Empty;
        public string Type { set; get; } = "None";
        public string Unidades { set; get; } = "None";
    }

    public class ReferenciasI : Referencias
    {
        public DateTime Started { get; set; }
        public OCartaDinagrafica.CCartaDinagrafica CartaDinagrafica { set; get; } = new OCartaDinagrafica.CCartaDinagrafica();
        public int CartaDinagraficaComplete { get; set; }
        public int CartaDinagraficaFails { get; set; }
        public int CartaDinagraficaSends { get; set; }
        public OTomaInformacion.CTomaBasica DatosOperativos { set; get; } = new OTomaInformacion.CTomaBasica();
        public int DatosOperativosComplete { get; set; }
        public int DatosOperativosFails { get; set; }
        public int DatosOperativosSends { get; set; }
    }

    public class ReferenciasII : Referencias
    {
        public DateTime Date { get; set; }
        public string ID { get; set; }
    }

    public class TomaBasica
    {
        #region DoPresionTuberiaProduccion

        public bool DoPresionTuberiaProduccion { get; set; } = false;
        public decimal DoPresionTuberiaProduccionMax { get; set; } = 0;
        public decimal DoPresionTuberiaProduccionMin { get; set; } = 0;

        #endregion DoPresionTuberiaProduccion

        #region DoPresionTuberiaRevestimiento

        public bool DoPresionTuberiaRevestimiento { get; set; } = false;
        public decimal DoPresionTuberiaRevestimientoMax { get; set; } = 0;
        public decimal DoPresionTuberiaRevestimientoMin { get; set; } = 0;

        #endregion DoPresionTuberiaRevestimiento

        #region DoPresionAperturaCampo

        public bool DoPresionAperturaCampo { get; set; } = false;
        public decimal DoPresionAperturaCampoMax { get; set; } = 0;
        public decimal DoPresionAperturaCampoMin { get; set; } = 0;

        #endregion DoPresionAperturaCampo

        #region DoPresionLineaDescarga

        public bool DoPresionLineaDescarga { get; set; } = false;
        public decimal DoPresionLineaDescargaMax { get; set; } = 0;
        public decimal DoPresionLineaDescargaMin { get; set; } = 0;

        #endregion DoPresionLineaDescarga

        #region DoTemperaturaSuperficie

        public bool DoTemperaturaSuperficie { get; set; } = false;
        public decimal DoTemperaturaSuperficieMax { get; set; } = 0;
        public decimal DoTemperaturaSuperficieMin { get; set; } = 0;

        #endregion DoTemperaturaSuperficie

        #region DoSumergenciaEfectivaBomba

        public bool DoSumergenciaEfectivaBomba { get; set; } = false;
        public decimal DoSumergenciaEfectivaBombaMax { get; set; } = 0;
        public decimal DoSumergenciaEfectivaBombaMin { get; set; } = 0;

        #endregion DoSumergenciaEfectivaBomba

        #region DoNivelFluidoPozoTp

        public bool DoNivelFluidoPozoTp { get; set; } = false;
        public decimal DoNivelFluidoPozoTpMax { get; set; } = 0;
        public decimal DoNivelFluidoPozoTpMin { get; set; } = 0;

        #endregion DoNivelFluidoPozoTp

        #region DoNivelFluidoPozoTr

        public bool DoNivelFluidoPozoTr { get; set; } = false;
        public decimal DoNivelFluidoPozoTrMax { get; set; } = 0;
        public decimal DoNivelFluidoPozoTrMin { get; set; } = 0;

        #endregion DoNivelFluidoPozoTr

        #region DoPresionEntradaBomba

        public bool DoPresionEntradaBomba { get; set; } = false;
        public decimal DoPresionEntradaBombaMax { get; set; } = 0;
        public decimal DoPresionEntradaBombaMin { get; set; } = 0;

        #endregion DoPresionEntradaBomba

        #region DoVelocidadBomba

        public bool DoVelocidadBomba { get; set; } = false;
        public decimal DoVelocidadBombaMax { get; set; } = 0;
        public decimal DoVelocidadBombaMin { get; set; } = 0;

        #endregion DoVelocidadBomba

        #region DoVelocidadUnidadBombeo

        public bool DoVelocidadUnidadBombeo { get; set; } = false;
        public decimal DoVelocidadUnidadBombeoMax { get; set; } = 0;
        public decimal DoVelocidadUnidadBombeoMin { get; set; } = 0;

        #endregion DoVelocidadUnidadBombeo

        #region DoFrecuenciaOperacionBomba

        public bool DoFrecuenciaOperacionBomba { get; set; } = false;
        public decimal DoFrecuenciaOperacionBombaMax { get; set; } = 0;
        public decimal DoFrecuenciaOperacionBombaMin { get; set; } = 0;

        #endregion DoFrecuenciaOperacionBomba

        #region DoVelocidadMotor

        public bool DoVelocidadMotor { get; set; } = false;
        public decimal DoVelocidadMotorMax { get; set; } = 0;
        public decimal DoVelocidadMotorMin { get; set; } = 0;

        #endregion DoVelocidadMotor

        #region DoLongitudCarrera

        public bool DoLongitudCarrera { get; set; } = false;
        public decimal DoLongitudCarreraMax { get; set; } = 0;
        public decimal DoLongitudCarreraMin { get; set; } = 0;

        #endregion DoLongitudCarrera

        #region DoPresionDisponible

        public bool DoPresionDisponible { get; set; } = false;
        public decimal DoPresionDisponibleMax { get; set; } = 0;
        public decimal DoPresionDisponibleMin { get; set; } = 0;

        #endregion DoPresionDisponible

        #region DoGastoInyeccionFluidoPotencia

        public bool DoGastoInyeccionFluidoPotencia { get; set; } = false;
        public decimal DoGastoInyeccionFluidoPotenciaMax { get; set; } = 0;
        public decimal DoGastoInyeccionFluidoPotenciaMin { get; set; } = 0;

        #endregion DoGastoInyeccionFluidoPotencia

        #region DoGravedadEspecificaFluidoPotencia

        public bool DoGravedadEspecificaFluidoPotencia { get; set; } = false;
        public decimal DoGravedadEspecificaFluidoPotenciaMax { get; set; } = 0;
        public decimal DoGravedadEspecificaFluidoPotenciaMin { get; set; } = 0;

        #endregion DoGravedadEspecificaFluidoPotencia

        #region DoGastoGasInyeccion

        public bool DoGastoGasInyeccion { get; set; } = false;
        public decimal DoGastoGasInyeccionMax { get; set; } = 0;
        public decimal DoGastoGasInyeccionMin { get; set; } = 0;

        #endregion DoGastoGasInyeccion

        #region DoGravedadEspecificaGasInyeccion

        public bool DoGravedadEspecificaGasInyeccion { get; set; } = false;
        public decimal DoGravedadEspecificaGasInyeccionMax { get; set; } = 0;
        public decimal DoGravedadEspecificaGasInyeccionMin { get; set; } = 0;

        #endregion DoGravedadEspecificaGasInyeccion

        #region DoTorque

        public bool DoTorque { get; set; } = false;
        public decimal DoTorqueMax { get; set; } = 0;
        public decimal DoTorqueMin { get; set; } = 0;

        #endregion DoTorque

        #region DoCorriente

        public bool DoCorriente { get; set; } = false;
        public decimal DoCorrienteMax { get; set; } = 0;
        public decimal DoCorrienteMin { get; set; } = 0;

        #endregion DoCorriente

        #region DoDiametroEstrangulador

        public bool DoDiametroEstrangulador { get; set; } = false;
        public decimal DoDiametroEstranguladorMax { get; set; } = 0;
        public decimal DoDiametroEstranguladorMin { get; set; } = 0;

        #endregion DoDiametroEstrangulador

        #region DoTiempoCiclo

        public bool DoTiempoCiclo { get; set; } = false;
        public decimal DoTiempoCicloMax { get; set; } = 0;
        public decimal DoTiempoCicloMin { get; set; } = 0;

        #endregion DoTiempoCiclo

        #region DoTiempoRecuperacion

        public bool DoTiempoRecuperacion { get; set; } = false;
        public decimal DoTiempoRecuperacionMax { get; set; } = 0;
        public decimal DoTiempoRecuperacionMin { get; set; } = 0;

        #endregion DoTiempoRecuperacion

        #region DoTiempoInyeccion

        public bool DoTiempoInyeccion { get; set; } = false;
        public decimal DoTiempoInyeccionMax { get; set; } = 0;
        public decimal DoTiempoInyeccionMin { get; set; } = 0;

        #endregion DoTiempoInyeccion

        #region DoTiempoDesplazamientoTapon

        public bool DoTiempoDesplazamientoTapon { get; set; } = false;
        public decimal DoTiempoDesplazamientoTaponMax { get; set; } = 0;
        public decimal DoTiempoDesplazamientoTaponMin { get; set; } = 0;

        #endregion DoTiempoDesplazamientoTapon

        #region DoEficienciaLlenado

        public bool DoEficienciaLlenado { get; set; } = false;
        public decimal DoEficienciaLlenadoMax { get; set; } = 0;
        public decimal DoEficienciaLlenadoMin { get; set; } = 0;

        #endregion DoEficienciaLlenado

        #region Temporizador

        public TimeSpan CartaDinagrafica { get; set; } = TimeSpan.Zero;
        public TimeSpan DatosOperativos { get; set; } = TimeSpan.Zero;

        #endregion Temporizador

        #region CCartaDinagrafica

        public bool CCartaDinagrafica { get; set; } = false;
        public List<OCartaDinagrafica.CCartaDinagrafica> ListCCartaDinagrafica { get; set; } = new List<OCartaDinagrafica.CCartaDinagrafica>();

        #endregion CCartaDinagrafica
    }
}