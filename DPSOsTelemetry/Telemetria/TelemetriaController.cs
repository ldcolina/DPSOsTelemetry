using Newtonsoft.Json;
using RestSharp;
using System.Net.Mail;
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
                        switch (referencias.Unidades)
                        {
                            case "0": //Oilfield
                                {
                                    client = new RestClient("https://en.entecprois.com/api/v1/telemetry/informationgathering/");
                                    break;
                                }
                            case "3": //English
                            case "1": //SI
                            case "4": //Latin_SI
                            default: //Mexico
                                {
                                    client = new RestClient("https://dpsos.entecprois.com/api/v1/telemetry/informationgathering/");
                                    break;
                                }
                        }

                        OTomaInformacion.CTomaInformacion CTomaInformacion = new OTomaInformacion.CTomaInformacion()
                        {
                            Time = System.DateTimeOffset.Now,
                            Token = referencias.Token,
                            DatosOperativos = referencias.DatosOperativos
                        };
                        request.AddJsonBody(CTomaInformacion);
                    }
                    else
                    {
                        switch (referencias.Unidades)
                        {
                            case "0": //Oilfield
                                {
                                    client = new RestClient("https://en.entecprois.com/api/v1/cartadinagrafica/");
                                    break;
                                }
                            case "3": //English
                            case "1": //SI
                            case "4": //Latin_SI
                            default: //Mexico
                                {
                                    client = new RestClient("https://dpsos.entecprois.com/api/v1/cartadinagrafica/");
                                    break;
                                }
                        }

                        OCartaDinagrafica OCartaDinagrafica = new OCartaDinagrafica()
                        {
                            Time = System.DateTimeOffset.Now,
                            Token = referencias.Token,
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
                    Send(new correo()
                    {
                        referencias = referencias,
                        select = select
                    });

                    if (select)
                        referencias.DatosOperativosFails++;
                    else
                        referencias.CartaDinagraficaFails++;
                }

                return referencias;
            });
        }

        private class correo
        {
            public ReferenciasI referencias;
            public bool select;
        }

        private static void Send(correo referencias)
        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.IsBodyHtml = true;
                    mailMessage.BodyEncoding = Encoding.UTF8;
                    mailMessage.SubjectEncoding = Encoding.UTF8;

                    mailMessage.From = new MailAddress($"lizcolina1@gmail.com", "DPSO's Telemetría", Encoding.UTF8);
                    mailMessage.To.Add("ldcolinar@entecprois.com");

                    mailMessage.Subject = "Transmisión de datos";

                    mailMessage.Body = JsonConvert.SerializeObject(referencias);

                    using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtpClient.Credentials = new System.Net.NetworkCredential("lizcolina1@gmail.com", "zwqpumihulqseajk");
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mailMessage);
                    }
                }
            }
            catch
            {
            }
        }
    }
}