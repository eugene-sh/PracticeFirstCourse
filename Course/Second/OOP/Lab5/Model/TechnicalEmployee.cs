namespace Lab5.Model
{
	public class TechnicalEmployee : Employee
	{
		public int successfulCheckIns = 5;

		public TechnicalEmployee(string name) : base(name, 75000)
		{
		}

		public override string EmployeeStatus()
		{
			return ToString() + " has " + successfulCheckIns + " successful checkins";
		}
	}
}
