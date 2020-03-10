using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }
        public string UserId { get; set; }

        [Required]
        [Column (TypeName ="varchar(75)")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ForeignKey("Profile")]
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }

        [NotMapped]
        public Parent Parent { get; set; }

        [NotMapped]
        public List<Class> Classes { get; set; }
    }
}