using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2bPrecise.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ManagerId { get; set; }
        public string TaskText { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }

        public TaskItem()
        {

        }

        public TaskItem(int id, int employeeId, int managerId, string taskText, DateTime assignedDate, DateTime dueDate)
        {
            Id = id;
            EmployeeId = employeeId;
            ManagerId = managerId;
            TaskText = taskText;
            AssignedDate = assignedDate;
            DueDate = dueDate;
        }
    }
}