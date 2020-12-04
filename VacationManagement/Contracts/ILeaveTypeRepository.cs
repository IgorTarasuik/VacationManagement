using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationManagement.Data;

namespace VacationManagement.Contracts
{
   public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id); 
    }
}
