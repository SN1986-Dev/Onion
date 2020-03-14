using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entities.Employee;
using Core.IRepository.IEmployeeRepository;
using Core.ViewModelEntities.EmployeeVM;

namespace Infrastructure.Repository.Emloyee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employee = null;
        public EmployeeRepository()
        {
            _employee = new List<Employee>()
            {
                new Employee(){Id=1,Name="Shobhnath",Designation="Sr Software Developer" },
                new Employee(){Id=2,Name="Karan",Designation="Sr Software Developer" },
                new Employee(){Id=3,Name="Awadhesh",Designation="Sr Software Developer" }
            };
        }
        public EmployeeVM GetAllEmployee()
        {
            EmployeeVM employeeVM = new EmployeeVM
            {
                GetAllEmployee = new List<Employee>()
            };
            if (_employee != null && _employee.Count > 0)
            {
                foreach (var emp in _employee)
                {
                    Employee modal = new Employee
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        Designation = emp.Designation
                    };
                    employeeVM.GetAllEmployee.Add(modal);
                }
            }
            return employeeVM;
        }

        public Employee GetEmployeeById(int Id)
        {
            Employee _modal = new Employee();
            if (_employee != null && _employee.Count > 0)
            {
                _modal = _employee.FirstOrDefault(x => x.Id == Id);
            }
                return _modal;
        }

    }    
}
