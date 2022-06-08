using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdinDAL;
using OdinService;
using System.Collections.Generic;

namespace OdinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealStateController : ControllerBase
    {
        private readonly ILogger<RealStateController> _logger; 
        private RealStateService _realStateService;

        public RealStateController(ILogger<RealStateController> logger, IRealStateDAL realStateDAL)
        {
            _logger = logger; 
            _realStateService = new RealStateService(realStateDAL);

        }
        [HttpGet]
        public List<OdinDTO.DtoRealStateTypes> GetPropertyTypes()
        { 
            return _realStateService.GetPropertyTypes();
        }
        [HttpGet]
        public List<OdinDTO.DtoRealState> GetRealState()
        { 
            return _realStateService.GetRealState();
        }

        [HttpGet]
        public List<OdinDTO.DtoSaleType> GetSaleTypes()
        {
            return _realStateService.GetSaleTypes();
        }

        [HttpGet]
        public List<OdinDTO.DtoAmenities> GetAmenities()
        { 
            return _realStateService.GetAmenities();
        }

    }
}
