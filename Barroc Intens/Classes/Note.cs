using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    public class Note
    {
        public int NoteId { get; set; }

        public string NoteDesription { get; set; }

        public DateTime date { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; } = null;

        public int UserId { get; set; }
        public User User { get; set; } = null;

    }
}
