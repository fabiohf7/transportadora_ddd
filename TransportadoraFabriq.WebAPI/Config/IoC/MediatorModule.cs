using Autofac;
using MediatR;
using System.Reflection;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.WebAPI.Config.IoC
{
    public class MediatorModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
                .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(typeof(AdicionarEventoCommand).GetTypeInfo().Assembly).
            //    AsClosedTypesOf(typeof(IRequestHandler<,>));

            builder.Register<ServiceFactory>(context =>
            {
                var componentContext = context.Resolve<IComponentContext>();
                return t => { return componentContext.TryResolve(t, out object o) ? o : null; };
            });

            builder.RegisterType<NotificationDomainHandler>().As<INotificationHandler<NotificationDomain>>()
               .InstancePerLifetimeScope();

            //builder.RegisterGeneric(typeof(LoggingBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            //builder.RegisterGeneric(typeof(ValidatorCommandBehavior<,>)).As(typeof(IPipelineBehavior<,>));
        }
    }
}
