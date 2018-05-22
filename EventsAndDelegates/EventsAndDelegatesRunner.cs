using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	class EventsAndDelegatesRunner
	{
		static void Main(string[] args)
		{
			var video = new Video() {Title = "Awesome"};
			var encoder = new VideoEncoder();
			var mailService = new MailService();

			encoder.VideoEncoded += mailService.OnVideoEncoded;

			encoder.Encode(video);
		}

		
	}
}
