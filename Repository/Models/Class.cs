using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Required]
        public string Subject { get; set; }

        [NotMapped]
        public Teacher Teacher { get; set; }

        [NotMapped]
        public List<Student> Students { get; set; }
    }
}
