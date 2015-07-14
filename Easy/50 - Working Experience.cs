using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Working_Experience
{
    public static class WorkingExperience
    {
        private static List<string> parse_dates(string line)
        {
            var dateRanges = line.Trim().Split(';');
            var dates = new List<string>();
            foreach (var entries in dateRanges.Select(t => t.Split('-')))
            {
                dates.Add(entries[0]);
                dates.Add(entries[1]);
            }
            return dates;
        }

        private static void update_work_history(List<string> dates, ref int[,] workHistory)
        {
            for (var i = 0; i < dates.Count; i = i + 2)
            {
                var date1 = dates[i];
                var date2 = dates[i + 1];
                var startMonth = 0;
                var startYear = 0;
                var finishMonth = 0;
                var finishYear = 0;
                parse_date_range(date1, date2, ref startMonth, ref startYear, ref finishMonth, ref finishYear);
                for (var year = startYear; year <= finishYear; ++year)
                {
                    int begin, end;
                    if (startYear == finishYear)
                    {
                        begin = startMonth;
                        end = finishMonth + 1;
                    }
                    else if (year == startYear)
                    {
                        begin = startMonth;
                        end = 12;
                    }
                    else if (year == finishYear)
                    {
                        begin = 0;
                        end = finishMonth + 1;
                    }
                    else
                    {
                        begin = 0;
                        end = 12;
                    }
                    for (var month = begin; month < end; ++month)
                        workHistory[year, month] = 1;
                }
            }
        }

        private static int get_month(string month)
        {
            var result = -1;
            switch (month)
            {
                case "Jan":
                    result = 0;
                    break;
                case "Feb":
                    result = 1;
                    break;
                case "Mar":
                    result = 2;
                    break;
                case "Apr":
                    result = 3;
                    break;
                case "May":
                    result = 4;
                    break;
                case "Jun":
                    result = 5;
                    break;
                case "Jul":
                    result = 6;
                    break;
                case "Aug":
                    result = 7;
                    break;
                case "Sep":
                    result = 8;
                    break;
                case "Oct":
                    result = 9;
                    break;
                case "Nov":
                    result = 10;
                    break;
                case "Dec":
                    result = 11;
                    break;
            }
            return result;
        }

        private static void parse_date_range(string date1, string date2, ref int startMonth, ref int startYear,
            ref int finishMonth, ref int finishYear)
        {
            var tokens = date1.Trim().Split();
            startMonth = get_month(tokens[0]);
            startYear = int.Parse(tokens[1]) - 1990;

            tokens = date2.Trim().Split();
            finishMonth = get_month(tokens[0]);
            finishYear = int.Parse(tokens[1]) - 1990;
        }

        private static int count_months(int[,] workHistory)
        {
            var monthsWorked = 0;
            for (var year = 0; year < 30; ++year)
                for (var month = 0; month < 12; ++month)
                    if (workHistory[year, month] == 1)
                        monthsWorked++;
            return monthsWorked;
        }

        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                        continue;

                    var workHistory = new int[30, 12];
                    for (var i = 0; i < 30; ++i)
                        for (var j = 0; j < 12; ++j)
                            workHistory[i, j] = 0;

                    var dates = parse_dates(line);
                    update_work_history(dates, ref workHistory);
                    Console.WriteLine(count_months(workHistory)/12);
                }
            }
        }
    }
}