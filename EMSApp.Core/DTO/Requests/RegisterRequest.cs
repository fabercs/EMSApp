﻿using System.ComponentModel.DataAnnotations;

namespace EMSApp.Core.DTO.Requests
{
    public class RegisterRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Phone { get; set; }

        [StringLength(50)]
        [Required]
        public string Appname { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [StringLength(maximumLength:30, MinimumLength =8)]
        [Required]
        public string Password { get; set; }

        [StringLength(maximumLength: 30, MinimumLength = 8)]
        [Required]
        public string PasswordAgain { get; set; }

    }
}
