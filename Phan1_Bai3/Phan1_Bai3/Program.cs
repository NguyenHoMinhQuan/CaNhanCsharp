//Nguyễn Hồ Minh Quân - 23115053122134
//Nhập danh sách số nguyên List .Tìm số lớn nhất . 
using System;
using System.Collections.Generic;

namespace Phan1_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap so nguyen (nhap 'done' de ket thuc):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so nguyen hop le.");
                }
            }

            if (numbers.Count > 0)
            {
                int maxNumber = FindMax(numbers);
                Console.WriteLine("So lon nhat trong danh sach la: {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("Danh sach trong.");
            }

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }

        static int FindMax(List<int> numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}