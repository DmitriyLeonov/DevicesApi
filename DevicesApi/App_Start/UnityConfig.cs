using DependencyInjection;
using DependencyInjection.Modules;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace DevicesApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            Register<DomainDeviceModule>(container);
            Register<DomainUserModule>(container);
            Register<InfrastructureDeviceModule>(container);
            Register<InfrastructureUserModule>(container);
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T : IModule, new()
        {
            new T().Register(container);
        }
    }
}