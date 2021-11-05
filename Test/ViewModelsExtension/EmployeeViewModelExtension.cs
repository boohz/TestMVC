using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Entities;
using Test.ViewModels;

namespace Test.ViewModelsExtension
{
    public static class EmployeeViewModelExtension
    {
        public static Employee ToEntity(this EmployeeViewModel employeeViewModel)
        {
            return new Employee()
            {
                Id = employeeViewModel.Id,
                Namn = employeeViewModel.Namn,
            };

       
        }
        public static EmployeeViewModel ToViewmodel(this Employee employee)
        {
            return new EmployeeViewModel()
            {
                Id = employee.Id,
                Namn = employee.Namn,
            };

      
        }

       
    }
}