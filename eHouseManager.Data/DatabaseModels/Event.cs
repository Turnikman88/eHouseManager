using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class Event
    {
        public int EventID { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public DateTime EventDateTime { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
