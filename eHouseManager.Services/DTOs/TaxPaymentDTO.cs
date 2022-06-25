using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOs
{
    public class TaxPaymentDTO
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int ApartmentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaidOn { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal DueAmount { get; set; }
    }
}
