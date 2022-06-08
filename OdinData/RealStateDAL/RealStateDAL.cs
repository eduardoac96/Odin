using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinDAL
{
    public class RealStateDAL : IRealStateDAL
    { 
        private IRealStateDAL _realStateDAL = null;

        public List<DtoAmenities> GetAmenities()
        {
            return _realStateDAL.GetAmenities();
        }

        public List<DtoRealStateTypes> GetRealStateTypes()
        {
            return _realStateDAL.GetRealStateTypes();
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
