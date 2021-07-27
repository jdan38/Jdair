using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair.Models
{
    public class Airports
    {
        [Key]
        public int Id { get; set; }
        public string Airport_Code { get; set; }
        [Required]
        [Display(Name = "Airport Name")]
        public string Name { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        [Required]
        public string Zip { get; set; }

    }
}
