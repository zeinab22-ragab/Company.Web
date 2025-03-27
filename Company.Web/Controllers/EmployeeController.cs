using Company.Data.Entities;
using Company.Service.Interfaces;
using Company.Service.Interfaces;
using Company.Service.Interfaces.Employee.Dto;
using Company.Service.Services;
using Company.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentServies;

        public EmployeeController(IEmployeeService employeeService , IDepartmentService departmentServies)
        {
            _employeeService = employeeService;
            _departmentServies = departmentServies;
        }

        [HttpGet]
        public IActionResult Index(string searchInp)
        {
            // ViewBag ViewData TempData
            //ViewBag.Message = "Hello From Employee Index(ViewBag)";

            //ViewData["TextMessage"]= "Hello From Employee Index(ViewData)";

            

            IEnumerable<EmployeeDto> employees = new List<EmployeeDto>();

            if (string.IsNullOrEmpty(searchInp))
                employees = _employeeService.GetAll();
            else
                employees = _employeeService.GetEmployeeByName(searchInp);

            return View(employees);
        }


        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.Departments = _departmentServies.GetAll();
            return View();

        }

        [HttpPost]
        public IActionResult Create(EmployeeDto employee)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee);

                    return RedirectToAction(nameof(Index));
                }

                return View(employee);


            }
            catch (Exception ex)
            {

                return View(employee);
            }


        }



    }

    //public IActionResult Details(int? id, string viewName = "Details")
    //{

    //}


    //[HttpGet]
    //public IActionResult Update(int? id)
    //{


    //}

    //[HttpPost]
    //public IActionResult Update(int? id, Department department)
    //{

    //}


    //public IActionResult Delete(int id)
    //{



    //}



    
}
