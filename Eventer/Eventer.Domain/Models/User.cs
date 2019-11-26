using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Text;

namespace Eventer.Domain.Models
{
    public enum YesNo
    {
        Yes, No, Maybe
    };
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Probably you made mistake, your name is too long")]
        [MinLength(2, ErrorMessage = "Probably you made mistake, your name is too short")]
        public string Name { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Probably you made mistake, your surname is too long")]
        [MinLength(2, ErrorMessage = "Probably you made mistake, your surname is too short")]
        public string Surname { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[NULL]")]
        [EmailAddress]
        public MailAddress Email { get; set; }

        [Required]
        public YesNo Status { get; set; }
        [ForeignKey("EventId")]
        public Event EventId { get; set; }


        public float Payment { get; set; }

        public bool Discount { get; set; }

        public float DiscountValue { get; set; }


    }
}
