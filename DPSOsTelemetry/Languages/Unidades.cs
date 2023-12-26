using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Languages
{
    public enum Referencia
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
        public static string GetSigla(Referencia tipo, string unidad)
        {
            try
            {
                switch (tipo)
                {
                    case Referencia.Presion:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Siglas.Psi;

                                case "1": //SI
                                    return Siglas.Pascal;

                                case "4": //Latin_SI
                                default: //Mexico
                                    return Siglas.KilogramoFuerza_CentimetroElevadoDos;
                            }
                        }
                    case Referencia.Temperatura:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Siglas.Fahrenheit;

                                case "1": //SI
                                    return Siglas.Kelvin;

                                case "4": //Latin_SI
                                default: //Mexico
                                    return Siglas.Celsius;
                            }
                        }
                    case Referencia.Distancia:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Siglas.Pie;

                                case "1": //SI
                                case "4": //Latin_SI
                                default: //Mexico
                                    return Siglas.Metro;
                            }
                        }
                    case Referencia.Diametro:
                        {
                            switch (unidad)
                            {
                                case "1": //SI
                                case "4": //Latin_SI
                                    return Siglas.Centimetro;

                                case "0": //Oilfield
                                case "3": //English
                                default: //Mexico
                                    return Siglas.Pulgada;
                            }
                        }
                    case Referencia.RelacionGasAceite:
                        {
                            switch (unidad)
                            {
                                case "0": //Oilfield
                                case "3": //English
                                    return Siglas.PieCubicoEstandarPorBarrilTanqueReserva;

                                case "1": //SI
                                case "4": //Latin_SI
                                default: //Mexico
                                    return Siglas.MetroCubicoPorMetroCubico;
                            }
                        }
                    case Referencia.Fuerza:
                        {
                            switch (unidad)
                            {
                                case "1": //SI
                                case "4": //Latin_SI
                                    return Siglas.Newton;

                                case "0": //Oilfield
                                case "3": //English
                                default: //Mexico
                                    return Siglas.KilolibraFuerza;
                            }
                        }
                    case Referencia.Potencia:
                        {
                            switch (unidad)
                            {
                                case "1": //SI
                                case "4": //Latin_SI
                                    return Siglas.Kilovatio;

                                case "0": //Oilfield
                                case "3": //English
                                default: //Mexico
                                    return Siglas.Caballo;
                            }
                        }

                    #region Valores fijos

                    case Referencia.Aceite:
                        {
                            return Siglas.BarrilesAceite;
                        }
                    case Referencia.Angulo:
                        {
                            return Siglas.Grado;
                        }
                    case Referencia.Anio:
                        {
                            return Siglas.Anio;
                        }
                    case Referencia.Corriente:
                        {
                            return Siglas.Amperios;
                        }
                    case Referencia.Densidad:
                        {
                            return Siglas.GradosApi;
                        }
                    case Referencia.Dia:
                        {
                            return Siglas.Dia;
                        }
                    case Referencia.Embolada:
                        {
                            return Siglas.EmboladaPorMinuto;
                        }
                    case Referencia.FactorVolumetrico:
                        {
                            return Siglas.BarrilPetroleoPorBarrilTanqueExistencias;
                        }
                    case Referencia.FactorVolumetricoAceite:
                        {
                            return Siglas.BarrilesAceitePorDia;
                        }
                    case Referencia.FlujoVolumetricoGas:
                        {
                            return Siglas.MilesPieElevadoTresPorDia;
                        }
                    case Referencia.FlujoVolumetricoLiquido:
                        {
                            return Siglas.BarrilesPetroleoPorDia;
                        }
                    case Referencia.Frecuencia:
                        {
                            return Siglas.Hercio;
                        }
                    case Referencia.GastoGas:
                        {
                            return Siglas.MillonesPieElevadoTresPorDia;
                        }
                    case Referencia.Hora:
                        {
                            return Siglas.Hora;
                        }
                    case Referencia.IndiceProductividad:
                        {
                            return $"{Siglas.BarrilesPetroleoPorDia}/{Siglas.Psi}";
                        }
                    case Referencia.Liquido:
                        {
                            return Siglas.BarrilesLiquido;
                        }
                    case Referencia.Longitud_Carta:
                        {
                            return Siglas.Pulgada;
                        }
                    case Referencia.Mes:
                        {
                            return Siglas.Mes;
                        }
                    case Referencia.Minuto:
                        {
                            return Siglas.Minuto;
                        }
                    case Referencia.Porcentaje:
                        {
                            return Siglas.Porcentaje;
                        }
                    case Referencia.Presion2:
                        {
                            return Siglas.PulgadaAgua60GradosF;
                        }
                    case Referencia.Segundo:
                        {
                            return Siglas.Segundo;
                        }
                    case Referencia.Tension:
                        {
                            return Siglas.Kpsi;
                        }
                    case Referencia.Torque:
                        {
                            return $"{Siglas.LibraFuerza}-{Siglas.Pie}";
                        }
                    case Referencia.Velocidad:
                        {
                            return Siglas.Revolucion_Minuto;
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
}