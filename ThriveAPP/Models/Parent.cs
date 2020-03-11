using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Contracts;

namespace ThriveAPP.Models
{
    public class Parent : IEmail, IPhoneNumber
    {
        public int ParentId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string PhoneNumber { get; set; }
    }
}
