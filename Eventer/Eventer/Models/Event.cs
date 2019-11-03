using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventer.Models
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

        public double Budget { get; set; }

        public int BoughtTickets { get; set; }

        [MaxLength(2000, ErrorMessage = "Event description is too long!")]
        public string Description { get; set; }

        [Required]
        public int LocationId { get; set; }

   
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        public virtual List<Organizer> Organizers { get; set; }
    }
}
