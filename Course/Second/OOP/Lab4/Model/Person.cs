namespace Lab4.Model
{
	public abstract class Person
	{
		public string Name { get; set; }

		public Person(string name)
		{
			Name = name;
		}
	}
}
