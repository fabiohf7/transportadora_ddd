using Autofac;
using FluentValidation;
using MediatR;
using System.Reflection;
using TransportadoraFabriq.Application.Transporte.Command;
using TransportadoraFabriq.Application.Transporte.Validations;
using TransportadoraFabriq.Infra.Data.Repository.Base;
using TransportadoraFabriq.Shared.Entities.Interfaces;

namespace TransportadoraFabriq.WebAPI.Config.IoC
{
    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Repository<>).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IRepository<>));

            builder.RegisterAssemblyTypes(typeof(AdicionarMotoristaCommand).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>));

            builder.RegisterAssemblyTypes(typeof(AdicionarMotoristaValidator).GetTypeInfo().Assembly)
             .Where(t => t.IsClosedTypeOf(typeof(IValidator<>)))
             .AsImplementedInterfaces();
        }
    }
}
