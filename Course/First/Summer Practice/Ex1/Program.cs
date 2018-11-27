using System;
using System.Linq;

using static System.Console;

namespace Ex1
{
	class Program
	{
		static void Main()
		{
			Write("Please, enter any natural number: ");

			if (!int.TryParse(ReadLine(), out int input))
				throw new ArgumentException("Error. Only natural numbers.");

			var mask = 1; // 0000_0000_0000_0001
			var resultNumbers = Enumerable.Range(1, input).Where(n => (n & mask) == 1);

			foreach (var i in resultNumbers)
				WriteLine(i);
		}
	}
}
