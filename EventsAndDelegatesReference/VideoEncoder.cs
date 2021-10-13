using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestErase
{
    public class VideoEncodedEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // OLD WAY (Using a delegate explicity w/ an event)
        // public delegate void VideoEncodedEventHandler(object source, VideoEncodedEventArgs args);
        // public event VideoEncodedEventHandler VideoEncoded;

        // VS

        // EventHandler
        // OR
        // EventHandler<TEventArgs>
        // NEW WAY (See below)

        public event EventHandler<VideoEncodedEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("VideoEncoder: Encoding video now...");
            Thread.Sleep(4000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            var videoArgs = new VideoEncodedEventArgs() { Video = video };

            if (VideoEncoded != null)
                VideoEncoded(this, videoArgs);
        }
    }
}
