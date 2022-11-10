using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens.Classes
{
    public class PlannedAppointment
    {
        public int PlannedAppointmentId { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? AppointmentTime { get; set; }
        public string AppointmentDuration { get; set; }
        public string AssignedEmployee { get; set; }
        public int UserId { get; internal set; }
        public User User { get; internal set; }

    }
}
