using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestErase
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEncodedEventArgs args)
        {
            Console.WriteLine("MailService: Mail is being sent out now..." + args.Video.Title );
        }
    }
}
