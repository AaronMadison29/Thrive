using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SchoolAPI.Models;

namespace Repository.Models
{
    class Notes
    {
        [Key]
        public int NoteId { get; set; }
        public string Note { get; set; }
        [ForeignKey("Profile")]
        public int profileId { get; set; }
        public Profile Profile { get; set; }
    }
}
