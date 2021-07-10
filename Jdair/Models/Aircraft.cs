using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair.Models
{
    public class Aircraft
    {
        [Key]
        public int AcId { get; set; }

        [Required]
        public int TailNumber { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public int Weight { get; set; }

        public int FuelWeight { get; set; }

        public int Maxtakeoffweight { get; set; }

        [Required]
        public int MaxSeating { get; set; }

        public string Airline { get; set; }

    }
}
