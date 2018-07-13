using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs
{
    public class DepartureDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int RaceNumber { get; set; }

        [Required]
        public DateTime TimeOfDeparture { get; set; }

        [Required]
        public CrewDTO Crew { get; set; }
    }
}
