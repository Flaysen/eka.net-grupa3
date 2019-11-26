using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventer.Domain.Models.Dtos
{
    public class UpdateEventDto
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Event name is too long!")]
        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ParticipantsNumber { get; set; }
    }
}
