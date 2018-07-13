using System.ComponentModel.DataAnnotations;

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
