using Newtonsoft.Json;

namespace SampleApiCall
{
   internal class ApiRead
    {

        private static readonly HttpClient httpClient = new();
        private const string READ_FIELDS_API_URL = "https://api.thingspeak.com/channels/1587340/feeds/last.json?api_key=M2T80BJ533UVAQS0";
        public async static Task<List<int>> GetFields()
        {
            HttpResponseMessage response = await httpClient.GetAsync(READ_FIELDS_API_URL);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            
            dynamic responseObject = JsonConvert.DeserializeObject(responseBody);

            var fieldsList = new List<int>
            {
                (int) responseObject.field1,
                (int) responseObject.field2,
                (int) responseObject.field3
            };

            return fieldsList;
        }
    }
}
