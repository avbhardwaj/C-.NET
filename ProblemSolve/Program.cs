using System;
using System.Collections.Generic;

namespace ProblemSolve
{
	class Program
	{
		public static bool IsPlaindrome(String S)
		{

			char[] c = S.ToCharArray();
			Array.Reverse(c);
			//				S.
			String s = new String(c);
			if (S == s)
				return true;
			else
			{
				return false;
			}
		}
		public static int NumJewelsInStones(string J, string S)
		{
			//if ((J.Length == 0) || (S.Length == 0))
			//	return 0;
			//char[] c1 = J.ToCharArray();
			//char[] c2 = S.ToCharArray();

			//Array.Sort(c1);
			//Array.Sort(c2);

			int count = 0;
			HashSet<char> jewels = new HashSet<char>();
			for (int i = 0; i < J.Length; i++)
			{
				char c = J[i];
				jewels.Add(c);
			}

			for (int i = 0; i < S.Length; i++)
			{
				if (jewels.Contains(S[i]))
				{
					count++;
				}
			}

			return count;
		}
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

			if ((temp1 == temp2) && (temp3 == temp4))
				return true;
			else
				return false;
		}







		public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
		{
			TreeNode t3 = new TreeNode(t1.val + t2.val);

			//			//Checking for Right Node and Adding
			//			if (t1.right.val != null && t2.right.val != null)
			//			{
			//				t3.right.val = t1.right.val + t2.right.val;
			//			}
			//			else if (t1.right.val == null)
			//			{
			//				t3.right.val = t2.right.val;
			//
			//			}
			//			else if (t2.right.val == null)
			//			{
			//				t3.right.val = t1.right.val;
			//			}
			//			//Checking for Left Node and Adding
			//			if (t1.left.val != null && t2.left.val != null)
			//			{
			//				t3.left.val = t1.left.val + t2.left.val;
			//			}
			//			else if (t1.left.val == null)
			//			{
			//				t3.left.val = t2.left.val;
			//
			//			}
			//			else if (t2.left.val == null)
			//			{
			//				t3.left.val = t1.left.val;
			//			}

			if (t1.Equals(null))
				return t2;
			Stack<TreeNode[]> stack = new Stack<TreeNode[]>();
			stack.Push(new TreeNode[] { t1, t2 });
			while (stack.Count != 0)
			{
				TreeNode[] t = stack.Pop();
				if (t[0].Equals(null) || t[1].Equals(null))
					continue;
				t[0].val += t[1].val;

				if (t[0].left.Equals(null))
					t[0].left = t[1].left;
				else
				{
					stack.Push(new TreeNode[] { t[0].left, t[1].left });
				}

				if (t[0].right.Equals(null))
					t[0].right = t[1].right;
				else
				{
					stack.Push(new TreeNode[] { t[0].right, t[1].right });
				}
			}

			return t1;
		}

		public TreeNode BuildTree(int[] inorder, int[] postorder)
		{
			TreeNode t1 = new TreeNode();
			t1.val = postorder[postorder.Length - 1];
			//HashSet<> set = new HashSet<>();
			for (int i = 0; i < (inorder.Length) / 2; i++)
			{

			}

			return t1;
		}
		public string ReverseString(string s)
		{

			String revString = "";

			for (int i = s.Length - 1; i <= 0; i--)
			{

				revString += s[i];

			}

			return revString;
		}













		public static void Main(string[] args)
		{
			//Check Palindrome
			bool res = IsPlaindrome("MOM");
			Console.WriteLine(res);

			//Check Jewels
			int x = NumJewelsInStones("aA", "aAAbbbb");
			int y = NumJewelsInStones("z", "ZZZ");

			Console.WriteLine("X :" + x + "Y :" + y);
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