using System;
using System.IO;

namespace KPZ.Lab3.Task5
{
    public class FileSystemImageStrategy : IImageLoadingStrategy
    {
        public byte[] LoadImage(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"File not found: {path}");
            return File.ReadAllBytes(path);
        }
    }
}