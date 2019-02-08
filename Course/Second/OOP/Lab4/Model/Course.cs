using System.Collections.Generic;

namespace Lab4.Model
{
	public class Course
	{
		public readonly List<Student> Students = new List<Student>();
		public readonly List<Teacher> Teachers = new List<Teacher>();

		public string Name { get; set; }

		public Course(string name)
		{
			Name = name;
		}

		public Course AddStudent(Student newStudent)
		{
			Students.Add(newStudent);
			return this;
		}

		public Course AddTeacher(Teacher newTeacher)
		{
			Teachers.Add(newTeacher);
			return this;
		}
	}
}
