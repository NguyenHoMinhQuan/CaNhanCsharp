
//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan1_bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 5, 8, 12, 15 };
            bool hasGreaterThan10 = numbers.Any(n => n > 10);
            if (hasGreaterThan10)
            {
                Console.WriteLine("Có so lon hon 10 trong danh sach.");
            }
            else
            {
                Console.WriteLine("Khong có so nao.");
            }
        }
    }
}