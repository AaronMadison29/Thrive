using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Contracts;

namespace ThriveAPP.Models
{
    public class Student : IEmail
    {
        public int StudentId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }
        public Parent Parent { get; set; }
        public List<Class> Classes { get; set; }
    }
}
