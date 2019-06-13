using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2bPrecise.Models
{
    public class Manager : Employee
    {
        private ICollection<Employee> subordinates;
        public ICollection<Employee> Subordinates { get; set; }

        public Manager() : base() { }

/*        public Manager(int id, string firstName, string lastName, PositionType position, Employee manager, string imgUrl, ICollection<Employee> subordinates)
            : base(id, firstName, lastName, position, manager, imgUrl)
        {
            this.subordinates = subordinates;
        }
*/
/*        public void AssignTask(int employeeId, string taskText, DateTime dueDate)
        {
            var newTask = new TaskItem() { EmployeeId = employeeId, ManagerId = Id, TaskText = taskText, AssignedDate = new DateTime(), DueDate = dueDate };
        }

        public List<ReportItem> GetReports()
        {
            var results = new List<ReportItem>();
            return results;
        }
*/
/*        private ICollection<Employee> GetSubordinates()
        {
            if (subordinates == null)
            {
                var results = new List<Employee>();
                subordinates = results;

                return results;
            }
            else
            {
                return subordinates;
            }
        }
*/    }
}