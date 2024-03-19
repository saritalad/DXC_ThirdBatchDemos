using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Token_WebAPI8.Models
{
    public class LogInModel
    {
        [Required]
        [MinLength(6)]
        public string? Username { get; set; }

        [Required]
        [MinLength(8)]
        public string? Password { get; set; }
    }
}
