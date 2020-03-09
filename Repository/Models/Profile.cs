using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        public string FavoriteSubject { get; set; }
        public string LearningStyle { get; set; }
        [NotMapped]
        public List<string> Notes { get; set; }
    }
}
