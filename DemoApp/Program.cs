using DemoApp;
using DemoClassLib.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


IHost host = Host.CreateDefaultBuilder()
	.ConfigureServices((context, services) =>
	{
		services.AddSingleton<IEmployeeDataAccess, DemoEmployeeDataAccess>();
		services.AddTransient<IDemoService, DemoService>();
		services.AddLogging();
		services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(DemoEmployeeDataAccess).Assembly));
		})
	.Build();

IDemoService? service = host.Services.GetService<IDemoService>();
if (service != null)
{
	await service.RunAsync();
}

host.Dispose();
