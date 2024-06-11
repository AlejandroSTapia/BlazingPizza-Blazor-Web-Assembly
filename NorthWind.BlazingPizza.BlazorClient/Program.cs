using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.RazorViews.Routing;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//registramos nuestros servicios, modelos y viewModels
builder.Services.AddBlazingPizzaServices(
	blazingPizzaOptions =>
	builder.Configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
	.Bind(blazingPizzaOptions));

await builder.Build().RunAsync();
