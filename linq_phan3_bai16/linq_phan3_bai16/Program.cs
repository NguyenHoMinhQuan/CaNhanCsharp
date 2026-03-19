//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//dùng linq tính tổng, sum()
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan3_bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = numbers.Sum();
            Console.WriteLine("Tong cua cac so la: " + sum);
        }
    }
}

