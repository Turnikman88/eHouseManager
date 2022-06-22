using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class Apartment
    {
        public Apartment()
        {
            TaxPayments = new HashSet<TaxPayment>();
            UserApartmentAccesses = new HashSet<UserApartmentAccess>();
        }

        [Key]
        public int ApartmentID { get; set; }
        public string ApartmentNumber { get; set; }
        public string Owner { get; set; }
        public int Inhabitants { get; set; }
        public decimal Area { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<TaxPayment> TaxPayments { get; set; }
        public virtual ICollection<UserApartmentAccess> UserApartmentAccesses { get; set; }
    }
}
