using NorthWind.BlazingPizza.Backend.BusinnesObjects.Options;
using NorthWind.BlazingPizza.Backend.IoC;
using NorthWind.BlazingPizza.Backend.Presenters;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Registramos nuestros sericios


builder.Services.AddBlazingPizzaServices(
	//delegados
	dbOptions =>
	builder.Configuration.GetRequiredSection(DBOptions.SectionKey)//se le dara su valor de los datos de config
	.Bind(dbOptions), //se enlazan y se da el valor a dboption
	blazingPizzaOptions =>
	builder.Configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
	.Bind(blazingPizzaOptions)
	);

//origen cuzado de servicios
builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(builder =>
	{
		builder.AllowAnyOrigin()
		.AllowAnyHeader()
		.AllowAnyMethod();
	});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseBlazingpizzaEndpoints();//cuando se pida algo, que use los endpints
app.UseCors();

app.Run();
