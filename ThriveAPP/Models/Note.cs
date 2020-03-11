using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriveAPP.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Content { get; set; }
        public int profileId { get; set; }
        public Profile Profile { get; set; }
    }
}
