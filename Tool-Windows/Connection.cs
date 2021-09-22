using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using MongoDB.Driver;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Tool_Windows
{
    class Connection
    {
        private string uri;
        private static readonly string uriApi = "https://api-artikel.herokuapp.com";
        public IMongoClient client;
        public Connection()
        {
            uri = "mongodb+srv://cr4r:2XradjHDeyXENFyt@datablog.fqkmh.mongodb.net/blog?retryWrites=true&w=majority";
        }

        public bool konekDB()
        {
            try
            {
                client = new MongoClient(uri);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saat konekDB!!! => "+e.ToString());
                return false;
            }
        }

        public static async Task<string> getApi(string tujuan = "/")
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
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
            catch
            {
                return $"Error!\nAda kesalahan dalam koneksi";
            }
            return string.Empty;
        }

        public static async Task<string> postApi(Dictionary<string, string> dataStr = null, string tujuan = "/", string type = "post")
        {
            var inputData = new FormUrlEncodedContent(dataStr);
            try
            {
                using (HttpClient client = new HttpClient())
                {
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
