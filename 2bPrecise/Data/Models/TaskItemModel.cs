using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2bPrecise.Data.Models
{
    public class TaskItemModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ManagerId { get; set; }
        public string TaskText { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
