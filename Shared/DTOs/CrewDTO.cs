using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs
{
    public class CrewDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public PilotDTO Pilot { get; set; }

        [Required]
        public List<StewardessDTO> Stewardesses { get; set; }
    }
}
