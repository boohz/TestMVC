using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Entities;
using Test.IService;
using Test.Model;

namespace Test.Services
{
    public class EmployeeService : NHibernateHelper, IEmployeeService

    {
        public IList<Employee> GetEmployees()
        {

            var session = NHibernateHelper.OpenSession();
            Employee employeeA = null;
            var result = session.QueryOver(() => employeeA).List();

            return result;
        }

    }
}