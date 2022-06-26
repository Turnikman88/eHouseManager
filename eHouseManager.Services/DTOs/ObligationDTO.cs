using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOs
{
    public class ObligationDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
