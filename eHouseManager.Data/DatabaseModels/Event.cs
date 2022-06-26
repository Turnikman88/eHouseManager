using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class Event : BaseModel<int>
    {
        public Event()
        {
            UserEventAccesses = new HashSet<UserEventAccess>();
        }

        public string Status { get; set; }
        public string Title { get; set; }
        public DateTime EventDateTime { get; set; }

        public ICollection<UserEventAccess> UserEventAccesses { get; set; }

    }
}
