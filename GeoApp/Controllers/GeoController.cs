using GeoApp.Infrastructure;
using GeoApp.Model;
using GeoApp.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GeoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeoController : ControllerBase
    {
        private readonly ILogger<GeoController> _logger;
        private readonly GeoService _geoService;
        public GeoController(IGeoStoreRepository repository, ILogger<GeoController> logger)
        {
            _logger = logger;
            _geoService = new GeoService(repository);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var myGeo = _geoService.GetObjectById(id);
            if (myGeo == null)
                return new NotFoundResult();

            return new OkObjectResult(myGeo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] GeoObject newGeoObject)
        {
            _geoService.SaveNewObject(newGeoObject);
            return new OkResult();
        }

    }
}
