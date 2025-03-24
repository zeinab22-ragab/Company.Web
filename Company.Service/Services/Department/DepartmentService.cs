﻿using Company.Data.Entities;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;

namespace Company.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void Add(Department department)
        {
            var mappedDepartment = new Department
            {
                Code = department.Code,
                Name = department.Name,
                CreateAt = DateTime.Now,
            };

            _departmentRepository.Add(mappedDepartment);

        }

        public void Delete(Department Department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
           var departments = _departmentRepository.GetAll();
            return departments;
        }

        public Department GetById(int? id)
        {
            if (id is null)
                return null;

            var department = _departmentRepository.GetById(id.Value);

            if (department is null)
                return null;


            return department;
        }

        public void Update(Department department)
        {
       

            _departmentRepository.Update(department);
        }
    }
}
