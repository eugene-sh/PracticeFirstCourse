namespace Lab5.Model
{
	class BusinessEmployee : Employee
	{
		public double BonusBudget = 1000;

		public BusinessEmployee(string name) : base(name, 50000)
		{
		}

		public override string EmployeeStatus()
		{
			return ToString() + " with a budget of " + BonusBudget;
		}
	}

}
