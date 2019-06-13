using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2bPrecise.Models
{
    public class ReportItem
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ManagerId { get; set; }
        public string ReportText { get; set; }
        public DateTime IssuedDate { get; set; }

        public ReportItem()
        {

        }

        public ReportItem(int id, int employeeId, int managerId, string reportText, DateTime issuedDate)
        {
            Id = id;
            EmployeeId = employeeId;
            ManagerId = managerId;
            ReportText = reportText;
            IssuedDate = issuedDate;
        }
    }
}