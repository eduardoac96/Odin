using OdinDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinData
{
    public class RealStateData
    {
        public List<DtoAmenities> GetAmenities()
        {
            return new List<DtoAmenities>()
            {
                new DtoAmenities()
                {
                    AmenitieID = 1,
                    AmenitieName = "Banos",
                    Quantity = 2
                },
                new DtoAmenities()
                {
                    AmenitieID = 2,
                    AmenitieName = "Campo de golf",
                    Quantity = 1
                },
                new DtoAmenities()
                {
                    AmenitieID = 3,
                    AmenitieName = "Cancha de tenis",
                    Quantity = 1
                },
                new DtoAmenities()
                {
                    AmenitieID = 4,
                    AmenitieName = "Alberca",
                    Quantity = 1
                } 
            };
        }

        public List<DtoSaleType> GetSaleTypes()
        {
            return new List<DtoSaleType>()
            {
                new DtoSaleType()
                {
                    SaleTypeID = 1,
                    SaleTypeName = "Venta"
                },

                new DtoSaleType()
                {
                    SaleTypeID = 2,
                    SaleTypeName = "Renta"
                },

            };
        }

        public List<DtoPropertyType> GetPropertyTypes()
        {
            return new List<DtoPropertyType>()
            {
                new DtoPropertyType()
                {
                    PropertyTypeID= 1,
                    PropertyTypeName = "Casa",
                    PropertyTypeDescription = ""
                },
                new DtoPropertyType()
                {
                    PropertyTypeID= 2,
                    PropertyTypeName = "Departamento",
                    PropertyTypeDescription = ""
                },
                new DtoPropertyType()
                {
                    PropertyTypeID= 3,
                    PropertyTypeName = "Terreno",
                    PropertyTypeDescription = ""
                },
                new DtoPropertyType()
                {
                    PropertyTypeID= 4,
                    PropertyTypeName = "Loft",
                    PropertyTypeDescription = ""
                },
                new DtoPropertyType()
                {
                    PropertyTypeID= 1,
                    PropertyTypeName = "Condominio",
                    PropertyTypeDescription = ""
                }
            };
        }

       
    }
}
