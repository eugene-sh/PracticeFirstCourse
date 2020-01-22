using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
		private const int ListLength = 3;
		private const int MaxListValue = 9;
		private const int MinListValue = 0;

        static void Main(string[] args)
        {
            var list = GetRandomIntList();
            PrintList(list, "Заданный список");

            var tmp = list[0];
            list[0] = list[ListLength - 1];
            list[ListLength - 1] = tmp;

            PrintList(list, "Обработанный список");
        }

        private static List<int> GetRandomIntList()
        {
			var list = new List<int>();

			foreach (var item in GenerateRandomListOfNumbers())
				list.Add(item);

			return list;
        }

        private static IEnumerable<int> GenerateRandomListOfNumbers() 
		{
			var random = new Random();

			for(var i = 0; i < ListLength; i++)
				yield return random.Next(MinListValue, MaxListValue);	
		}

        private static void PrintList<T>(IEnumerable<T> list, string msg)
        {
            Console.WriteLine(msg);

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
