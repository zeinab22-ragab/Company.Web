﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;

namespace Company.Repository.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Employee GetEmployeeByName(string name);
        IEnumerable<Employee> GetEmployeesByAddress(string address);

        #region NOThing
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee); 
        #endregion
    }
}
