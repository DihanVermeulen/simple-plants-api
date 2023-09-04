using System.Text.Json;
using SimplePlantsApi.Models;

namespace SimplePlantsApi
{
    public class JsonFileAllPlantsService
    {
        public JsonFileAllPlantsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        /*
            Finds the webroot (wwwroot) folder and returns the pokemon json file name.
        */
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "AllPlants.json"); }
        }

        public AllPlantsApiResponse GetPlants()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<AllPlantsApiResponse>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }
    }
}
