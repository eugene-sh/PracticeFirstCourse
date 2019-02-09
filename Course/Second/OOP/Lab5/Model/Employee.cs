using System;

namespace Lab5.Model
{
	public abstract class Employee
	{
		private static int employeeCount = 1;

		public int ID { get; set; }
		public string Name { get; set; }
		public double BaseSalary { get; set; }

		public Employee(string name, double baseSalary)
		{
			ID = employeeCount++;
			Name = name;
			BaseSalary = baseSalary;
		}

		public abstract string EmployeeStatus();

		public override string ToString()
		{
			return $"{ID} {Name}";
		}
	}
}
