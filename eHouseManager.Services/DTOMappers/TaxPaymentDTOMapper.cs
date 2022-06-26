using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOMappers
{
    public static class TaxPaymentDTOMapper
    {
        public static TaxPaymentDTO ToDTO(this TaxPayment model)
        {
            return new TaxPaymentDTO
            {
                Amount = model.Amount,
                ApartmentId = model.ApartmentId,
                DueAmount = model.DueAmount,
                Id = model.Id,
                Month = model.Month,
                PaidAmount = model.PaidAmount,
                PaidOn = model.PaidOn,
                Year = model.Year
            };
        }

        public static TaxPayment ToEntity(this TaxPaymentDTO model)
        {
            return new TaxPayment
            {
                Amount = model.Amount,
                ApartmentId = model.ApartmentId,
                DueAmount = model.DueAmount,
                Id = model.Id,
                Month = model.Month,
                PaidAmount = model.PaidAmount,
                PaidOn = model.PaidOn,
                Year = model.Year
            };
        }
    }
}
