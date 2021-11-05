using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Entities
{
    public class Staff
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}