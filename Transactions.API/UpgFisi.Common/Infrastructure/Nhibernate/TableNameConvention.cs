using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Text;

namespace UpgFisi.Common.Infrastructure.Nhibernate
{
    public class TableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(Util.GetTableName(instance.EntityType.Name));
        }
    }
}
