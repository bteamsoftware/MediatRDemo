using DemoClassLib.Models;
using System.Collections.Generic;
using System.Linq;


namespace DemoClassLib.DataAccess
{
	public class DemoEmployeeDataAccess : IEmployeeDataAccess
	{
		private readonly List<Employee> _employees;


		public DemoEmployeeDataAccess()
		{
			_employees = new List<Employee>()
			{
				new Employee()
				{
					Id = 1,
					FirstName = "Sam",
					LastName = "Smith",
					Department = "Marketing",
					Salary = 60000.00m
				},
				new Employee()
				{
					Id = 2,
					FirstName = "Jeremy",
					LastName = "Johnson",
					Department = "Legal",
					Salary = 120000.00m
				},
				new Employee()
				{
					Id = 3,
					FirstName = "Peter",
					LastName = "Parker",
					Department = "Leadership",
					Salary = 150000.00m
				},
				new Employee()
				{
					Id = 4,
					FirstName = "Jim",
					LastName = "Jones",
					Department = "IT",
					Salary = 130000.00m
				}
			};
		}


		public List<Employee> GetEmployees() => _employees;


		public Employee GetEmployeeById(int employeeId)
		{
			return (from employee in _employees
					where employee.Id == employeeId
					select employee).FirstOrDefault();
		}


		public Employee AddEmployee(string firstName, string lastName, string department, decimal salary)
		{
			Employee employee = new Employee()
			{
				Id = _employees.Max(e => e.Id) + 1,
				FirstName = firstName,
				LastName = lastName,
				Department = department,
				Salary = salary
			};

			_employees.Add(employee);

			return employee;
		}
	}
}
