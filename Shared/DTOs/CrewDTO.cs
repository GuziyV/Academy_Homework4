using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class CrewDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Pilot Pilot { get; set; }

        [Required]
        public List<Stewardess> Stewardesses { get; set; }
    }
}
