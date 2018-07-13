using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs
{
    public class PlaneTypeDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }

        [Required]
        public int LoadCapacity { get; set; }
    }
}
