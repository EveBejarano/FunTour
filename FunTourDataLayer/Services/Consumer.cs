using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunTourDataLayer.Services
{
    public class Consumer<TEntity> where TEntity : class
    {
        public async Task<TEntity> ReLoadEntities(string URL, string typeRequest, object ModelRequest)
        {
            var ModelResponse = await GetEntitiesFromAPIReturnModelRequest(URL, typeRequest, ModelRequest);

            return ModelResponse;
        }


        private async Task<TEntity> GetEntitiesFromAPIReturnModelRequest(string URL, string typeRequest,
            object ModelRequest)
        {
            var Url = URL;

            string data;

            var Json = JsonConvert.SerializeObject(ModelRequest);
            var request = new StringContent(Json, Encoding.UTF8, "application/json");

            var client = new HttpClient();

            switch (typeRequest)
            {
                case "PUT":
                    using (var res = await client.PutAsync(Url, request))
                    {
                        using (var content = res.Content)
                        {
                            data = await content.ReadAsStringAsync();
                        }
                    }

                    break;
                case "GET":
                    using (var res = await client.GetAsync(Url))
                    {
                        using (var content = res.Content)
                        {
                            data = await content.ReadAsStringAsync();
                        }
                    }

                    break;
                case "POST":
                    using (var res = await client.PostAsync(Url, request))
                    {
                        using (var content = res.Content)
                        {
                            data = await content.ReadAsStringAsync();
                        }
                    }

                    break;
                default:
                    data = "";
                    break;
            }


            return JsonConvert.DeserializeObject<TEntity>(data);
        }
    }
}