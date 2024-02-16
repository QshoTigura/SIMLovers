using System.ComponentModel.DataAnnotations;

using SIMLovers.Models.Brand;
using SIMLovers.Models.Category;

namespace SIMLovers.Models.Product
{
    public class ProductIndexVM
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = null!;

        public int BrandId { get; set; }
        [Display(Name = "Brand")]
        public string BrandName { get; set; } = null!;

        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; } = null!;

        [Display(Name = "Description")]
        public string Description { get; set; } = null!;

        [Display(Name = "Torque")]
        public int Torque { get; set; }

        [Display(Name = "Style")]
        public string Style { get; set; } = null!;

        [Display(Name = "Picture")]
        public string Picture { get; set; } = null!;

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }
    }
}
