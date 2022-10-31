using System.ComponentModel.DataAnnotations;

namespace Riode.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [MaxLength(60),Required]
        public string? MainTitle { get; set; }
        [MaxLength(50)]
        public string? SubTitle { get; set; }
        [MaxLength(120)]
        public string? Description { get; set; }
        [MaxLength(120)]
        public string? ImageUrl { get; set; }
        [MaxLength(30)]
        public string? BtnText { get; set; }
        public string? BtnUrl { get; set; }
        [Range(1,5)]
        public int Order { get; set; }

    }
}
