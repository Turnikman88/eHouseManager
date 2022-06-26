using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Value for {0} must be below {1} symbols.")]
        public string Status { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Value for {0} must be below {1} symbols.")]
        public string Title { get; set; }

        [Required]
        [RegularExpression("(.{10})", ErrorMessage = "Length must be 10.")]
        public int UcnNumber { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EventDateTime { get; set; }
    }
}
