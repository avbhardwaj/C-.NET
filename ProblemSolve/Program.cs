using System;

namespace ProblemSolve
{
	class Program
	{
		public static bool IsAnagram(String s1, String s2)
		{
			if (s1.Length != s2.Length)
			{
				return false;
			}

			char[] c1 = s1.ToCharArray();
			char[] c2 = s2.ToCharArray();

			Array.Sort(c1);
			Array.Sort(c2);

			String temp1 = new String(c1);
			String temp2 = new String(c2);

			if (temp1 == temp2)
				return true;
			else
				return false;
		}

		public static void Main(string[] args)
		{
			// the code that you want to measure comes here

			Console.WriteLine("Enter 1st String : ");
			String s1 = Console.ReadLine();
			Console.WriteLine("Enter 2nd String : ");
			String s2 = Console.ReadLine();
			var watch = System.Diagnostics.Stopwatch.StartNew();
			bool result = IsAnagram(s1, s2);

			var elapsedMs = watch.ElapsedMilliseconds;
			if (result == true)
				Console.WriteLine("Strings are Anagram");
			else
				Console.WriteLine("Strings are not Anagrams");
			watch.Stop();
			Console.WriteLine("Prolem Computed in : " + elapsedMs + " milliseconds");

			Console.ReadLine();
		}
	}
}