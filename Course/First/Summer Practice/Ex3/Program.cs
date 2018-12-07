using System;
using System.Linq;
using System.Text;

using static System.Console;

namespace Ex3
{
	class Program
	{
		static void Main()
		{
			Write("Please, enter any sentence: ");
			var input = ReadLine();

			if (string.IsNullOrWhiteSpace(input))
				throw new ArgumentException("Invalid entered sentence.");

			var collection = input
				.Split()
				.Select(w => new
				{
					sourceWord = w,
					wordWithoutVowels = TrimVowelLetters(w)
				})
				.OrderBy(w => w.wordWithoutVowels.Length);

			foreach (var item in collection)
				WriteLine($"{item.sourceWord} - {item.wordWithoutVowels} - {item.wordWithoutVowels.Length}");
		}

		static string TrimVowelLetters(string word)
		{
			const string consonants = "bcdfghklmnpstvwxz";
			var resultWordBuilder = new StringBuilder();

			foreach (var letter in word.ToLower())
				if (consonants.Contains(letter))
					resultWordBuilder.Append(letter);

			return resultWordBuilder.ToString();
		}
	}
}
