using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryImplementation
{
	class Program
	{
		static void Main(string[] args)
		{
			var dict = new Dictionary<int, String>();
			Console.WriteLine("How Many Book's do u want to store: ");
			int tKeys = Convert.ToInt32(Console.ReadLine());
			String BookName = "";
			for (int i = 1; i <= tKeys; i++)
			{
				Console.WriteLine("Enter Name for Book {0}:  ", i);
				BookName = Console.ReadLine();
				dict.Add(i, BookName);
			}

			foreach (KeyValuePair<int, String> temp in dict)
			{
				Console.WriteLine("Book {0} is {1}", temp.Key, temp.Value);
			}

			Console.WriteLine("Please Enter The name of the book you are searching for: ");
			BookName = Console.ReadLine();
			if (dict.ContainsValue(BookName))
				Console.WriteLine("Your Book is stored in id ");
			else
				Console.WriteLine("NO BOOK FOUND");
			Console.ReadLine();
		}
	}
}