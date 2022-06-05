using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinData
{
    public interface IPropertiesData
    {
        List<DtoPropertyType> GetPropertyTypes();
        List<DtoAmenities> GetAmenities();
        List<DtoSaleType> GetSaleTypes();
        List<DtoRealState> GetRealState();
    }
}
