using System;

using Lab4.Model;

namespace Lab4
{
	class Program
	{
		static void Main(string[] args)
		{
			var uProgram = new UProgram("Информационные технологии")
			{
				Degree = new Degree("Магистратура")
					.AddCourse(new Course("Программирование")
						.AddStudent(new Student("Миша"))
						.AddStudent(new Student("Паша"))
						.AddStudent(new Student("Коля"))
						.AddTeacher(new Teacher("Ольга Владимировна")))
			};

			Console.WriteLine($"Программа - '{uProgram.Name}' Степень - '{uProgram.Degree.Name}'");
			foreach (var course in uProgram.Degree.Courses)
			{
				Console.WriteLine($"Курс - '{course.Name}' в степени - '{uProgram.Degree.Name}'");
				Console.WriteLine($"Кол-во студентов - '{course.Students.Count}'");
			}

			Console.ReadKey();
		}
	}
}

