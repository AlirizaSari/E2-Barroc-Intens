using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens.Classes
{
    public class Leasecontract
    {
        public int id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int BkrChecked { get; set; }
        public DateTime CreateDate { get; set; }
        public string PaymentTerm { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

