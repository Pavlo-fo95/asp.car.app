using System.ComponentModel.DataAnnotations;

namespace asp.car.app.Models
{
    public class Color
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;
    }
}