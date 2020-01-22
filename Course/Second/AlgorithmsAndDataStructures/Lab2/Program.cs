using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
		private const int ListLength = 10;
		private const int MaxListValue = 2;
		private const int MinListValue = -1;
        
        static void Main(string[] args)
        {
            var list = GetRandomIntList();
            PrintList(list, "Заданный список");
            
            list = list.Where(i => i != 0).ToList();
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
