//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_phan2_bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 2, 3, 4, 3, 2, 5, 2, 2 };

            Console.WriteLine("Danh sach: " + string.Join(" ", numbers));

            var mostFrequent = numbers.GroupBy(n => n)
                                      .OrderByDescending(g => g.Count())
                                      .FirstOrDefault();

            if (mostFrequent != null)
            {
                Console.WriteLine("\nGia tri xuat hien nhieu nhat la: {0}", mostFrequent.Key);
                Console.WriteLine("So lan xuat hien: {0}", mostFrequent.Count());
            }

            Console.ReadKey();
        }
    }
}