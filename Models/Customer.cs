using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DeliveryCart.Models
{
    public class Customer
    {
        public int CustomerID { get; set; } //Primary Key

        [Display(Name = "Customer Name")]
        [Required]
        public string CustomerName { get; set; } = string.Empty;

        [Display(Name = "Email")]
        [Required]
        public string CustomerEmail { get; set; } = string.Empty;
        [Display(Name = "Address")]
        [Required]
        public string CustomerAddress { get; set; } = string.Empty;
        [Display(Name = "Phone")]
        [Required]
        public string CustomerPhone { get; set; } = string.Empty;
    }
}