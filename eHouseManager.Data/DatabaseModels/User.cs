using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class User : BaseModel<int>
    {
        public User()
        {
            UserApartmentAccesses = new HashSet<UserApartmentAccess>();
            UserEventAccesses = new HashSet<UserEventAccess>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public int UcnNumber { get; set; }

        public ICollection<UserApartmentAccess> UserApartmentAccesses { get; set; }
        public ICollection<UserEventAccess> UserEventAccesses { get; set; }
    }
}
