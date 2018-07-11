using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class PlaneTypeDTO
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int NumberOfSeats { get; set; }

        public int LoadCapacity { get; set; }
    }
}
