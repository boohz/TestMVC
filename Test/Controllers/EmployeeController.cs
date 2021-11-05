using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Entities;
using Test.IService;
using Test.Model;
using Test.Services;
using Test.ViewModels;
using Test.ViewModelsExtension;

namespace Test.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly NHibernateHelper _session;

        public EmployeeController(NHibernateHelper session, IEmployeeService employeeService)
        {
            _session = session;
            _employeeService = employeeService;
        }

        public EmployeeController()
        {
        }

        public ActionResult Index(EmployeeService _employeeService)
        {
            var employees = _employeeService.GetEmployees().Select(x => x.ToViewmodel()).ToList();

            return View("Index", employees);
        }
    }
}