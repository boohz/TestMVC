using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Entities;

namespace Test.Map
{
    public sealed class StaffMap : ClassMap<Staff>
    {
        public StaffMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Table("Staff");
        }
    }
}