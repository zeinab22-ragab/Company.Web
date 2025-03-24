using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;

namespace Company.Repository.Interfaces
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {

        #region NoThing
        //Department GetById(int id);
        //IEnumerable<Department> GetAll();
        //void Add(Department Department);
        //void Update(Department Department);
        //void Delete(Department Department); 
        #endregion
    }
}
