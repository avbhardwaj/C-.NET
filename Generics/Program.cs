using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	partial class Program
	{
		static void Main(string[] args)
		{
			// Checking the 1st Impleentation of Generic Class
			var numbers = new GenericList<int>();
			numbers.Add(10);
			//Checking Nullable using Generics
			var valued = new Nullable<int>(10);
			var notValued = new Nullable<double>();
			Console.WriteLine("Valued Has Value: " + valued.HasValue);
			Console.WriteLine("Valued Value: " + valued.GetValueOrDefault());
			Console.WriteLine("notValued Has Value: " + notValued.HasValue);
			Console.WriteLine("notValued Value: " + notValued.GetValueOrDefault());
			bool? res = null;
			Console.WriteLine("Boolean Value is : {0}", res.GetValueOrDefault());
			Console.ReadLine();
		}
	}
}