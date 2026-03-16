//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
// linq đếm số chẵn
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan1_bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenCount = numbers.Count(n => n % 2 == 0);
            Console.WriteLine($"So luong so chăn trong mang: {evenCount}");
        }
    }
}