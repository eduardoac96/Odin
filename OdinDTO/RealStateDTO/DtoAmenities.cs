﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinDTO
{
    public class DtoAmenities
    {
        public Guid AmenitieID { get; set; }
        public string AmenitieName { get; set; }
        public int Quantity { get;  set; }
        public string AmenitieDescription { get; set; }
    }
}
