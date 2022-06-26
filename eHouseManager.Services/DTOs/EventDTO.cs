using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOs
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public int UcnNumber { get; set; }
        public DateTime EventDateTime { get; set; }
    }
}
