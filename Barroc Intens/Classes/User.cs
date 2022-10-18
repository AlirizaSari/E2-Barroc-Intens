using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Barroc_Intens
{
    internal class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int RolId { get; set; }
        public Rol Rol { get; set; } = null;

        public ObservableCollectionListSource<Company> Companies { get; } = new ObservableCollectionListSource<Company>();

        public ObservableCollectionListSource<Note> Notes { get; } = new ObservableCollectionListSource<Note>();
    }
}
