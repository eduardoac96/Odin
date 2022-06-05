using OdinData;
using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinService
{
    public class RealStateService
    {
        private RealStateData _realStateData;

        public RealStateService()
        {
            _realStateData = new RealStateData();
        }

        public List<DtoAmenities> GetAmenities()
        {
            return _realStateData.GetAmenities() ?? new List<DtoAmenities>();
        }

        public List<DtoSaleType> GetSaleTypes()
        {
            return _realStateData.GetSaleTypes() ?? new List<DtoSaleType>();
        }

        public List<DtoPropertyType> GetPropertyTypes()
        {
            return _realStateData.GetPropertyTypes() ?? new List<DtoPropertyType>(); 
        }
    }
}
