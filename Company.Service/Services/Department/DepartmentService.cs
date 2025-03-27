using AutoMapper;
using Company.Data.Entities;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;
using Company.Service.Interfaces.Department.Dto;

namespace Company.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
           
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(DepartmentDto departmentDto)
        {//map
            //var mappedDepartment = new DepartmentDto
            //{
            //    Code = department.Code,
            //    Name = department.Name,
            //    CreateAt = DateTime.Now,
            //};
            var mappeddepartment =_mapper.Map<Department>(departmentDto);  

            _unitOfWork.DepartmentRepository.Add(mappeddepartment);

            _unitOfWork.Complete();

        }


        public void Delete(DepartmentDto departmentDto)
        {
            var mappeddepartment = _mapper.Map<Department>(departmentDto);

            _unitOfWork.DepartmentRepository.Delete(mappeddepartment);
            _unitOfWork.Complete();

        }

        public IEnumerable<DepartmentDto> GetAll()
        {
            var departments = _unitOfWork.DepartmentRepository.GetAll();
            var mappeddepartment = _mapper.Map< IEnumerable < DepartmentDto >  >(departments);
            return mappeddepartment;
        }


        public DepartmentDto GetById(int? id)
        {
            if (id is null)
                return null;

            var department = _unitOfWork.DepartmentRepository.GetById(id.Value);

            if (department is null)
                return null;

            var mappeddepartment = _mapper.Map<DepartmentDto>(department);
            return mappeddepartment;
        }

        public void Update(DepartmentDto department)
        {
          //    _unitOfWork.DepartmentRepository.Update(department);
            //    _unitOfWork.Complete();
        }

        
    }
}
