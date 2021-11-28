using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApiCall
{
    internal class ApiWrite
    {
        private static readonly HttpClient httpClient = new();
        private const string WRITE_API_URL = "https://api.thingspeak.com/update?api_key=HC4WDU6WBMSPIWKS";

        public async static Task SaveFields(int alarmHour, int alarmMinute, int startBefore)
        {
            string saveUrl = WRITE_API_URL + "&field1=" + alarmHour + "&field2=" + alarmMinute + "&field3=" + startBefore;
            
            HttpResponseMessage responseMessage = await httpClient.GetAsync(saveUrl);
            responseMessage.EnsureSuccessStatusCode();
        }
    }
}
