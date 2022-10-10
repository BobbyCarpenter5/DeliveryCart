using System.ComponentModel.DataAnnotations;

namespace DeliveryCart.Models
{
    public class Shopper
    {
        public int ShopperID { get; set; }
        [Display(Name = "Shopper Name")]
        [Required]
        public string ShopperName { get; set; } = string.Empty;
        [Display(Name = "Email")]
        [Required]
        public string ShopperEmail { get; set; } = string.Empty;
        [Display(Name = "Phone")]
        [Required]
        public string ShopperPhone { get; set; } = string.Empty;
    }
}