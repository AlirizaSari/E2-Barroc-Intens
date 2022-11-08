using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens.Classes
{
    public class MaintenanceAppointmentProduct
    {
        public int MaintenanceAppointmentProductId { get; set; }
        public int MaintenanceAppontmentId { get; set; }
        public MaintenanceAppointment MaintenanceAppointment { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
