using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestErase
{
    public class TextService
    {
        public void OnVideoEncoded(object source, VideoEncodedEventArgs args)
        {
            Console.WriteLine("TextService: A text message has been sent..." + args.Video.Title);
        }
    }
}
