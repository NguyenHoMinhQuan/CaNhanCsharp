//Nhập các số nguyên vào List<int> Và tính tổng của chúng.
    ﻿using System;
    using System.Collections.Generic;
namespace Phan1_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap cac so nguyen (nhap 'done' de ket thuc):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    break;
                }
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Vui long nhap 1 so nguyen hop le hoac 'done' de ket thuc.");
                }
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Tong cua cac so da nhap la: {sum}");
        }
    }
}