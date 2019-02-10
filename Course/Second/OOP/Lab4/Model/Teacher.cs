namespace Lab4.Model
{
	public class Teacher : Person
	{
		public Teacher(string name) : base(name)
		{
		}

		public void GradeTest()
		{
			System.Console.WriteLine("GradeTest");
		}
	}
}
