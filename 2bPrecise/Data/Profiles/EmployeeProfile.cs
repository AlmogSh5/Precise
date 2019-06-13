using _2bPrecise.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2bPrecise.Data.Models;

namespace _2bPrecise.Data.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            //.ForMember(t => t.ManagerId, opt => opt.Ignore());
            CreateMap<TaskItem, TaskItemModel>().ReverseMap();
            //.ForMember(t => t.EmployeeId, opt => opt.Ignore())
            //.ForMember(t => t.ManagerId, opt => opt.Ignore());
            CreateMap<ReportItem, ReportItemModel>().ReverseMap();
                //.ForMember(t => t.Employee, opt => opt.Ignore())
                //.ForMember(t => t.Manager, opt => opt.Ignore());
        }
    }
}
