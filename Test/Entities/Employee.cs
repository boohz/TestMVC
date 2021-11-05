using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.ViewModelsExtension;

namespace Test.Entities
{
    public class Employee
    {
        public virtual int Id { get; set; }
        public virtual string Namn { get; set; }
    }
}