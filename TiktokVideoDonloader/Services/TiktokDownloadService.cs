using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TiktokVideoDonloader.Helper;
using TiktokVideoDonloader.Models;

namespace TiktokVideoDonloader.Services
{
    public class TikTokDownloadService
    {
        private readonly HttpClient _httpClient;

        public TikTokDownloadService()
        {
            _httpClient = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.All
            });
        }

        public async Task DownloadVideoAsync(TikTokModel model, string savePath,
            IProgress<(int, long, long)> progress, CancellationToken token)
        {
            try
            {
                var url = await VideoHelper.GetNoWatermarkUrl(model.UrlLink);
                var uri = new Uri(url);

                using var response = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead, token);
                response.EnsureSuccessStatusCode();

                var totalBytes = response.Content.Headers.ContentLength ?? -1;
                var userDir = Path.Combine(savePath, model.User.Replace("@", ""));
                Utilities.CreateIfMissing(userDir);

                var filePath = Path.Combine(userDir, $"{model.ID}.mp4");

                await using var stream = await response.Content.ReadAsStreamAsync(token);
                await using var fileStream = new FileStream(filePath, FileMode.Create);

                var buffer = new byte[8192];
                var totalRead = 0L;
                var moreToRead = true;

                do
                {
                    token.ThrowIfCancellationRequested();

                    var read = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                    if (read == 0)
                    {
                        moreToRead = false;
                    }
                    else
                    {
                        await fileStream.WriteAsync(buffer, 0, read, token);
                        totalRead += read;

                        var progressPercentage = (int)((double)totalRead / totalBytes * 100);
                        progress?.Report((progressPercentage, totalRead, totalBytes));
                    }
                } while (moreToRead);
            }
            catch (OperationCanceledException)
            {
                File.Delete(savePath);
                throw;
            }
        }
    }
}
