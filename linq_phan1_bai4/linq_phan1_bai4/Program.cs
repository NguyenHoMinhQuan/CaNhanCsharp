//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//  sắp xếp giảm dần
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan1_bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 9, 1, 5, 6 };
            var sortedNumbers = from num in numbers
                                orderby num descending
                                select num;
            Console.WriteLine("Sap xep giam dan:");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}