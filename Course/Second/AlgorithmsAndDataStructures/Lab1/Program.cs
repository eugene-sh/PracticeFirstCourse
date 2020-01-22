using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
	class Program
	{
		private const int StackSize = 10;
		private const int MaxStackValue = 100;
		private const int MinStackValue = -100;

		static void Main()
		{
			var firstStack = GetRandomIntStack();
			var secondStack = GetRandomIntStack();

            PrintStack(firstStack, "Первый стек");
            PrintStack(secondStack, "Второй стек");

			var resultStack = new Stack<int>();

			foreach (var item in firstStack.Where(i => i > 0))
				resultStack.Push(item);
			
			foreach (var item in secondStack.Where(i => i > 0))
				resultStack.Push(item);

            PrintStack(resultStack.OrderByDescending(i => i), "Итоговый стек");
        }

		private static Stack<int> GetRandomIntStack()
		{
			var stack = new Stack<int>();
			var orderedList = GenerateRandomListOfNumbers().OrderBy(x => x);			

			foreach (var item in orderedList)
				stack.Push(item);

			return stack;
		}

		private static IEnumerable<int> GenerateRandomListOfNumbers() 
		{
			var random = new Random();

			for(var i = 0; i < StackSize; i++)
				yield return random.Next(MinStackValue, MaxStackValue);	
		}

        private static void PrintStack<T>(IEnumerable<T> stack, string msg)
        {
            Console.WriteLine(msg);

            foreach (var item in stack)
                Console.WriteLine(item);
        }
	}
}
