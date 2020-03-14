using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoOnion.Models;
using Core.IServices.IEmployee;
using Core.Entities.Employee;

namespace DemoOnion.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _employee = null;
        public HomeController(IEmployee employee)
        {
            _employee = employee;
        }
        public IActionResult Index()
        {
            var modal = _employee.GetAllEmployee();
            return View("Employee",modal);
        }
        public IActionResult Create()
        {
            Employee _modal = new Employee();
            return View("NewEmployee", _modal);
        }
        public IActionResult GetEmployee(int EmpID)
        {
            var modal = _employee.GetEmployeeById(EmpID);
            return View("EmployeeDetails", modal);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
