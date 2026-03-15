//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;

namespace Phan2_Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nNhap mot chuoi bat ky (hoac nhap '0' de dung):");
                string input = Console.ReadLine();

                if (input == "0") break;

                Dictionary<char, int> countDict = new Dictionary<char, int>();

                foreach (char c in input)
                {
                    if (countDict.ContainsKey(c))
                    {
                        countDict[c]++;
                    }
                    else
                    {
                        countDict[c] = 1;
                    }
                }

                Console.WriteLine("Ket qua dem ky tu:");
                foreach (KeyValuePair<char, int> entry in countDict)
                {
                    Console.WriteLine("{0} : {1}", entry.Key, entry.Value);
                }

                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("Chuong trinh ket thuc.");
            Console.ReadKey();
        }
    }
}