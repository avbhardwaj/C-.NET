using System;
using System.Threading;

namespace EventsAndDelegates
{
	public class VideoEncoder
	{
		//Things needed for tringgering an Event in C#

		// 1. Defining a Delegate
		// 2. Definging an event based on that delegate
		// 3. Raise the Event

		public delegate void VideoEncodedEventHandler(object source, EventArgs args);

		public event VideoEncodedEventHandler VideoEncoded;

		public void Encode(Video video)
		{
			Console.WriteLine("Video Encoding...");
			Thread.Sleep(5000);

			OnVideoEncoded();
		}

		protected virtual void OnVideoEncoded()
		{
			VideoEncoded?.Invoke(this, EventArgs.Empty);
		}
	}
}