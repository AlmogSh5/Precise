using _2bPrecise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2bPrecise.Data.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PositionType Position { get; set; }
        public string ImgUrl { get; set; }

        // Manager Info
        public int ManagerId { get; set; }
        //public string ManagerFirstName { get; set; }
        //public string ManagerLastName { get; set; }
        //public PositionType ManagerPosition { get; set; }
        //public string ManagerImgUrl { get; set; }
    }
}
