using OdinData;
using OdinData.Mocks;
using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinService
{
    public class PropertiesService : IPropertiesData
    {
        public IPropertiesData _propertiesData = null;


        public PropertiesService(IPropertiesData propertiesData)
        {
            _propertiesData = propertiesData;
        }
        public List<DtoPropertyType> GetPropertyTypes()
        {
            return _propertiesData.GetPropertyTypes();
        }

        public List<DtoAmenities> GetAmenities()
        {
            throw new NotImplementedException();
        }

        public List<DtoSaleType> GetSaleTypes()
        {
            throw new NotImplementedException();
        } 

        public List<DtoRealState> GetRealState()
        {
            throw new NotImplementedException();
        }
    }
}
