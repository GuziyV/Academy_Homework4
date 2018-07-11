using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class PlaneDTO
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
