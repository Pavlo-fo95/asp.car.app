﻿using System.ComponentModel.DataAnnotations;

namespace asp.car.app.Models
{
    public class Make
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}