using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.car.app.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; } = string.Empty;

        [Required]
        public int MakeId { get; set; } 

        [Required]
        public int ColorId { get; set; } 

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal EngineVolume { get; set; }

        [Required]
        [MaxLength(17)]
        public string Vin { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string LicensePlate { get; set; } = string.Empty;

        [ForeignKey("MakeId")]
        public Make Make { get; set; } = null!;

        [ForeignKey("ColorId")]
        public Color Color { get; set; } = null!;
    }
}