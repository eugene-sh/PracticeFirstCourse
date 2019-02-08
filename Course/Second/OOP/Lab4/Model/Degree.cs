using System.Collections.Generic;

namespace Lab4.Model
{
	public class Degree
	{
		public readonly List<Course> Courses = new List<Course>();

		public string Name { get;set; }

		public Degree(string name)
		{
			Name = name;
		}

		public Degree AddCourse(Course course)
		{
			Courses.Add(course);
			return this;
		}
	}
}
