using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DatabaseModels
{
    public class UserEventAccess : BaseModel<int>
    {
        public int EventId { get; set; }
        public int UserId { get; set; }

        public Event Event { get; set; }
        public User User { get; set; }
    }
}
