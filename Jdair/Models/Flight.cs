using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public string first_airport { get; set; }
        public string final_airport { get; set; }

        public int departure_time { get; set; }
        public int arrival_time { get; set; }


    }
}
