using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdinData;
using OdinData.Mocks;
using OdinService;
using System.Collections.Generic;

namespace OdinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly ILogger<PropertiesController> _logger; 
        private PropertiesService _propertiesService;

        public PropertiesController(ILogger<PropertiesController> logger, IPropertiesData propertiesData)
        {
            _logger = logger; 
            _propertiesService = new PropertiesService(propertiesData);

        }

        [HttpGet("GetTypes")]
        public List<OdinDTO.DtoPropertyType> GetPropertyTypes()
        { 
            return _propertiesService.GetPropertyTypes();
        }
        [HttpGet]
        public List<OdinDTO.DtoRealState> GetRealState()
        { 
            return _propertiesService.GetRealState();
        }

        [HttpGet]
        public List<OdinDTO.DtoSaleType> GetSaleTypes()
        {
            return _propertiesService.GetSaleTypes();
        }

        [HttpGet]
        public List<OdinDTO.DtoAmenities> GetAmenities()
        { 
            return _propertiesService.GetAmenities();
        }

    }
}
