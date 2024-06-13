using Client.Forms;
using Client.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utils
{
    public class ApiRequestUtils
    {
        private const string GotApiKey = "e54a5c43fbmsh6558a281c8d635dp1fec2bjsn49b042ef2124";
        private const string GotApiHost = "game-of-thrones1.p.rapidapi.com";
        private const string AiApiKey = "3c63d36196mshf52b6d6d5f70872p151e27jsnee1e2c6faf76";
        private const string AiApiHost = "open-ai21.p.rapidapi.com";

        public static async Task<string> SendGetRequest(string uri)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(uri),
                    Headers =
                    {
                        { "X-RapidAPI-Key", GotApiKey },
                        { "X-RapidAPI-Host", GotApiHost },
                    },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }

        public static async Task<string> SendPostRequest(string uri, string message)
        {
            //add key rotation and model key collection, hint: think of flag
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(uri),
                    Headers =
                    {
                        { "X-RapidAPI-Key", AiApiKey },
                        { "X-RapidAPI-Host", AiApiHost },
                    },
                    Content = new StringContent($"{{\"messages\": [{{\"role\": \"user\",\"content\": \"{message}\"}}],\"web_access\": false,\"system_prompt\": \"\",\"temperature\": 0.9,\"top_k\": 5,\"top_p\": 0.9,\"max_tokens\": 256}}")
                    {
                        Headers =
                            {
                                ContentType = new MediaTypeHeaderValue("application/json")
                            }
                    }
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }

        public static async Task<HttpWebResponse> SendValidationRequest(byte[] xmlData, string validationEndpoint, string acceptHeaderValue)
        {
            HttpWebRequest httpWebRequest = WebRequest.CreateHttp(validationEndpoint);
            httpWebRequest.Accept = acceptHeaderValue;
            httpWebRequest.Method = Constants.postMethod;
            httpWebRequest.ContentType = Constants.xml;

            using (Stream bodyRequest = httpWebRequest.GetRequestStream())
            {
                await bodyRequest.WriteAsync(xmlData, 0, xmlData.Length);
            }

            return (HttpWebResponse)await httpWebRequest.GetResponseAsync();
        }

        public static string GetValidationResultMessage(HttpWebResponse response)
        {
            if (response.StatusCode == HttpStatusCode.Accepted)
            {
                return Constants.validationPassed;
            }

            if (response.StatusCode == HttpStatusCode.PartialContent)
            {
                return Constants.validationFailed;
            }

            return Constants.badRequest;
        }
    }
}
