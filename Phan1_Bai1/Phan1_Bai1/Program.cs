//Tạo danh sách số nguyên, thêm 5 số bất kì và in ra danh sách đó.
    ﻿using System;
    using System.Collections.Generic;
namespace Phan1_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten - MSSV: Minh Quân_23115053122134");
            Console.WriteLine("------------------------------------------");
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            Console.WriteLine("Danh sach so nguyen:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}