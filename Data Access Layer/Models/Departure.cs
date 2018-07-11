using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Departure
    {
        public int Id { get; set; }

        public int RaceNumber { get; set; }

        public DateTime TimeOfDeparture { get; set; }

        public Crew Crew { get; set; }
    }
}
