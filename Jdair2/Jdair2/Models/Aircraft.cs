using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair2.Models
{
    public class Aircraft
    {
        [Key]
        public int AcId { get; set; }

        [Required]
        public string Make { get; set; }

        public string Aircraft_Model { get; set; }

        public int Weight { get; set; }

        public int Max_Fuel_Lbs { get; set; }

        public int Maxtakeoffweight { get; set; }

        [Required]
        public int MaxSeating { get; set; }
        

       

    }
}
