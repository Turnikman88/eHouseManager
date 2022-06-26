using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public DateTime EventDateTime { get; set; }
    }
}
