using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using QBMS.DB;
using System;

namespace QBMS.Web.Bootstrappers.Ioc.Installers
{
    public class EntityFrameworkInstaller : IWindsorInstaller
    {
        private Func<ComponentRegistration<IQBMSDbContext>, ComponentRegistration<IQBMSDbContext>> _lifestyleConfiguration;

        public EntityFrameworkInstaller()
        {
            _lifestyleConfiguration = ConfigureLifestylePerRequest;
        }
        public EntityFrameworkInstaller(
            Func<ComponentRegistration<IQBMSDbContext>, ComponentRegistration<IQBMSDbContext>> lifestyleConfiguration)
        {
            _lifestyleConfiguration = lifestyleConfiguration;
        }

        private ComponentRegistration<IQBMSDbContext> ConfigureLifestylePerRequest(ComponentRegistration<IQBMSDbContext> componentRegistration)
        {
            return componentRegistration.LifestylePerWebRequest();
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(_lifestyleConfiguration(Component.For<IQBMSDbContext>()
                .ImplementedBy<QBMSDbContext>()));
        }
    }
}