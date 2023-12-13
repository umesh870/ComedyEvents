﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ComedyEvents.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        [ForeignKey("VenueId")]
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
        public ICollection<Gig> Gigs { get; set; }
    }
}
