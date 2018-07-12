using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
