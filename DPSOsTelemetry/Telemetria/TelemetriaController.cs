using Newtonsoft.Json;
using RestSharp;
using System;
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
                    RestClient client = new RestClient();
                    RestRequest request = new RestRequest()
                    {
                        Method = Method.Post,
                    };
                    request.AddHeader("Content-Type", "application/json");
                    client = new RestClient($"https://api-dpsos-dev.entecprois.com/api/PozoTomaInformacion/telemetria?token={referencias.Token}");
                    if (select)
                    {
                        request.AddJsonBody(referencias.DatosOperativos);
                    }
                    else
                    {
                        request.AddJsonBody(referencias.DatosCarta);
                    }

                    RestResponse response = await client.ExecuteAsync(request);

                    bool Success;
                    bool.TryParse(response.Content, out Success);

                    if (select)
                        referencias.DatosOperativosBool = Success;
                    else
                        referencias.CartaDinagraficaBool = Success;
                }
                catch
                {
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
        public bool Success { set; get; } = false;

        public string Message { set; get; } = "N/D";
    }
}