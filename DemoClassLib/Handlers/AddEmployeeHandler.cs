using DemoClassLib.Commands;
using DemoClassLib.DataAccess;
using DemoClassLib.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;


namespace DemoClassLib.Handlers
{
	public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
	{
		private readonly IEmployeeDataAccess _dataAccess;


		public AddEmployeeHandler(IEmployeeDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}


		public Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_dataAccess.AddEmployee(request.FirstName, request.LastName,
																		  request.Department, request.Salary));
		}
	}
}
