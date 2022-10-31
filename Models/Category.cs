using System.ComponentModel.DataAnnotations;

namespace Riode.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(40),Required]
        public string? Name { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [MaxLength(30),Required]
        public string? CategoryName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
