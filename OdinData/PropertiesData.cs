using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinData
{
    public class PropertiesData : IPropertiesData
    { 
        private IPropertiesData _propertiesData = null;

        public List<DtoAmenities> GetAmenities()
        {
            return _propertiesData.GetAmenities();
        }

        public List<DtoPropertyType> GetPropertyTypes()
        {
            return _propertiesData.GetPropertyTypes();
        }

        public List<DtoSaleType> GetSaleTypes()
        {
            return _propertiesData.GetSaleTypes();
        }

        public List<DtoRealState> GetRealState()
        {
            return _propertiesData.GetRealState();
        }

    }
}
