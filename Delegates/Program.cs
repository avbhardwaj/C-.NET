using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	class Program
	{
		static void Main(string[] args)
		{
			var processor = new PhotoProcessor();
			//processor.Process("P");
			var filters = new PhotoFilters();
			//PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
			Action<Photo> filterHandler = filters.ApplyBrightness;
			filterHandler += filters.ApplyContrast;
			filterHandler += filters.Resize;
			filterHandler += AddWrinkles;
			processor.Process("p",filterHandler);

			Console.ReadLine();
		}

		static void AddWrinkles(Photo photo)
		{
			Console.WriteLine("Added 2 Wrinkles");
			//return 2;
		}
	}
}
