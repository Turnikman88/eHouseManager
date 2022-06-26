using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class TaxPayment : BaseModel<int>
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int ApartmentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaidOn { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal DueAmount { get; set; }

        public virtual Apartment Apartment { get; set; }
    }
}
