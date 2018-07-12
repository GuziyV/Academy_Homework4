using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Flight
    {
        public int Number { get; set; }

        public string DepartureFrom { get; set; }

        public DateTime TimeOfDeparture { get; set; }

        public string Destination { get; set; }

        public DateTime ArrivalTime { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
