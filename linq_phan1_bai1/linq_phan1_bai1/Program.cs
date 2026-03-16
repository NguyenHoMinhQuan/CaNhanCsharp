//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//Dùng linq để lấy các số chẵn trong list number
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan1_bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Cac so chan trong list:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}