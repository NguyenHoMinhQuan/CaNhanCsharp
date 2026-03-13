//Nguyên Hồ Minh Quân - 23115053122134
// Tạo List và đếm số chẵn trong List đó
using System;
using System.Collections.Generic;
namespace Phan1_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenCount = CountEvenNumbers(numbers);
            Console.WriteLine($"So luong so chan trong List: {evenCount}");
        }
        static int CountEvenNumbers(List<int> numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}