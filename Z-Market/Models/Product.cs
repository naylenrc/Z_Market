using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The fild {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Last Buy")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }


        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Stock { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }


    }
}