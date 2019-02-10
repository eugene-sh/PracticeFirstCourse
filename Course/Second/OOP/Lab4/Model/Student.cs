namespace Lab4.Model
{
	public class Student : Person
	{
		public Student(string name) : base(name)
		{
		}

		public void TakeTest()
		{
			System.Console.WriteLine("TakeTest");
		}
	}
}
