using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Barroc_Intens
{
    internal class Company
    {
        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string City { get; set; }

        public string CountryCode { get; set; }

        public DateTime? BkrCheckedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null;

        public ObservableCollectionListSource<Note> Notes { get; } = new ObservableCollectionListSource<Note>();
        public ObservableCollectionListSource<CustomInvoice> CustomInvoices { get; } = new ObservableCollectionListSource<CustomInvoice>();
        public ObservableCollectionListSource<MaintenanceAppointment> MaintenanceAppointments { get; } = new ObservableCollectionListSource<MaintenanceAppointment>();

        public override string ToString()
        {
            return this.Name;
        }

    }
}
