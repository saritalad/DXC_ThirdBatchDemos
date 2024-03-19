using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Token_WebAPI8.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Fullname { get; set; }

        [Required]
        [MinLength(6)]
        public string? Username { get; set; }

        [Required]
        [MinLength(6)]
        public string? Password { get; set; }

        [Required]
        public string? Email { get; set; }

        public string? Role { get; set; }

        public string? Status { get; set; }

    }
}
