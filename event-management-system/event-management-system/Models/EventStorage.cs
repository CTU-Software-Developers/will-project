using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace event_management_system.Models
{
    public class EventStorage
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int EventID { get; set; }

        [Required]
        [Display(Name = "Type")]
        public Event EventType { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string EventName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime EventDate { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string EventDescription { get; set; }

        [Display(Name = "Time")]
        public DateTime EventTime { get; set; }

        [Required]
        [Display(Name = "Ticket Price")]
        public double TicketPrice { get; set; }
    }

    public enum Event
    {
        Baseball,
        Basketball,
        Cricket,
        Hockey,
        Racing,
        Netball,
        Rage,
        Rugby,
        Soccer,
        Softball,
        Tennis
    }

    public class EventRevies
    {
        [Required]
        [Key]
        public int ReviewID { get; set; }

        [Required]
        [ForeignKey("EventStorage")]
        public int EventID { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Review")]
        public string Review { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime ReviewDate { get; set; }

        public EventStorage EventStorage { get; set; }
    }

    public class SportList
    {
        public int EventID { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventTime { get; set; }
        public double TicketPrice { get; set; }
    }

    public class RaceList
    {
        public int EventID { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventTime { get; set; }
        public double TicketPrice { get; set; }
    }

    public class RageList
    {
        public int EventID { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventTime { get; set; }
        public double TicketPrice { get; set; } 
    }
}