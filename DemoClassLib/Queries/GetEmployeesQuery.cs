using DemoClassLib.Models;
using MediatR;
using System.Collections.Generic;


namespace DemoClassLib.Queries
{
	public record GetEmployeesQuery() : IRequest<List<Employee>>;
}
