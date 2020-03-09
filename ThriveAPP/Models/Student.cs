using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThriveAPP.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Class> Classes { get; set; }
        public string Email { get; set; }
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int? ParentId { get; set; }
        public Parent Parent { get; set; }
    }
}
