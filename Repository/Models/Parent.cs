using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    public class Parent
    {
        [Key]
        public int ParentId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public List<Student> Children { get; set; }
        public string Email { get; set; }
    }
}
