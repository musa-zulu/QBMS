﻿using System.Web.Mvc;
using Castle.Components.DictionaryAdapter;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace QBMS.Web.Bootstrappers
{
    public interface IWindsorBootstrapper
    {
        IWindsorContainer Boostrap();
    }

    public class WindsorBootstrapper : IWindsorBootstrapper
    {

        public IWindsorContainer Boostrap()
        {
            var factory = CreateDictionaryAdapterFactory();

            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            container.Register(Component.For<IWindsorContainer>()
                .Instance(container));

            SetControllerFactory(container);

            return container;
        }

        private static void SetControllerFactory(WindsorContainer container)
        {
            var windsorControllerFactory = container.Resolve<IControllerFactory>();
            ControllerBuilder.Current.SetControllerFactory(windsorControllerFactory);
        }

        private DictionaryAdapterFactory CreateDictionaryAdapterFactory()
        {
            return new DictionaryAdapterFactory();
        }
    }
}