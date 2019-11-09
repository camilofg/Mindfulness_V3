using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mindfulness_Hub_V3.Service;
using Unity;
using Unity.Lifetime;

namespace Mindfulness_Hub_V3
{
    public static class DependencyInjector
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();

        public static void Init()
        {
            UnityContainer.RegisterType(typeof(IRepository<>), typeof(Repository<>));
        }

        public static void Register<I, T>() where T : I
        {
            UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }

        public static void InjectStub<I>(I instance)
        {
            UnityContainer.RegisterInstance(instance, new ContainerControlledLifetimeManager());
        }

        public static T Retrieve<T>()
        {
            return UnityContainer.Resolve<T>();
        }
    }
}
