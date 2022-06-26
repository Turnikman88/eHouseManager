using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    [Table("Apartments23223233232")]
    public class Apartment : BaseModel<int>
    {
        public Apartment()
        {
            TaxPayments = new HashSet<TaxPayment>();
            UserApartmentAccesses = new HashSet<UserApartmentAccess>();
        }

        public string ApartmentNumber { get; set; }
        public string Owner { get; set; }
        public int InhabitantsCount { get; set; }
        public decimal Area { get; set; }
        public bool AreTaxesPaid { get; set; }
        public string Address { get; set; }
        public string MyProperty { get; set; }
        public int UcnNumber { get; set; }
        public virtual ICollection<TaxPayment> TaxPayments { get; set; }
        public virtual ICollection<UserApartmentAccess> UserApartmentAccesses { get; set; }

    }
}
