using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment1.Data
{
    public class AdultService : IAdultsService
    {
        private string uri = "http://dnp.metamate.me";
        private readonly HttpClient client;

        public AdultService()
        {
            client = new HttpClient();
        }


        public async Task<IList<Adult>> GetAdultsAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            await client.PutAsync("http://dnp.metamate.me/Adults", content);
        }

        public async Task RemoveAdultAsync(int Id)
        {
            await client.DeleteAsync($"{uri}/Adults/{Id}");
        }
    }
}