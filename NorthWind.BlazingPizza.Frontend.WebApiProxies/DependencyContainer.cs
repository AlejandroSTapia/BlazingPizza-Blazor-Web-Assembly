using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Orders;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.Checkout;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.Common;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.GetSpecials;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.GetToppings;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.Orders;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies
{
    //Aqui se registran las dependencias
    public static class DependencyContainer
    {
        //este proyecto agrega modelos
        //AddModels metodo de extension para reguistrar las implementacioones
        public static IServiceCollection AddModels(
            this IServiceCollection services,
            HttpClientConfigurator getSpecialsModelConfigurator,
            HttpClientConfigurator getToppingsModelConfigurator,
            HttpClientConfigurator getCheckoutModelConfigurator,
            HttpClientConfigurator ordersModelConfigurator
            )//configuradores
        {
            // Se debe implementar el servicio y registrarlo en la coleccion de servcios del contendedor de inyeccion
            //services.AddScoped<IGetSpecialsModel, GetSpecialsModel>();

            services.AddHttpClient<IGetSpecialsModel,GetSpecialsModel>(getSpecialsModelConfigurator);

            services.AddHttpClient<IGetToppingsModel, GetToppingsModel>(getToppingsModelConfigurator);

            services.AddHttpClient<ICheckoutModel, CheckoutModel>(getCheckoutModelConfigurator);

            services.AddHttpClient<IOrdersModel, OrdersModel>(ordersModelConfigurator);

            return services;
        }

        //fabricas de clientes https para enviar unhttpCLient bien estructurado y configurado
        //Con eso ya se puede construir clients hhtp


        //prpio httpclient y no de netcore
        static IServiceCollection AddHttpClient<TClient, TImplementation>(
            this IServiceCollection services,
            HttpClientConfigurator configurator
            )
            where TClient : class //primer condicion
            where TImplementation : class, TClient
        {
            var Builder = services.AddHttpClient<TClient, TImplementation>(
                configurator.ConfigureHttpClient);

            configurator.ConfigureNamedHttpClient?.Invoke(Builder);

            return services;
        }
    }

 
}
