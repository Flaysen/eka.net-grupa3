using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventer.Domain.Models
{
    public class Ticket
    {

        public enum TicketType
        {
            normal,
            premium
        }


        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public float Pirce { get; set; }

        [Required]
        public string SerialNumber { get; set; }

        public TicketType Type { get; set; }

        [Required]
        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }
    }
}
