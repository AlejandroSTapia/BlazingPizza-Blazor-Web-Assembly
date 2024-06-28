using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
