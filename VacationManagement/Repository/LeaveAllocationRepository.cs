﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationManagement.Contracts;
using VacationManagement.Data;

namespace VacationManagement.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveAllocation FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveAllocations.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
