using JsonRequestResponseService.Models;
using JsonRequestResponseService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JsonRequestResponseService.Controllers
{
    [Route("api/garage")]
    [ApiController]
    public class GarageController : ControllerBase
    {
        private readonly GarageService garageService;
        public GarageController()
        {
            garageService = new GarageService();
        }

        [HttpPost]
        public GarageResponse Post([FromBody] GarageRequest data)
        {
            return garageService.GarageModification(data);
        }
    }
}