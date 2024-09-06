using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Telemetria
{
    public static class TelemetriaController
    {
        /// <summary>
        /// Post
        /// </summary>
        /// <param name="referencias"> Datos de entrada </param>
        /// <param name="select">True: DatosOperativos / False: CartaDinagrafica </param>
        /// <returns></returns>
        public static async Task<ReferenciasI> Post(ReferenciasI referencias, bool select)
        {
            return await Task.Run(async () =>
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Definir la URL del servicio con el token
                        var url = $"https://api-dpsos-dev.entecprois.com/api/PozoTomaInformacion/telemetria?token={referencias.Token}";

                        // Seleccionar el cuerpo JSON según la condición y convertir el objeto a JSON
                        string jsonBody = select ? JsonConvert.SerializeObject(referencias.DatosOperativos) : JsonConvert.SerializeObject(referencias.DatosCarta);

                        // Crear el contenido de la solicitud
                        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                        // Hacer la solicitud POST
                        HttpResponseMessage response = await client.PostAsync(url, content);

                        // Verificar si la respuesta fue exitosa
                        if (response.IsSuccessStatusCode)
                        {
                            // Leer el contenido de la respuesta
                            string responseContent = await response.Content.ReadAsStringAsync();

                            bool success;
                            bool.TryParse(responseContent, out success);

                            if (select)
                                referencias.DatosOperativosBool = success;
                            else
                                referencias.CartaDinagraficaBool = success;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores opcional
                    Console.WriteLine("Error en la solicitud: " + ex.Message);
                }

                if (select)
                    referencias.DatosOperativosFinish = true;
                else
                    referencias.CartaDinagraficaFinish = true;

                return referencias;
            });
        }
    }

    public class CResult
    {
        public bool Success { get; set; } = false;

        public string Message { get; set; } = "N/D";
    }
}