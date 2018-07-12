using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Crew Crew { get; set; }
    }
}
