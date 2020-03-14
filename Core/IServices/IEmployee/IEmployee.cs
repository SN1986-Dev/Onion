using System;
using System.Collections.Generic;
using System.Text;
using Core.ViewModelEntities.EmployeeVM;
using Core.Entities.Employee;
namespace Core.IServices.IEmployee
{
   public interface IEmployee
    {
        EmployeeVM GetAllEmployee();
        Employee GetEmployeeById(int Id);
    }
}
