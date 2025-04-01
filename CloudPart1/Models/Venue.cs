using System.ComponentModel.DataAnnotations;

namespace CloudPart1.Models
{
    public class Venue
    {
        [Key]

        public int VenueId { get; set; }
        [Required]
        public string VenueName { get; set; }

        public string Location { get; set; }


        public int capacity { get; set; }

        public string ImageUrl { get; set; }

       // public ICollection<Event> Events { get; set; }
    }
}
