using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs
{
    public class PlaneDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public PlaneTypeDTO PlaneType { get; set; }

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
