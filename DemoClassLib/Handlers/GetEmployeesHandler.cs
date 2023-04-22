using DemoClassLib.DataAccess;
using DemoClassLib.Models;
using DemoClassLib.Queries;
using MediatR;


namespace DemoClassLib.Handlers;


public class GetEmployeesHandler : IRequestHandler<GetEmployeesQuery, List<Employee>>
{
	private readonly IEmployeeDataAccess _dataAccess;


	public GetEmployeesHandler(IEmployeeDataAccess dataAccess)
	{
		_dataAccess = dataAccess;
	}


	public Task<List<Employee>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken) =>
		Task.FromResult(_dataAccess.GetEmployees());
}
