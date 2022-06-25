using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Models
{
    public class UserApartmentViewModel
    {
        public int Id { get; set; }
        public string ApartmentNumber { get; set; }
        public string Address { get; set; }
        public decimal Area { get; set; }
        public bool AreTaxesPaid { get; set; }

        public IEnumerable<TaxPaymentDTO> TaxPayments{ get; set; }
    }
}
