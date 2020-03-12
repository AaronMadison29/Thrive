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

        [Column(TypeName = "varchar(25)")]
        public string FavoriteSubject { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string LearningStyle { get; set; }

        
        public string Notes { get; set; }
    }
}
