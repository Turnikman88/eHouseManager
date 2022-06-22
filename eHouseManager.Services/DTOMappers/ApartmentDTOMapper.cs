using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOMappers
{
    public static class ApartmentDTOMapper
    {
        public static ApartmentDTO ToDTO(this Apartment model)
        {
            return new ApartmentDTO
            {
                ApartmentID = model.ApartmentID,
                ApartmentNumber = model.ApartmentNumber,
                Area = model.Area,
                Inhabitants = model.Inhabitants,
                ModifiedBy = model.ModifiedBy,
                Owner = model.Owner
            };
        }

        public static Apartment ToEntity(this ApartmentDTO model)
        {
            return new Apartment
            {
                ApartmentID = model.ApartmentID,
                ApartmentNumber = model.ApartmentNumber,
                Area = model.Area,
                Inhabitants = model.Inhabitants,
                ModifiedBy = model.ModifiedBy,
                Owner = model.Owner
            };
        }
    }
}
