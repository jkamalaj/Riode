using System.ComponentModel.DataAnnotations;

namespace Riode.Models
{
    public class Service
    {
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string? Name { get; set; }
        [MaxLength(70)]
        public string? Description { get; set; }
        [Required]
        public string? Icon { get; set; }

        public bool IsActive { get; set; }
    }
}
