using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mixed_Content
{
    class Program
    {

        static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();
            var results = new List<string>();
            var separator = new[] { ',' };
            string line;
            var removeText = new Regex("[^.0-9]");

            using (sr)
            {
                line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            int length = lines.Count;

            for (int i = 0; i < length; i++)
            {
                line = lines[i];

                List<string> words;
                if (CheckWords(line))
                {
                    string removeDigitsFromLine = Regex.Replace(line, @"[\d-]", String.Empty);
                    words = removeDigitsFromLine.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                else
                {
                    words = new List<string>();
                }
                List<string> digits;
                if (CheckDigits(line))
                {
                    string removeTextFromLine = removeText.Replace(line, ",");
                    digits = removeTextFromLine.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                else
                {
                    digits = new List<string>();
                }

                string result = Separate(words, digits);
                results.Add(result);
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }

        public static string Separate(List<string> words, List<string> digits)
        {
            string result, resultWords = "", resultDigits = "";

            int wordsLength = words.Count;
            int digitsLength = digits.Count;

            if (wordsLength != 0)
            {
                for (int i = 0; i < wordsLength - 1; i++)
                {
                    resultWords += words[i] + ",";
                }
                resultWords += words[wordsLength - 1];
            }
            if (digitsLength != 0)
            {
                for (int i = 0; i < digitsLength - 1; i++)
                {
                    resultDigits += digits[i] + ",";
                }
                resultDigits += digits[digitsLength - 1];
            }

            if (resultWords != "" && resultDigits != "")
            {
                result = resultWords + "|" + resultDigits;
            }
            else if (resultWords == "")
            {
                result = resultDigits;
            }
            else if (resultDigits == "")
            {
                result = resultWords;
            }
            else
            {
                result = "";
            }
            return result;
        }

        public static bool CheckDigits(string line)
        {
            int length = line.Length;

            for (int i = 0; i < length; i++)
            {
                if (Char.IsDigit(line[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CheckWords(string line)
        {
            int length = line.Length;

            for (int i = 0; i < length; i++)
            {
                if (Char.IsLetter(line[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}