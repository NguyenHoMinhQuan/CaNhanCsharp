//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//Tạo list và đảo ngược list
    ﻿using System;
using System.Collections.Generic;
namespace Phan2_Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original list:");
            PrintList(numbers);
            numbers.Reverse();
            Console.WriteLine("Reversed list:");
            PrintList(numbers);
        }
        static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}