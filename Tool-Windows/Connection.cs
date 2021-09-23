using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;

namespace Tool_Windows
{
    class Connection
    {
        private static readonly string uriApi = "https://api.coders-family.me";
        public Connection()
        {
        }

        public async Task<bool> konekDB()
        {
            try
            {
                var pingServer = await getApi();
                Console.WriteLine("True " + pingServer );
                var hasil = JsonConvert.DeserializeObject<Dictionary<string, string>>(pingServer);
                if(hasil["status"] == "ok")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saat konekDB!!! => "+e.ToString());
                return false;
            }
        }

        private static void bersih(HttpClient client = null)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            client.DefaultRequestHeaders.Add("keyApi", @"fh38j$jdk95%^&#Gk$!@#05*(");
        }

        public static async Task<string> getApi(string tujuan = "/")
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    bersih(client);
                    using (HttpResponseMessage res = await client.GetAsync(uriApi + tujuan))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                return $"Error!\n{e}";
            }
            return string.Empty;
        }

        public static async Task<string> postApi(Dictionary<string, string> dataStr = null, string tujuan = "/")
        {
            var inputData = new FormUrlEncodedContent(dataStr);
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    bersih(client);
                    using (HttpResponseMessage res = await client.PostAsync(uriApi + tujuan, inputData))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
            }
            catch
            {
                return $"Error!\nAda kesalahan dalam koneksi";
            }
            return string.Empty;
        }


        public static string BeautifyJson(string jsonStr)
        {
            try
            {
                JToken parseToken = JToken.Parse(jsonStr);
                return parseToken.ToString(Formatting.Indented);
            }
            catch
            {
                return jsonStr;
            }
        }
    }
}
