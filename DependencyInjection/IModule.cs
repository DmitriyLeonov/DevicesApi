using Microsoft.Practices.Unity;
using Unity;

namespace DependencyInjection
{
    public interface IModule
    {
        void Register(IUnityContainer container);
    }
}
