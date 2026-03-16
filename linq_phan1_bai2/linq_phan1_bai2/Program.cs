//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//linq lọc số lớn hơn 5
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan1_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
            var filteredNumbers = numbers.Where(n => n > 5);
            Console.WriteLine("So lon hon 5:");
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}