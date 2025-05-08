using System;
using System.Net.Http;

namespace KPZ.Lab3.Task5
{
    public class NetworkImageStrategy : IImageLoadingStrategy
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        
        public byte[] LoadImage(string url)
        {
            try
            {
                return _httpClient.GetByteArrayAsync(url).Result;
            }
            catch
            {
                throw new Exception($"Failed to download image from {url}");
            }
        }
    }
}