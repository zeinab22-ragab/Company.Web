using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using Company.Data.Entities;
using Company.Repository.Interfaces;

namespace Company.Repository.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        public EmployeeRepository(CompanyDbContext context) : base(context) 
        {

            _context = context;
        }

        public Employee GetEmployeeByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployeesByAddress(string address)
        {
            throw new NotImplementedException();
        }
        #region NoThing
        //private readonly CompanyDbContext _context;

        //public EmployeeRepository(CompanyDbContext context)
        //{

        //    // _context = context;
        //}

        //public void Add(Employee employee)   
        //   =>   _context.Add(employee);


        //public void Delete(Employee employee)
        //   => _context.Remove(employee);

        //public IEnumerable<Employee> GetAll()
        //   => _context.Employees.ToList();
        //public Employee GetById(int id)
        //   // => _context.Employees.FirstOrDefault(x=>x.Id == id);
        //   => _context.Employees.Find(id);

        //public void Update(Employee employee)
        //   => _context.Update(employee); 
        #endregion
    }
}
