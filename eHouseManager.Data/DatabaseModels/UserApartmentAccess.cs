using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class UserApartmentAccess : BaseModel<int>
    {
        public int UserId { get; set; }
        public int ApartmentId { get; set; }

        public User User { get; set; }
        public Apartment Apartment { get; set; }
    }
}
