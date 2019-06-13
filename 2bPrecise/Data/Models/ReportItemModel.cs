using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2bPrecise.Data.Models
{
    public class ReportItemModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ManagerId { get; set; }
        public string ReportText { get; set; }
        public DateTime IssuedDate { get; set; }
    }
}
