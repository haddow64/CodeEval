using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Hidden_Digits
{
    static class Program
    {
        static void Main(string[] args)
        {
            const string abc = "abcdefghij";
            const string num = "0123456789";
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var sb = new StringBuilder();

                    if (line != null)
                        foreach (char c in line)
                        {
                            if (abc.Contains(c))
                                sb.Append(num[abc.IndexOf(c)]);
                            else if (num.Contains(c))
                                sb.Append(c);
                        }
                    Console.WriteLine(string.IsNullOrEmpty(sb.ToString()) ? "NONE" : sb.ToString());
                }
        }
    }
}