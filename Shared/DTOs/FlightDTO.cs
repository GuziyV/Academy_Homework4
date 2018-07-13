using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public List<TicketDTO> Tickets { get; set; } 
    }
}
