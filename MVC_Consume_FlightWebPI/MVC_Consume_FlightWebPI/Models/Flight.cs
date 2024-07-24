using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Consume_FlightWebPI.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Start { get; set; }
        public string destination { get; set; }
        public string start_time { get; set; }
        public string destination_time { get; set; }
    }
}
