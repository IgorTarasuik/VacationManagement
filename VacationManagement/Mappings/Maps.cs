using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationManagement.Data;
using VacationManagement.Models;

namespace VacationManagement.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
        }
    }
}
