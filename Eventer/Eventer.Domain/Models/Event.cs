using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventer.Domain.Models
{
    public class Event
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Event name is too long!")]
        public string Name { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ParticipantsNumber { get; set; }

        [Required]
        public int LocationId { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("LocationId")]
        public Location Location { get; set; }

        public virtual List<Organizer> Organizers { get; set; }
    }
}
