using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
	class Program
	{
		static void Main(string[] args)
		{
			// args => expressions
			// ()=> ... for no arguments
			// one argument no parenthesis needed and if multiple arguments parenthesis is needed.
			
			// Implementing Lambda Expressions Using Func<> Delegate
			// 1st int is the input Parameter and 2nd input is the output Parameter Type
			Func<int, int> cs = calcSquare;// Pointing to a function
			Func<int, int> cs2 = num => num * num;

			Console.WriteLine("USING DEFINED FUNTION" + calcSquare(5));
			Console.WriteLine("USING FUNC REF TO A FUNCTION: " + cs(10));
			Console.WriteLine("USING FUNC REF LAMBDA EXPRESSION: " + cs2(20));
				
			//Finding Books Based on Price Value using Lambda Expressions

			var books = new BookRepository().GetBooks();

			var expensiveBooks = books.FindAll(b => b.Price > 100);// Computes the books that has price greater than 100 in the Book Repository
			foreach (var price in expensiveBooks)
			{
				Console.WriteLine("Expensive Books in List are : {0}", price.Title);// Prints the book/books that are expensive than 100
			}
			

			Console.ReadLine();	
		}

		static int calcSquare(int num)
		{
			return num * num;
		}
	}
}
