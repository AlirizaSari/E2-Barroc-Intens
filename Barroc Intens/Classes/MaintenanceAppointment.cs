using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    internal class MaintenanceAppointment
    {
        public int MaintenanceAppointmentId { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string Remark { get; set; }
        public DateTime Added { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
