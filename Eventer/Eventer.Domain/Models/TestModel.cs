using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventer.Domain.Models
{
    public class TestModel
    {
        [Required]
        public int Id { get; set; }
        public int Value { get; set; }
    }
}
