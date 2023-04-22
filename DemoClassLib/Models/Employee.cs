﻿namespace DemoClassLib.Models;


public class Employee
{
	public int Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public string Department { get; set; } = string.Empty;
	public decimal Salary { get; set; }
}
