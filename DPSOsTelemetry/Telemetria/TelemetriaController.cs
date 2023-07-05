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
                if (select)
                    referencias.DatosOperativosSends++;
                else
                    referencias.CartaDinagraficaSends++;

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
                        //client = new RestClient("https://api-dpsos-dev.entecprois.com/api/PozoTomaInformacion");

                        OTomaInformacion.CTomaInformacion CTomaInformacion = new OTomaInformacion.CTomaInformacion()
                        {
                            Fecha = DateTime.UtcNow,
                            Token = referencias.Token,
                            PozoId = referencias.Name,
                            DatosOperativos = referencias.DatosOperativos
                        };
                        request.AddJsonBody(CTomaInformacion);
                    }
                    else
                    {
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

                    if (select)
                    {
                        OTomaInformacion.CResult _result = JsonConvert.DeserializeObject<OTomaInformacion.CResult>(response.Content);

                        if (_result.Success)
                            referencias.DatosOperativosComplete++;
                        else
                            referencias.DatosOperativosFails++;
                    }
                    else
                    {
                        OCartaDinagrafica.CResult _result = JsonConvert.DeserializeObject<OCartaDinagrafica.CResult>(response.Content);

                        if (_result.Success)
                            referencias.CartaDinagraficaComplete++;
                        else
                            referencias.CartaDinagraficaFails++;
                    }
                }
                catch
                {
                    if (select)
                        referencias.DatosOperativosFails++;
                    else
                        referencias.CartaDinagraficaFails++;
                }

                return referencias;
            });
        }
    }
}
