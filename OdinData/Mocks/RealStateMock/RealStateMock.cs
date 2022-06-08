using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinDAL.Mocks
{
    public class RealStateMock : IRealStateDAL
    {
        public List<DtoRealStateTypes> GetRealStateTypes()
        {
            return new List<DtoRealStateTypes>()
            {
                new DtoRealStateTypes()
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Departamento",
                    PropertyTypeDescription = ""
                },
                       new DtoRealStateTypes()
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Casa",
                    PropertyTypeDescription = ""
                },
                              new DtoRealStateTypes()
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Condominio",
                    PropertyTypeDescription = ""
                },
                    new DtoRealStateTypes
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Quintas",
                    PropertyTypeDescription = ""
                },
                    new DtoRealStateTypes
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Loft",
                    PropertyTypeDescription = ""
                },
            };
        }

        public List<DtoAmenities> GetAmenities()
        {
            return new List<DtoAmenities>()
            {
                new DtoAmenities()
                {
                    AmenitieID = Guid.NewGuid(),
                    AmenitieName = "",
                    AmenitieDescription = ""
                },
                   new DtoAmenities()
                {
                    AmenitieID = Guid.NewGuid(),
                    AmenitieName = "",
                    AmenitieDescription = ""
                },   new DtoAmenities()
                {
                    AmenitieID = Guid.NewGuid(),
                    AmenitieName = "",
                    AmenitieDescription = ""
                },   new DtoAmenities()
                {
                    AmenitieID = Guid.NewGuid(),
                    AmenitieName = "",
                    AmenitieDescription = ""
                },   new DtoAmenities()
                {
                    AmenitieID = Guid.NewGuid(),
                    AmenitieName = "",
                    AmenitieDescription = ""
                },
            };
        }

        public List<DtoRealState> GetRealStates()
        {
            return new List<DtoRealState>() { };
        }

        public List<DtoSaleType> GetSaleTypes()
        {
            return new List<DtoSaleType>();
        }

        public List<DtoRealState> GetRealState()
        {
            throw new NotImplementedException();
        }
    }
}
