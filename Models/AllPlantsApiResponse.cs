using System.Text.Json.Serialization;

namespace SimplePlantsApi.Models
{
    public class AllPlantsApiResponse
    {
        [JsonPropertyName("data")]
        public List<Plant> Data { get; set; }

        public AllPlantsApiResponse(List<Plant> data)
        {
            Data = data;
        }
    } 
}