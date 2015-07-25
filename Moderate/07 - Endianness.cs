using System;

namespace Endianness
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(BitConverter.IsLittleEndian ? "LittleEndian" : "BigEndian");
        }
    }
}