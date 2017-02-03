using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Display(Name = "Supplier Name")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Contact First Name")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string ContactFirstName { get; set; }

        [Display(Name = "Contact Last Name")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string ContactLastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}