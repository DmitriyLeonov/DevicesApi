using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using DomainServices.Services;
using Microsoft.Practices.Unity;

namespace DependencyInjection.Modules
{
    public class DomainUserModule : IModule
    {
        public void Register(IUnityContainer container)
        {
           container.RegisterType<IUsersService, UserServices>(new HierarchicalLifetimeManager());
        }
    }
}
