﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventer.Domain.Models.Dtos
{
    public class UpdateOrganizerDto
    {
        [Required]
        public int Id { get; set; }

        
        public string Name { get; set; }
      
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string CompanyName { get; set; }
    }
}
