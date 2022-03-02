using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bilton.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        
        [Required(ErrorMessage = "Please Enter a Name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter the First Address Line:")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please Enter the City:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter a State:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter a Zip Code:")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please Enter a Country:")]
        public string Country { get; set; }
    }
}
