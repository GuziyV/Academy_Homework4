using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class CrewDTO
    {
        public int Id { get; set; }

        public Pilot Pilot { get; set; }

        public List<Stewardess> Stewardesses { get; set; }
    }
}
