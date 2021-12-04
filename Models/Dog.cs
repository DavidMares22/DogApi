using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DogApi.Models
{
    public class Dog
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(1)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        public string Color { get; set; }
        [Required]
        [Range(1, 80)]
        public int Tail_length { get; set; }
        [Required]
        [Range(1, 60)]
        public int Weight { get; set; }
    }
}
