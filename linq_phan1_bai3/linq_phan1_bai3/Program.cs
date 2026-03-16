//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
// linq sắp xếp tăng dần
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan1_bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 9, 1, 5, 6 };
            var sortedNumbers = from num in numbers
                                orderby num ascending
                                select num;
            Console.WriteLine("Sap xep tang dan:");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}