using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{

	class Program
	{
		public static string[] FindRestaurant(string[] list1, string[] list2)
		{
			if (list1.Length == 0 || list2.Length == 0)
				return null;

			
			//int x = 2;
			
			Dictionary<string, int> store = new Dictionary<string, int>();
			int low = Int32.MaxValue;
			//Stack<string>
			List<string> res = new List<string>();
			for (int i = 0; i < list1.Length; i++)
			{
				store.Add(list1[i],i);
			}

			for (int i = 0; i < list2.Length; i++)
			{
				if (store.ContainsKey(list2[i]))
				{
					store[list2[i]] += i;

					if (store[list2[i]] < low)
					{
						res.Clear();
						low = store[list2[i]];
						res.Add(list2[i]);
					}
					else if(store[list2[i]]==low)
					{
						res.Add(list2[i]);
					}
				}
				
			}

			return res.ToArray();
		}


		public static string FindLongestSubStiring(string s)
		{
			HashSet<char> set = new HashSet<char>();

			string longestOverAll = "";
			string longestTillNow = "";

			s = s.ToLower();
			
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];

				if (set.Contains(c))
				{
					longestTillNow = "";
					set.Clear();
				}

				longestTillNow += c;
				set.Add(c);
				if (longestTillNow.Length > longestOverAll.Length)
					longestOverAll = longestTillNow;

			}

			return longestOverAll;
		}











		//string[] s = new string[];



		//if(list1.Contains())
		//			for (int i = 0; i < list1.Length; i++)
		//			{
		//				store.Add(list1[i],i);
		//			}
		//
		//			for (int i = 0; i < list2.Length; i++)
		//			{
		//				if (store.ContainsKey(list2[i]))
		//				{
		//					store[list2[i]] += i;
		//					
		//					low++;
		//
		//				}
		//			}
		//
		//			if (low == 1)
		//				return store;
		public static string[] FindRelativeRanks(int[] nums)
		{
			//int max1, max2, max3;
			Dictionary<int,int> dict = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				dict.Add(nums[i],i);
			}

			Array.Sort(nums);

			string[] res = new string[nums.Length];

			for (int i = nums.Length - 1; i >= 0; i--)
			{
				int k = nums.Length - 1 - i;
				if (k == 0)
					res[dict[nums[i]]] = "Gold Medal";
				else if (k == 1)
					res[dict[nums[i]]] = "Silver Medal";
				else if (k == 2)
					res[dict[nums[i]]] = "Bronze Medal";
				else
					res[dict[nums[i]]] = (k + 1).ToString();
			}

			return res;

		}

		public bool RotateString(string A, string B)
		{

//			char[] dupA = A.ToCharArray();
//			char[] dupB = B.ToCharArray();
//
//			Array.Sort(dupA);
//			Array.Sort(dupB);
//
//			string t1 = new string(dupA);
//			string t2 = new string(dupB);
//
//			if (t1 == t2)
//				return true;
//			else
//				return false;
			return A.Length == B.Length && (A + A).Contains(B);
		}

		static void Main(string[] args)
		{

//			string[] s1 = new string[]{ "dsjcldesl", "Tapioca Express", "Burger King", "KFC" };
//			string[] s2 = new string[]{ "KFC", "Shogun", "Burger King" };
//
//			foreach (var v in FindRestaurant(s1, s2))
//			{
//				Console.WriteLine(v);
//			}
//
//			int x = 4;
//			int y = 1;
//
//			Console.WriteLine("X : {0} and Y : {1}", Convert.ToString(x,2).PadLeft(2^31,'0'), Convert.ToString(y, 2).PadLeft(2 ^ 31, '0'));

			Console.WriteLine("FindLongestSubStiring(\"Dheeraj\") is : " + FindLongestSubStiring("DhEeraj"));
			
			DivideByZeroException

		}
	}
}
