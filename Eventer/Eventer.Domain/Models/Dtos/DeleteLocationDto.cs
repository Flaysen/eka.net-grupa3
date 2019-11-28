using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventer.Domain.Models.Dtos
{
    public class DeleteLocationDto
    {
        [Required]
        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public int FlatNumber { get; set; }

    }
}
