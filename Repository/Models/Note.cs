using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Repository.Models;

namespace Repository.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }


        [ForeignKey("Profile")]
        public int profileId { get; set; }
        public Profile Profile { get; set; }
    }
}
