using Barroc_Intens.Classes;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_Intens
{
    public class MaintenanceAppointment
    {
        public int MaintenanceAppointmentId { get; set; }
        public string AppointmentDuration { get; set; }
        public string AssignedEmployee { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string Remark { get; set; }
        public DateTime Added { get; set; }
        public bool AppointmentIsPlanned { get; set; }
        public bool IsRoutineAppointment { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

    }

}
