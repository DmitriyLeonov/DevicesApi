using Domain.Interfaces;
using DomainServices.Services;
using Microsoft.Practices.Unity;

namespace DependencyInjection.Modules
{
    public class DomainDeviceModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDevicesService, DeviceServices>(new HierarchicalLifetimeManager());
        }
    }
}
