﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Student
    {
        public Student()
        {
            Profile = new Profile();
        }

        [Key]
        public int StudentId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public List<Class> Classes { get; set; }
        public string Email { get; set; }

        [ForeignKey("Profile")]
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }
        public Parent Parent { get; set; }
    }
}