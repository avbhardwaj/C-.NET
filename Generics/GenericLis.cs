using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	public class GenericLists<TKey, TValue>
	{
		public void AddKey(TKey key)
		{
		}

		public void AddValue(TValue value)
		{
		}
	}

	public class GenericList<T>
	{
		public void Add(T value)
		{
		}

		public T this[int index]
		{
			get { throw new NotImplementedException(); }
		}
	}

	class GenericLis
	{
	}
}