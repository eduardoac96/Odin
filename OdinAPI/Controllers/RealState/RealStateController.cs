using Microsoft.AspNetCore.Mvc;
using OdinService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OdinAPI.Controllers.RealState
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealStateController : ControllerBase
    {
        private RealStateService _realStateService;

        public RealStateController()
        {
            _realStateService = new RealStateService();
        }
         
        [HttpGet]
        public IEnumerable<OdinDTO.DtoAmenities> GetAmenities()
        {
            return _realStateService.GetAmenities();
        }

        [HttpGet]
        public IEnumerable<OdinDTO.DtoPropertyType> GetPropertyTypes()
        {
            return _realStateService.GetPropertyTypes();
        }
         
        [HttpGet]
        public IEnumerable<OdinDTO.DtoSaleType> GetSaleTypes()
        {
            return _realStateService.GetSaleTypes();
        }
            
    }
}
