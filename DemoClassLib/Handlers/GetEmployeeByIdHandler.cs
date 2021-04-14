using DemoClassLib.DataAccess;
using DemoClassLib.Models;
using DemoClassLib.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;


namespace DemoClassLib.Handlers
{
	public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
	{
		private readonly IEmployeeDataAccess _dataAccess;


		public GetEmployeeByIdHandler(IEmployeeDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}


		public Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_dataAccess.GetEmployeeById(request.Id));
		}
	}
}
