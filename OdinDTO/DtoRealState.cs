using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinDTO
{
    public class DtoRealState
    {
        public int RealStateID { get; set; }
        public string RealStateName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Address { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public decimal? InitialPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public List<DtoAmenities> Amenities { get; set; }
        public DtoPropertyType PropertyType { get; set; }
        public DtoSaleType SaleType { get; set; }
    }
}
