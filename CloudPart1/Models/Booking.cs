using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CloudPart1.Models
{
    public class Booking
    {
        [Key]

        public int BookingId { get; set; }



        [ForeignKey("Event")]
        public string Event { get; set; }
        public int EventId { get; set; }



        [ForeignKey("Venue")]
        public string Venue { get; set; }
        public int VenueId { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
    }
}
