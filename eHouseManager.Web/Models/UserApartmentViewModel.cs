using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Models
{
    public class UserApartmentViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Value for {0} must be below {1} symbols.")]
        public string ApartmentNumber { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {2} and {1}.")]
        public string Address { get; set; }

        [Required]
        [Range(1,2000, ErrorMessage = "Value for {0} must be between {2} and {1}.")]
        public decimal Area { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "Value for {0} must be between {2} and {1}.")]
        public int InhabitantsCount { get; set; }

        public bool AreTaxesPaid { get; set; }

        [Required]
        public int UcnNumber { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {2} and {1}.")]
        public string Owner { get; set; }

        public IEnumerable<TaxPaymentDTO> TaxPayments{ get; set; }
    }
}
