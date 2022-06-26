using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Models
{
    public class SettingsViewModel
    {
        [Required]
        [DisplayName("First Name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {2} and {1}.")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {2} and {1}.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"/^\d{3}(-|\s)\d{3}(-|\s)\d{4}$|^\d{10}$|^1\s\d{3}(-|\s)\d{3}(-|\s)\d{4}$|^(1\s?)?\(\d{3}\)(\s|\-)?\d{3}\-\d{4}$/", ErrorMessage = "Invalid Phone")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password lenght must be {1} characters or longer")]
        public string Password { get; set; }
    }
}
