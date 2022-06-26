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
                Id = model.Id,
                ApartmentNumber = model.ApartmentNumber,
                Area = model.Area,
                InhabitantsCount = model.InhabitantsCount,
                ModifiedBy = model.ModifiedBy,
                Owner = model.Owner,
                AreTaxesPaid = model.AreTaxesPaid,
                Address = model.Address,
                TaxPaymentDTOs = PopulateTaxpayments(model.TaxPayments)
            };
        }

        public static Apartment ToEntity(this ApartmentDTO model)
        {
            return new Apartment
            {
                Id = model.Id,
                ApartmentNumber = model.ApartmentNumber,
                Area = model.Area,
                InhabitantsCount = model.InhabitantsCount,
                ModifiedBy = model.ModifiedBy,
                Owner = model.Owner,
                AreTaxesPaid = model.AreTaxesPaid,
                Address = model.Address
            };
        }

        private static IEnumerable<TaxPaymentDTO> PopulateTaxpayments(IEnumerable<TaxPayment> models)
        {
            foreach (var item in models)
            {
                yield return item.ToDTO();
            }
        }
    }
}
