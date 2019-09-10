using AutoMapper;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace QBMS.Web.Bootstrappers.Ioc.Installers
{
    public class AutoMapperInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .BasedOn<Profile>()
                .WithServiceBase());

            container.Register(
                Component.For<IMapper>().UsingFactoryMethod(ResolveProfiles)
                    .LifestyleSingleton());
        }

        private IMapper ResolveProfiles(IKernel k)
        {
            var profiles = k.ResolveAll<Profile>();

            Mapper.Initialize(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            });

            foreach (var profile in profiles)
            {
                k.ReleaseComponent(profile);
            }

            return Mapper.Instance;
        }
    }
}