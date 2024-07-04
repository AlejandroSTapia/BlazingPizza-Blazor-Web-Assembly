using Microsoft.Extensions.DependencyInjection;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.Common
{
    public class HttpClientConfigurator(
        Action<HttpClient> configureHttpClient, //simple
        Action<IHttpClientBuilder> configureNamedHttpClient = null //http client cn nombre
        )
    {
        //lo exponemos
        public Action<HttpClient> ConfigureHttpClient => configureHttpClient;
        public Action<IHttpClientBuilder> ConfigureNamedHttpClient => configureNamedHttpClient;
    }
}
