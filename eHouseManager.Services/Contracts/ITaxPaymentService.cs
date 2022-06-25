using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.Contracts
{
    public interface ITaxPaymentService : ICrud<TaxPaymentDTO>
    {
        public IEnumerable<TaxPaymentDTO> GetAllByApartmentId(int apartmentId);
    }
}
