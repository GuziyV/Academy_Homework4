using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class DepartureDTO
    {
        public int Id { get; set; }

        public int RaceNumber { get; set; }

        public DateTime TimeOfDeparture { get; set; }

        public Crew Crew { get; set; }
    }
}
