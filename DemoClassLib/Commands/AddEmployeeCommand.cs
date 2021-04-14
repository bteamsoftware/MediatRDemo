using DemoClassLib.Models;
using MediatR;


namespace DemoClassLib.Commands
{
	public record AddEmployeeCommand(string FirstName, string LastName, string Department, decimal Salary) : IRequest<Employee>;
}
