using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class CachedVideoDowloaderProxy : IVideoDownloader
    {
        private readonly RealVideoDownloader _downloader = new();
        private readonly Dictionary<string, string> _cache = new();
        public void Download(string url)
        {
            if (_cache.ContainsKey(url)) 
            {
                Console.WriteLine($"Serving video from chache {url}");
            }

            else
            {
                _downloader.Download(url);
                _cache[url] = "Cached Copy";
            }
        }
    }
}
