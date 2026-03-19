
//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//loại bỏ số trùng
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_phan2_bai15
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Danh sach ban dau: " + string.Join(" ", numbers));

            var distinctNumbers = numbers.Distinct();

            Console.WriteLine("Danh sach sau khi loai bo trung: " + string.Join(" ", distinctNumbers));

            Console.WriteLine("------------------------------------------");
            Console.ReadKey();
        }
    }
}