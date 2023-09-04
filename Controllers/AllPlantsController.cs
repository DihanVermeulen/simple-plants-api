using Microsoft.AspNetCore.Mvc;
using SimplePlantsApi.Models;
using SimplePlantsApi.Services;

namespace PlantsApi.Controllers
{
    [ApiController]
    [Route("/plants")]
    public class AllPlantsController : ControllerBase
    {
        private readonly ILogger<AllPlantsController> _logger;
        private readonly JsonFileAllPlantsService _allPlantsService;
        public AllPlantsController(ILogger<AllPlantsController> logger, JsonFileAllPlantsService allPlantsService)
        {
            _logger = logger;
            _allPlantsService = allPlantsService;
        }

        [HttpGet(Name = "GetAllPlants")]
        public AllPlantsApiResponse Get()
        {
            return _allPlantsService.GetPlants();
        }
    }
}