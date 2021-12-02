using DemoClassLib.DataAccess;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;


namespace DemoApp
{
	class Program
	{
		static async Task Main(string[] args)
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

			IDemoService service = host.Services.GetService<IDemoService>();
			await service.RunAsync();
			host.Dispose();
		}
	}
}
