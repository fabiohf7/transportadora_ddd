using Autofac;
using System.Reflection;
using TransportadoraFabriq.Infra.Data.Repository.Base;
using TransportadoraFabriq.Shared.Entities.Interfaces;

namespace TransportadoraFabriq.MVC.Config.IoC
{
    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Repository<>).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IRepository<>));
        }
    }
}
