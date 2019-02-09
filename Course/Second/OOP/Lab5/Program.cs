using System;
using Lab5.Model;

namespace Lab5
{
	class Program
	{
		static void Main(string[] args)
		{
			var technicaEmployee = new TechnicalEmployee("Libby");
			var businessEmployee = new BusinessEmployee("Bob");

			Console.WriteLine(technicaEmployee.EmployeeStatus());
			Console.WriteLine(businessEmployee.EmployeeStatus());

			Console.ReadKey();
		}
	}
}
