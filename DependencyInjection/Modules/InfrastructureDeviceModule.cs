using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureServices.Repositories;
using Infrasturcture.Interfaces;
using Microsoft.Practices.Unity;

namespace DependencyInjection.Modules
{
    public class InfrastructureDeviceModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDevicesInterface, FakeDevicesRepository>(new HierarchicalLifetimeManager());
        }
    }
}
