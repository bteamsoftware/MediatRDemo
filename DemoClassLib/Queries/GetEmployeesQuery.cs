using DemoClassLib.Models;
using MediatR;


namespace DemoClassLib.Queries;


public record GetEmployeesQuery() : IRequest<List<Employee>>;
