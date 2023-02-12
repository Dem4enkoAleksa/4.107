using System;
using System.Collections.Generic;

namespace задание_4._107
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Год является високосным? (y/n)");
            bool leapYear = Console.ReadLine()!.Equals("y");

            Console.Write("Укажите номер месяца: ");
            var month = (Month)Enum.ToObject(typeof(Month), int.Parse(Console.ReadLine()!));

            Dictionary<Month, int> data = new();
            data.Add(Month.January, 31);
            data.Add(Month.February, 28);
            data.Add(Month.March, 31);
            data.Add(Month.April, 30);
            data.Add(Month.May, 31);
            data.Add(Month.June, 30);
            data.Add(Month.July, 31);
            data.Add(Month.August, 31);
            data.Add(Month.September, 30);
            data.Add(Month.October, 31);
            data.Add(Month.November, 30);
            data.Add(Month.December, 31);

            data.TryGetValue(month, out var daysResult);

            if (leapYear && month.Equals(Month.February))
            {
                Console.WriteLine($"Високосный год: {leapYear}. Месяц: {month}. Дней: {daysResult + 1}");
            }
            else
            {
                Console.WriteLine($"Високосный год: {leapYear}. Месяц: {month}. Дней: {daysResult}");
            }
        }
    }

    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
}