using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class UserApartmentAccess
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ApartmentID { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public User User { get; set; }
        public Apartment Apartment { get; set; }
    }
}
