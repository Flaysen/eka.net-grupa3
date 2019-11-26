
using Autofac;
using Eventer.AspNetCore.Services;
using Eventer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventer.AspNetCore.Modules
{
    public class EventModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<EventService>().As<IEventService>().InstancePerDependency();
        }
    }
}

