using System;

namespace Generics
{
	public class Utilities<T> where T : IComparable, new()
	{
		public int Max(int a, int b)
		{
			return a > b ? a : b;
		}

		public void DoSomeThing(T value)
		{
			var initialize = new T();

		}
		public T Max(T a, T b)
		{
			return a.CompareTo(b) > 0 ? a : b;
		}
	}
}