using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Entities;
using Test.Services;

namespace Test.IService
{
    public interface IEmployeeService
    {
        IList<Employee> GetEmployees();
    }
}