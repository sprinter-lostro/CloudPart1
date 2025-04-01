using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CloudPart1.Models
{
    public class Event
    {
        [Key]

        public int EventId { get; set; }
        [Required]
        public string EventName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }

        public string description { get; set; }

        [ForeignKey("Venue")]
        public int? VenueId { get; set; }
        public Venue? Venue { get; set; }
        
    }
}
