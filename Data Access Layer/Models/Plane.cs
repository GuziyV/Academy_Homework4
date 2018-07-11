using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Plane
    {
        public int Id { get; set; }

        public PlaneType PlaneType { get; set; }

        public DateTime ReleaseDate { get; set; }

        public TimeSpan LifeTime
        {
            get
            {
                return DateTime.Now - ReleaseDate;
            }
        }
    }
}
