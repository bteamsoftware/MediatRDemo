using DemoClassLib.DataAccess;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			IHost host = Host.CreateDefaultBuilder()
								 .ConfigureServices((context, services) =>
								 {
									services.AddSingleton<IEmployeeDataAccess, DemoEmployeeDataAccess>();
									services.AddTransient<IDemoService, DemoService>();
									services.AddLogging();
									services.AddMediatR(typeof(DemoEmployeeDataAccess).Assembly);
								 })
								 .Build();

			IDemoService app = ActivatorUtilities.CreateInstance<DemoService>(host.Services);
			app.Run();
		}
	}
}
