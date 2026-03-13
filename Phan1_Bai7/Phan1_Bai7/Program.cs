//// Nguyễn Hồ Minh Quân - 134
//Nhập List , sắp xếp tăng dần và in
using System;
using System.Collections.Generic;
namespace Phan1_Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cac phan tu:");
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            numbers.Sort();
            Console.WriteLine("Danh sach sau khi sap xep:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}