using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealVideoDownloader : IVideoDownloader
    {
        public void Download(string url)
        {
            Console.WriteLine($"📥 Downloading video from: {url}");
            Thread.Sleep(5000); 
            Console.WriteLine("✅ Download complete.\n");
        }
    }

}
