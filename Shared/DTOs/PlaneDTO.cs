using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class PlaneDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public PlaneType PlaneType { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public TimeSpan LifeTime
        {
            get
            {
                return DateTime.Now - ReleaseDate;
            }
        }
    }
}
