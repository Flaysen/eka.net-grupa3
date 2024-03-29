﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventer.Domain.Models
{
    public class Organizer
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(31, ErrorMessage = "Probably you made mistake, your name is too long")]
        [MinLength(2, ErrorMessage = "Probably you made mistake, your name is too short")]
        [Required]
        public string Name { get; set; }

        [MaxLength(31, ErrorMessage = "Probably you made mistake, your name is too long")]
        [MinLength(2, ErrorMessage = "Probably you made mistake, your name is too short")]
        [Required]
        public string LastName { get; set; }

        //[EmailAddress]
        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[NULL]")]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[NULL]")]
        public string CompanyName { get; set; }
    }
}
