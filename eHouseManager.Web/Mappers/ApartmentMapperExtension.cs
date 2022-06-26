using eHouseManager.Services.DTOs;
using eHouseManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Mappers
{
    public static class ApartmentMapperExtension
    {
        public static UserApartmentViewModel GetUserApartmentModel(this ApartmentDTO model)
        {
            return new UserApartmentViewModel
            {
                Id = model.Id,
                ApartmentNumber = model.ApartmentNumber,
                Address = model.Address,
                AreTaxesPaid = model.AreTaxesPaid,
                TaxPayments = model.TaxPaymentDTOs,
                Area = model.Area,
                UcnNumber = model.UcnNumber
            };
        }

        public static UserApartmentViewModel GetAllApartmentModel(this ApartmentDTO model)
        {
            return new UserApartmentViewModel
            {
                Id = model.Id,
                ApartmentNumber = model.ApartmentNumber,
                Address = model.Address,
                AreTaxesPaid = model.AreTaxesPaid,
                Area = model.Area,
                InhabitantsCount = model.InhabitantsCount,
                Owner = model.Owner,
                UcnNumber = model.UcnNumber
            };
        }

        public static ApartmentDTO GetCreateApartmentDTO(this UserApartmentViewModel model)
        {
            return new ApartmentDTO
            {
                Id = model.Id,
                ApartmentNumber = model.ApartmentNumber,
                Address = model.Address,
                AreTaxesPaid = model.AreTaxesPaid,
                Area = model.Area,
                InhabitantsCount = model.InhabitantsCount,
                Owner = model.Owner,
                UcnNumber = model.UcnNumber
            };
        }

        public static ApartmentDTO GetUpdateApartmentDTO(this UserApartmentViewModel model)
        {
            return new ApartmentDTO
            {
                Id = model.Id,
                ApartmentNumber = model.ApartmentNumber,
                Address = model.Address,
                AreTaxesPaid = model.AreTaxesPaid,
                Area = model.Area,
                InhabitantsCount = model.InhabitantsCount,
                Owner = model.Owner,
                UcnNumber = model.UcnNumber
            };
        }

        public static UserApartmentViewModel GetUpdateApartmentModel(this ApartmentDTO model)
        {
            return new UserApartmentViewModel
            {
                Id = model.Id,
                ApartmentNumber = model.ApartmentNumber,
                Address = model.Address,
                AreTaxesPaid = model.AreTaxesPaid,
                Area = model.Area,
                InhabitantsCount = model.InhabitantsCount,
                Owner = model.Owner,
                UcnNumber = model.UcnNumber
            };
        }
    }
}
