using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOs
{
    public class ApartmentDTO
    {
        public int ApartmentID { get; set; }
        public string ApartmentNumber { get; set; }
        public string Owner { get; set; }
        public int Inhabitants { get; set; }
        public decimal Area { get; set; }
        public string ModifiedBy { get; set; }
    }
}
