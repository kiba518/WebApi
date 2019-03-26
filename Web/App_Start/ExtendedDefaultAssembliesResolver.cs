using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http.Dispatcher;
using WebApi;
namespace Web
{

    public class ExtendedDefaultAssembliesResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            //Assembly a = typeof(LoginController).Assembly;
            //AssemblyName assemblyName = a.GetName();
            //if (!AppDomain.CurrentDomain.GetAssemblies().Any(assembly => AssemblyName.ReferenceMatchesDefinition(assembly.GetName(), assemblyName)))
            //{
            //    AppDomain.CurrentDomain.Load(assemblyName);
            //}

            return base.GetAssemblies();
        }
    }
}