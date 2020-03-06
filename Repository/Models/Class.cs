using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string Subject { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher ClassTeacher { get; set; }

        [NotMapped]
        public List<Student> Students { get; set; }
    }
}
