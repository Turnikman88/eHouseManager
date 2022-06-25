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
                Area = model.Area
            };
        }
    }
}
