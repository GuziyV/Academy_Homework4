﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class PlaneType
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int NumberOfSeats { get; set; }

        public int LoadCapacity { get; set; }
    }
}
