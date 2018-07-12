using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class FlightDTO
    {
        [Required]
        public int Number { get; set; }

        [Required]
        public string DepartureFrom { get; set; }

        [Required]
        public DateTime TimeOfDeparture { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public List<Ticket> Tickets { get; set; } 
    }
}
