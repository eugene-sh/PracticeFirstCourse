using System;

namespace Lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			var car1 = new Car
			{
				Color = "White",
				Year = 2010,
				Mileage = 11000
			};

			Console.WriteLine($"This car is painted {car1.Color}, was built in {car1.Year}, and has {car1.Mileage} miles on it.");
			Console.ReadLine();
		}
	}

	public class Car
	{
		public string Color { get; set; }
		public int Year { get; set; }
		public int Mileage { get; set; }
	}
}
