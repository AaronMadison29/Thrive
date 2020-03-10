using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Contracts;

namespace ThriveAPP.Models
{
    public class Parent : IEmail
    {
        [Key]
        public int ParentId { get; set; }
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Student> Children { get; set; }
        public string Email { get; set; }
    }
}
