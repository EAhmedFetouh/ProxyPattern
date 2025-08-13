
using ProxyPattern;

Console.OutputEncoding = System.Text.Encoding.UTF8;




IVideoDownloader downloader = new CachedVideoDowloaderProxy();

downloader.Download("https://video.com/1");
downloader.Download("https://video.com/2");
downloader.Download("https://video.com/1");