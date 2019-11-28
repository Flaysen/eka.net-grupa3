using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventer.Domain.Models.Dtos
{
    public class AddLocationDto
    {
        public int Id { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        
        public string Street { get; set; }

        
        public string HouseNumber { get; set; }

        public int FlatNumber { get; set; }
    }
}
