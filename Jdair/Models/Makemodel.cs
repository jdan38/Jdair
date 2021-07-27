using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair.Models
{
    public class Makemodel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        public string Model { get; set; }

    }
}
