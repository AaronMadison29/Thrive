using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThriveAPP.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string FavoriteSubject { get; set; }
        public string LearningStyle { get; set; }
        public string Notes { get; set; }
    }
}
