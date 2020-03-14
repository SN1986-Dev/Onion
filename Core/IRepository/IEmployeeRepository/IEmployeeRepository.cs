using Core.Entities.Employee;
using Core.ViewModelEntities.EmployeeVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.IRepository.IEmployeeRepository
{
   public interface IEmployeeRepository
    {
        EmployeeVM GetAllEmployee();
        Employee GetEmployeeById(int Id);
    }
}
