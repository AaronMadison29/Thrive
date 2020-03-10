﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Contracts;

namespace ThriveAPP.Models
{
    public class Teacher : IEmail, IPhoneNumber
    {
        public int TeacherId { get; set; }
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
