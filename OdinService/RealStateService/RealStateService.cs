using OdinDAL;
using OdinDAL.Mocks;
using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinService
{
    public class RealStateService : IRealStateDAL
    {
        public IRealStateDAL _realStateDAL = null;


        public RealStateService(IRealStateDAL realStateDAL)
        {
            _realStateDAL = realStateDAL;
        }
        public List<DtoRealStateTypes> GetPropertyTypes()
        {
            return _realStateDAL.GetPropertyTypes();
        }

        public List<DtoAmenities> GetAmenities()
        {
            return _realStateDAL.GetAmenities();
        }

        public List<DtoSaleType> GetSaleTypes()
        {
            return _realStateDAL.GetSaleTypes();
        } 

        public List<DtoRealState> GetRealState()
        {
            return _realStateDAL.GetRealState();
        }
    }
}
