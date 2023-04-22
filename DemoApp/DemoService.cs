using DemoClassLib.Commands;
using DemoClassLib.Models;
using DemoClassLib.Queries;
using MediatR;


namespace DemoApp;


public class DemoService : IDemoService
{
	private readonly IMediator _mediator;


	public DemoService(IMediator mediator)
	{
		_mediator = mediator;
	}


	public async Task RunAsync()
	{
		await ListEmployeesAsync();

		await _mediator.Send(new AddEmployeeCommand("Joe", "Schmoe", "Schmoozing", 250000.00m));
		Console.WriteLine("\nEmployee added!\n");

		await ListEmployeesAsync();
	}


	private async Task ListEmployeesAsync()
	{
		List<Employee> list = await _mediator.Send(new GetEmployeesQuery());
		foreach (Employee employee in list)
		{
			Console.WriteLine($"({employee.Id}) {employee.FirstName} {employee.LastName} - {employee.Department} : ${employee.Salary}");
		}
	}
}
