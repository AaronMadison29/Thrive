using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public List<Class> Classes { get; set; }
        public string ParentEmail { get; set; }
        public string Email { get; set; }

        [ForeignKey("Profile")]
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }

        [ForeignKey("Parent")]
        public int? ParentId { get; set; }
        public Parent Parent { get; set; }
    }
}
