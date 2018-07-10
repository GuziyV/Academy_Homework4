using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Stewardess
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
