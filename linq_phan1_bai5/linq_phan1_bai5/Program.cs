//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02

using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan1_bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squares = numbers.Select(x => x * x).ToList();
            Console.WriteLine("Binh phuong cua moi so trong danh sach:");
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }
        }
    }
}