//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//Tìm giá trị nhỏ nhất trong list nhập từ bàn phím
using System;
using System.Collections.Generic;

namespace Phan2_Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Ho Minh Quan_23115053122134_225LTC#02");
            Console.WriteLine("------------------------------------------");

            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap cac so nguyen (nhap 'done' de ket thuc):");

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
                    Console.WriteLine("Vui long nhap mot so nguyen hop le hoac 'done' de ket thuc.");
                }
            }
            if (numbers.Count > 0)
            {
                int minValue = FindMinValue(numbers);
                Console.WriteLine("Gia tri nho nhat trong danh sach la: {0}", minValue);
            }
            else
            {
                Console.WriteLine("Danh sach trong. Khong co gia tri nao de tim.");
            }

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
        static int FindMinValue(List<int> numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}