using System;

namespace Lab3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			var Car1 = new Car
			{
				Color = "White",
				Year = 2010,
				Mileage = 11000
			};

			var Car2 = new Car("Red", 2008);

			var carCount = Car.CountCars();
			
			Console.WriteLine($"There are {carCount} cars on inventory right now.");
			Console.ReadKey();
		}
	}
}