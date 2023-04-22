using DemoClassLib.Models;


namespace DemoClassLib.DataAccess;


public interface IEmployeeDataAccess
{
	Employee AddEmployee(string firstName, string lastName, string department, decimal salary);
	Employee? GetEmployeeById(int employeeId);
	List<Employee> GetEmployees();
}