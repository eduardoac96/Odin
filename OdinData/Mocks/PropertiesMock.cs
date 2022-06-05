using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinData.Mocks
{
    public class PropertiesMock : IPropertiesData
    {
        public List<DtoPropertyType> GetPropertyTypes()
        {
            return new List<DtoPropertyType>()
            {
                new DtoPropertyType()
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Departamento",
                    PropertyTypeDescription = ""
                },
                       new DtoPropertyType()
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Casa",
                    PropertyTypeDescription = ""
                },
                              new DtoPropertyType()
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Condominio",
                    PropertyTypeDescription = ""
                },
                    new DtoPropertyType
                {
                    PropertyTypeID = Guid.NewGuid(),
                    PropertyTypeName = "Quintas",
                    PropertyTypeDescription = ""
                },
                    new DtoPropertyType
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
