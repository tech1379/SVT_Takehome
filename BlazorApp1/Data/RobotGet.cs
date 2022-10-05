using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Numerics;

namespace BlazorApp1.Data
{
    public class RobotGet
    {
      

        public async Task<List<Robot>> GetRobotData()
        {
                using HttpClient client = new();
                using var response = await client.GetAsync($"https://60c8ed887dafc90017ffbd56.mockapi.io/robots");
                var stream = await response.Content.ReadAsStringAsync();

                var model = JsonConvert.DeserializeObject<List<Robot>>(stream);


                return model;
            
        }
    }
}