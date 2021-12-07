using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmbeddedProject
{
   internal class ApiRead
    {

        private static readonly HttpClient httpClient = new HttpClient();
        private const string READ_FIELDS_API_URL = "https://api.thingspeak.com/channels/1587340/feeds/last.json?api_key=M2T80BJ533UVAQS0";
        public async static Task<List<int>> GetFields()
        {
            HttpResponseMessage response = await httpClient.GetAsync(READ_FIELDS_API_URL);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            //responseBody = responseBody.Replace("\"", "");
            
            dynamic responseObject = JsonConvert.DeserializeObject(responseBody);

            var fieldsList = new List<int>
            {
                (int) responseObject["field1"],
                (int) responseObject["field2"],
                (int) responseObject["field3"]
            };

            return fieldsList;
        }
    }
}
