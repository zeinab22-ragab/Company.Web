using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Company.Data.Entities;
using Company.Service.Interfaces.Department.Dto;

namespace Company.Service.Mapping
{
    public class DepartmentProfile :Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department , DepartmentDto>().ReverseMap();
        }
    }
}
