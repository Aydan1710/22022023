using System;
using System.Collections.Generic;

namespace _22022023
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fromDate = new DateTime(2023, 10, 17, 6, 30, 0);
            DateTime toDate = new DateTime(2023, 11, 10, 14, 0, 0);


            var diff = toDate - fromDate;

            Console.WriteLine(diff);
            Console.WriteLine(diff.Days);
            Console.WriteLine(diff.Hours);
            Console.WriteLine(diff.Minutes);

            
            Console.WriteLine(diff.TotalDays);
            Console.WriteLine(diff.TotalHours);
            Console.WriteLine(diff.TotalMinutes);



            Student std = new Student();

            std.Exams.Add(new Exam { Point = 35, Subject = "Programming 1", StartAt = new DateTime(2020, 10, 17, 10, 0, 0), FinishAt = new DateTime(2020, 10, 17, 11, 15, 0) });
            std.Exams.Add(new Exam { Point = 44, Subject = "Programming 2", StartAt = new DateTime(2020, 10, 21, 8, 0, 0), FinishAt = new DateTime(2020, 10, 21, 14, 0, 0) });
            std.Exams.Add(new Exam { Point = 13, Subject = "Programming 3", StartAt = new DateTime(2020, 11, 2, 14, 30, 0), FinishAt = new DateTime(2020, 11, 2, 15, 0, 0) });



            Console.WriteLine(std.GetTotalExamMinutes());

            List<int> numbers = new List<int>();


            numbers.Add(223);

            Console.WriteLine(numbers.Capacity);

            numbers.Add(17);
            numbers.Add(10);
            numbers.Add(2000);
            numbers.Add(2019);

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Capacity);







        }
    }
}

