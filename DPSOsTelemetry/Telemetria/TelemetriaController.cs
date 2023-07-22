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
                    if (select)
                    {
                        client = new RestClient($"https://api-dpsos-dev.entecprois.com/api/PozoTomaInformacion/telemetria?token={referencias.Token}");
                        request.AddJsonBody(referencias.DatosOperativos);
                    }
                    else
                    {
                        return referencias;

                        //client = new RestClient("https://api-dpsos-dev.entecprois.com/api/PozoTomaInformacion/carta-dinagrafica");

                        OCartaDinagrafica OCartaDinagrafica = new OCartaDinagrafica()
                        {
                            Fecha = DateTime.UtcNow,
                            Token = referencias.Token,
                            PozoId = referencias.Name,
                            CartaDinagrafica = referencias.CartaDinagrafica
                        };
                        request.AddJsonBody(OCartaDinagrafica);
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
}
