////Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;

namespace Phan2_Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> numbers = new List<int>();
                Console.WriteLine("\nNhap danh sach so nguyen (nhap 'done' de dung):");

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "done") break;

                    if (int.TryParse(input, out int num))
                    {
                        numbers.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("Vui long nhap so nguyen hop le!");
                    }
                }

                if (numbers.Count > 0)
                {
                    List<int> uniqueNumbers = new List<int>();

                    foreach (int n in numbers)
                    {
                        if (!uniqueNumbers.Contains(n))
                        {
                            uniqueNumbers.Add(n);
                        }
                    }

                    Console.WriteLine("Danh sach sau khi loai bo trung lap:");
                    foreach (int n in uniqueNumbers)
                    {
                        Console.Write(n + " ");
                    }
                    Console.WriteLine("\n------------------------------------------");
                }

                Console.WriteLine("Tiep tuc? (c/k):");
                if (Console.ReadLine().ToLower() == "k") break;
            }
        }
    }
}