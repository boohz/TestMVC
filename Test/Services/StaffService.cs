using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.IService;
using Test.Model;

namespace Test.Services
{
    public class StaffService : NHibernateHelper, IStaffService
    {
    }
}