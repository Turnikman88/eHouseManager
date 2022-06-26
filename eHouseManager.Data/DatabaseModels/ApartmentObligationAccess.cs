using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DatabaseModels
{
    public class ApartmentObligationAccess : BaseModel<int>
    {
        public int ObligationId { get; set; }
        public int ApartmentId { get; set; }

        public Obligation Obligation { get; set; }
        public Apartment Apartment { get; set; }
    }
}
