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

        private CrewDTO crew;

        public CrewDTO GetCrew()
        {
            return crew;
        }

        public void SetCrew(CrewDTO value)
        {
            crew = value;
        }
    }
}
