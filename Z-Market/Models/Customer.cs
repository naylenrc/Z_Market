using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Document")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(20, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 5)]
        public string Document { get; set; }

        public int DocumentTypeID { get; set; }
        public virtual DocumentType DocumentType { get; set; }


    }
}