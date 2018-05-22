using System;

namespace Delegates
{
	public class PhotoProcessor
	{
		// Using general way 
		public delegate void PhotoFilterHandler(Photo photo);
		//public void Process(string path, PhotoFilterHandler filterHandler){}
		// Using Action Delegate


		public void Process(string path, Action<Photo> filterHandler)
		{
			//System.Action<>

			//System.Func<>

			var photo = Photo.Load(path);
			var filters = new PhotoFilters();

			//filters.ApplyBrightness(photo);
			//filters.ApplyContrast(photo);
			//filters.Resize(photo);

			filterHandler(photo);

			photo.Save();
		}
	}
}