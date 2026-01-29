using System;

namespace BaiTapMang_TongHop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string info = "Sinh viên: Quân + 23115053122134";

            //BÀI 4: TÍNH TỔNG MẢNG SỐ NGUYÊN
            Console.WriteLine(info);
            Console.WriteLine("BÀI 4: TÍNH TỔNG MẢNG");
            Console.Write("Nhập số phần tử n: ");
            int n4 = int.Parse(Console.ReadLine());
            int[] arr4 = new int[n4];

            if (arr4 == null)
            {
                Console.WriteLine("Lỗi: Mảng chưa được khởi tạo.");
            }
            else
            {
                for (int i = 0; i < n4; i++)
                {
                    Console.Write($"Nhap phan tu thu {i}: ");
                    arr4[i] = int.Parse(Console.ReadLine());
                }
                int tong = 0;
                for (int i = 0; i < arr4.Length; i++)
                {
                    tong = tong + arr4[i];
                }
                Console.WriteLine("=> Tổng mảng: " + tong);
            }

            //  BÀI 5: TÌM GIÁ TRỊ LỚN NHẤT 
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine(info);
            Console.WriteLine("BÀI 5: TÌM GIÁ TRỊ LỚN NHẤT (NHẬP TỪ BÀN PHÍM)");
            Console.Write("Nhập số phần tử n: ");
            int n5 = int.Parse(Console.ReadLine());

            if (n5 <= 0)
            {
                Console.WriteLine("Mảng rỗng hoặc null, không xử lý.");
            }
            else
            {
                int[] arr5 = new int[n5];
                for (int i = 0; i < n5; i++)
                {
                    Console.Write($"Nhap phan tu thu {i}: ");
                    arr5[i] = int.Parse(Console.ReadLine());
                }

                int max = arr5[0];
                for (int i = 1; i < arr5.Length; i++)
                {
                    if (arr5[i] > max)
                    {
                        max = arr5[i];
                    }
                }
                Console.WriteLine("=> Giá trị lớn nhất: " + max);
            }

            //  BÀI 6: ĐẾM SỐ PHẦN TỬ CHẴN 
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine(info);
            Console.WriteLine("BÀI 6: ĐẾM SỐ PHẦN TỬ CHẴN");
            Console.Write("Nhập số phần tử n: ");
            int n6 = int.Parse(Console.ReadLine());

            if (n6 < 0)
            {
                Console.WriteLine("=> Số phần tử chẵn: 0 (Mảng null)");
            }
            else
            {
                int[] arr6 = new int[n6];
                int demChan = 0;
                for (int i = 0; i < n6; i++)
                {
                    Console.Write($"Nhap phan tu thu  {i} : ");
                    arr6[i] = int.Parse(Console.ReadLine());
                    if (arr6[i] % 2 == 0)
                    {
                        demChan++;
                    }
                }
                Console.WriteLine("=> Số phần tử chẵn: " + demChan);
            }

            // --- BÀI 7: TÁCH HỌ TÊN THÀNH MẢNG ---
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine(info);
            Console.WriteLine("BÀI 7: TÁCH HỌ TÊN THÀNH MẢNG");
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            if (hoTen != null && hoTen != "")
            {
                string[] mangTu = hoTen.Split(' ');
                if (mangTu != null)
                {
                    Console.WriteLine("Kết quả tách từ:");
                    for (int i = 0; i < mangTu.Length; i++)
                    {
                        if (mangTu[i] != "") Console.WriteLine(mangTu[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Chuỗi null, không tách.");
            }

            // BÀI 8: TÌM TỪ DÀI NHẤT TRONG CHUỖI 
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine(info);
            Console.WriteLine("BÀI 8: TÌM TỪ DÀI NHẤT");
            Console.Write("Nhập một câu: ");
            string cau = Console.ReadLine();
            if (cau != null && cau != "")
            {
                string[] dsTu = cau.Split(' ');
                string tuDaiNhat = "";
                for (int i = 0; i < dsTu.Length; i++)
                {
                    if (dsTu[i].Length > tuDaiNhat.Length)
                    {
                        tuDaiNhat = dsTu[i];
                    }
                }
                Console.WriteLine("=> Từ dài nhất: " + tuDaiNhat);
            }
            else
            {
                Console.WriteLine("Chuỗi null, không xử lý.");
            }

            //  BÀI 9: ĐẾM SỐ CHUỖI KHÁC NULL TRONG MẢNG 
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine(info);
            Console.WriteLine("BÀI 9: ĐẾM SỐ CHUỖI KHÁC NULL VÀ RỖNG");
            string[] mangStrings = { "Quân", null, "", "C#", "Học IT", " ", "Visual Studio" };
            int demHopLe = 0;
            for (int i = 0; i < mangStrings.Length; i++)
            {
                if (mangStrings[i] != null && mangStrings[i] != "")
                {
                    demHopLe++;
                }
            }
            Console.WriteLine("=> Số phần tử khác null và rỗng: " + demHopLe);

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}