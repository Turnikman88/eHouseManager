using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserTypeCD { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }        
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public ICollection<UserApartmentAccess> UserApartmentAccesses { get; set; }
    }
}
