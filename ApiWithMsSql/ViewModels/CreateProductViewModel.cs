using System.ComponentModel.DataAnnotations;

namespace ApiWithMsSql.ViewModels
{
    public class CreateProductViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string CategoryId { get; set; }
    }
}
