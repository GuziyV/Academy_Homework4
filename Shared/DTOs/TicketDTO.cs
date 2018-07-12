using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class TicketDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int RaceNumber { get; set; }
    }
}
