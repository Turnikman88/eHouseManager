using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class Apartment : BaseModel<int>
    {
        public Apartment()
        {
            TaxPayments = new HashSet<TaxPayment>();
            UserApartmentAccesses = new HashSet<UserApartmentAccess>();
            ApartmentObligationAccesses = new HashSet<ApartmentObligationAccess>();
        }

        public string ApartmentNumber { get; set; }
        public string Owner { get; set; }
        public int InhabitantsCount { get; set; }
        public decimal Area { get; set; }
        public string ObligationId { get; set; }
        public bool AreTaxesPaid { get; set; }
        public string Address { get; set; }

        public virtual ICollection<TaxPayment> TaxPayments { get; set; }
        public virtual ICollection<UserApartmentAccess> UserApartmentAccesses { get; set; }

        public virtual ICollection<ApartmentObligationAccess> ApartmentObligationAccesses { get; set; }
    }
}
