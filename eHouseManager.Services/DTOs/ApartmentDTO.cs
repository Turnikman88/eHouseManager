using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOs
{
    public class ApartmentDTO
    {
        public int Id { get; set; }
        public string ApartmentNumber { get; set; }
        public string Owner { get; set; }
        public int InhabitantsCount { get; set; }
        public decimal Area { get; set; }
        public string ModifiedBy { get; set; }
        public bool AreTaxesPaid { get; set; }
        public string Address { get; set; }
        public int UcnNumber { get; set; }
        public IEnumerable<TaxPaymentDTO> TaxPaymentDTOs { get; set; }
    }
}
