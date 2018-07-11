using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class FlightDTO
    {
        public int Number { get; set; }

        public string DepartureFrom { get; set; }

        public DateTime TimeOfDeparture { get; set; }

        public string Destiation { get; set; }

        public DateTime ArrivalTime { get; set; }

        public Ticket Ticket { get; set; }
    }
}
