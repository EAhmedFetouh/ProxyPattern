# Proxy Pattern Example — Cached Video Downloader

## 📖 Overview
This project demonstrates the **Proxy Design Pattern** using a simple example: downloading videos with caching.  
Instead of downloading the same video multiple times, the proxy stores it in a cache and serves it instantly on repeated requests.

## 🛠 Pattern Used
**Proxy Pattern** — A structural design pattern that acts as a substitute or placeholder for another object, controlling access to it.

## 📂 Project Structure
- `IVideoDownloader` — Interface for the downloader.
- `RealVideoDownloader` — Simulates downloading a video (slow process).
- `CachedVideoDownloaderProxy` — Adds caching to avoid repeated downloads.
- `Program.cs` — Demonstrates usage.

## 🚀 How It Works
1. First request → Downloads the video and stores it in cache.
2. Second request for the same URL → Served instantly from cache.

## 💻 Example Output
```
📥 Downloading video from: https://video.com/1
✅ Download complete.

📥 Downloading video from: https://video.com/2
✅ Download complete.

Serving video from cache: https://video.com/1
```

## ▶ Run
```bash
dotnet run
```

## 📺 Video Tutorial
Watch the full explanation on YouTube: [Video Link]

---
**Author:** Ahmed Aboulfotouh
