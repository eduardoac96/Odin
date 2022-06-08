using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinDAL
{
    public interface IRealStateDAL
    {
        List<DtoRealStateTypes> GetRealStateTypes();
        List<DtoAmenities> GetAmenities();
        List<DtoSaleType> GetSaleTypes();
        List<DtoRealState> GetRealState();
    }
}
