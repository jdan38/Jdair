using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair2.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public string FlightNumber { get; set; }

        public string Gate_Number { get; set; }
        public int TailNumber { get; set; }

        public string Airline { get; set; }

        public int NumberOfPasseners { get; set; }
        public string first_airport { get; set; }
        public string final_airport { get; set; }

        public int departure_time { get; set; }
        public int arrival_time { get; set; }


    }
}
