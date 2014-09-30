using System;
using System.IO;

namespace FileSize
{
    static class FileSize
    {
        static void Main(string[] args)
        {
            var fileLen = new FileInfo(args[0]).Length;
            Console.WriteLine(fileLen);
        }
    }
}