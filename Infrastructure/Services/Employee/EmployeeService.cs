using Core.Entities.Employee;
using Core.IRepository.IEmployeeRepository;
using Core.IServices.IEmployee;
using Core.ViewModelEntities.EmployeeVM;
using Infrastructure.Repository.Emloyee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Employee
{
   public class EmployeeService : IEmployee
    {
        private readonly IEmployeeRepository _employee = null;
        public EmployeeService(IEmployeeRepository employee)
        {
            _employee = employee;
        }
        public EmployeeVM GetAllEmployee()
        {
            return _employee.GetAllEmployee();
        }

        public Core.Entities.Employee.Employee GetEmployeeById(int Id)
        {
            return _employee.GetEmployeeById(Id);
        }
    }
}
