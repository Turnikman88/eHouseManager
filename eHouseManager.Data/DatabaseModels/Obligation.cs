using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eHouseManager.Data.DatabaseModels
{
    public class Obligation : BaseModel<int>
    {
        public Obligation()
        {
            ApartmentObligationAccesses = new HashSet<ApartmentObligationAccess>();
        }

        public string Description { get; set; }
        public DateTime DueDate { get; set; }


        public virtual ICollection<ApartmentObligationAccess> ApartmentObligationAccesses { get; set; }
    }
}
