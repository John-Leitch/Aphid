using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Components.ObjectDatabase.Tests;
using MethodDecorator.Fody.Interfaces;

[module: ObjectDatabaseSetup]

namespace Components.ObjectDatabase.Tests
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly | AttributeTargets.Module)]
    public class ObjectDatabaseSetupAttribute : Attribute, IMethodDecorator
    {
        public void Init(object instance, MethodBase method, object[] args)
        {
            var argTable = method.GetParameters().Select(x => x.Name).AsKeyFor(args);

            ((ObjectDatabaseTestBase)instance).DB.Set(
                (bool)argTable.GetOrAdd("setEntityMetaData", false),
                (bool)argTable.GetOrAdd("trackEntities", false),
                (bool)argTable.GetOrAdd("isReadOnly", false),
                (int)argTable.GetOrAdd("pageSize", 0x1000));
        }

        public void OnEntry()
        {
        }

        public void OnExit()
        {
        }

        public void OnException(Exception exception)
        {
        }
    }
}
