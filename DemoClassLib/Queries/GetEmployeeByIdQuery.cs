using DemoClassLib.Models;
using MediatR;


namespace DemoClassLib.Queries
{
	public record GetEmployeeByIdQuery(int Id) : IRequest<Employee>;
}
