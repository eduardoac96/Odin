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
        [HttpGet("GetRealStateTypes")]
        public List<OdinDTO.DtoRealStateTypes> GetRealStateTypes()
        { 
            return _realStateService.GetRealStateTypes();
        }
        [HttpGet("GetRealState")]
        public List<OdinDTO.DtoRealState> GetRealState()
        { 
            return _realStateService.GetRealState();
        }

        [HttpGet("GetSaleTypes")]
        public List<OdinDTO.DtoSaleType> GetSaleTypes()
        {
            return _realStateService.GetSaleTypes();
        }

        [HttpGet("GetAmenities")]
        public List<OdinDTO.DtoAmenities> GetAmenities()
        { 
            return _realStateService.GetAmenities();
        }

    }
}
