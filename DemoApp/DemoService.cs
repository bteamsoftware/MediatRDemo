using DemoClassLib.Commands;
using DemoClassLib.Models;
using DemoClassLib.Queries;
using MediatR;
using System;
using System.Collections.Generic;

namespace DemoApp
{
	public class DemoService : IDemoService
	{
		private readonly IMediator _mediator;


		public DemoService(IMediator mediator)
		{
			_mediator = mediator;
		}


		public void Run()
		{
			ListEmployees();

			_mediator.Send(new AddEmployeeCommand("Joe", "Schmoe", "Schmoozing", 250000.00m)).Wait();
			Console.WriteLine("\nEmployee added!\n");

			ListEmployees();
		}


		private void ListEmployees()
		{
			List<Employee> list = _mediator.Send(new GetEmployeesQuery()).Result;
			foreach (Employee employee in list)
			{
				Console.WriteLine($"({employee.Id}) {employee.FirstName} {employee.LastName} - {employee.Department} : ${employee.Salary}");
			}
		}
	}
}
