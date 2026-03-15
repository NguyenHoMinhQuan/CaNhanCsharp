//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
// Nhập list , tìm số xuất hiện nhiều nhất
using System;
using System.Collections.Generic;
using System.Linq;
namespace Phan3_Bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua list:");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap cac phan tu cua list:");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            var mostFrequent = numbers.GroupBy(x => x)
                                      .OrderByDescending(g => g.Count())
                                      .First()
                                      .Key;
            Console.WriteLine($"So xuat hien nhieu nhat la: {mostFrequent}");
        }
    }
}