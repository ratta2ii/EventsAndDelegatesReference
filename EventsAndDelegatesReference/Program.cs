using System;

namespace TestErase
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Harry Potter" };

            var videoEncoder = new VideoEncoder(); // provider

            var mailService = new MailService(); // subscriber
            var textService = new TextService(); // subscriber

            // Subscribing to the event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
