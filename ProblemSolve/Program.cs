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

			char[] c1 = s1.ToLower().ToCharArray();
			char[] c2 = s2.ToLower().ToCharArray();


			Array.Sort(c1);
			Array.Sort(c2);

			
			String temp1 = new String(c1);
			String temp2 = new String(c2);

			c1 = s1.ToUpper().ToCharArray();
			c2 = s2.ToUpper().ToCharArray();

			Array.Sort(c1);
			Array.Sort(c2);

			String temp3 = new String(c1);
			String temp4 = new String(c2);

			if ((temp1 == temp2) && (temp3==temp4))
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

			var elapsedSeconds = (double)watch.Elapsed.Seconds;
			if (result == true)
				Console.WriteLine("Strings are Anagram");
			else
				Console.WriteLine("Strings are not Anagrams");
			watch.Stop();
			//var sec
			Console.WriteLine("Prolem Computed in : " + elapsedSeconds + " seconds");

			Console.ReadLine();
		}
	}
}