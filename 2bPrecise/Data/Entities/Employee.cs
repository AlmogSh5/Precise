using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2bPrecise.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public PositionType Position { get; set; }
        public int ManagerId { get; set; }
        public string ImgUrl { get; set; }

        //public string FullName
        //{
        //    get { return $"{FirstName} {LastName}"; }
        //}

/*
        public Employee() { }
        public Employee(int id, string firstName, string lastName, PositionType position, Employee manager = null, string imgUrl = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Manager = manager;
            ImgUrl = imgUrl;
        }
*/
/*        public List<TaskItem> GetTaskItems()
        {
            var results = new List<TaskItem>();
            return results;
        }

        public void ReportToManager(string reportText)
        {
            //var report = new ReportItem();
        }
*/    }
}