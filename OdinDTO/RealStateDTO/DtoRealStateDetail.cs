using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinDTO
{
    public class DtoRealStateDetail
    {
        public Guid RealStateID { get; set; }
        public List<string> RealStateImageURLs { get; set; }

        public string LongDescription { get; set; }

        public double LandMeters { get; set; }
        public int LeaseDurationMonths { get; set; }

        public List<DtoAmenities> Amenities { get; set; }


    }
}
