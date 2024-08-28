using DotNet.Validation.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DotNet.Validation.Entities
{
    public static class DependencyContainer
    {
        //de esta manra se registra el modelvalidator hub predeterminado
        public static IServiceCollection AddDefaultModelValidatorHub(this IServiceCollection services)
        {
            services.TryAddScoped(typeof(IModelValidatorHub<>),
                typeof(IModelValidatorHub<>));
            return services;
        }

        //se creo un metodo que permita registrar validadores de modelos
        //faacilitar al programador el registro de los validadores
        public static IServiceCollection
            AddModelValidator<ModelType, ModelValidatorType>(
            this IServiceCollection services) where ModelValidatorType : class, //restricciones par agenericos, el ModelValidatorType debe ser una clase
            IModelValidator<ModelType> //IModelValidator debe ser implementado para el tipo de model correspondiente
        {
            //si si se cumlen lo antwrior
            services.AddDefaultModelValidatorHub();
            services.AddScoped<IModelValidator<ModelType>,
                ModelValidatorType>();

            return services;
        }
    }
}
