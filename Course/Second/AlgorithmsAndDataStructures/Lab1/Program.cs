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
			var firstStack = new Stack<int>();
			var secondStack = new Stack<int>();

			StackInitializer(firstStack);
			StackInitializer(secondStack);


			foreach(var item in firstStack)
				Console.WriteLine(item);

			
			foreach(var item in secondStack)
				Console.WriteLine(item);
			
		}

		private static void StackInitializer(Stack<int> stack)
		{
			var orderedList = GenerateRandomListOfNumbers().OrderBy(x => x);			

			foreach(var item in orderedList)
				stack.Push(item);
		}

		private static IEnumerable<int> GenerateRandomListOfNumbers() 
		{
			var randomize = new Random();

			for(var i = 0; i < StackSize; i++)
				yield return randomize.Next(MinStackValue, MaxStackValue);	
		}
	}
}
