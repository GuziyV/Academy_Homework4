using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs
{
    public class PilotDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public int Experience { get; set; }
    }
}
