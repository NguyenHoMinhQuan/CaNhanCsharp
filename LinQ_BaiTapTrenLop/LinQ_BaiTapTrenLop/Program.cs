//Nguyễn Hồ Minh Quân_2311505312134_225LTC#02
using System;
using System.Collections.Generic;
using System.Linq;
namespace LinQ_BaiTapTrenLop
{
    class SinhVien
    {
        public int MaSo { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string Khoa { get; set; }
        public double DiemTrungBinh { get; set; }
        public int NamHoc { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> danhSachSinhVien = InitRandomStudents(50);

            // 1. Tinh Tuoi lon nhat, Tuoi nho nhat
            int tuoiMax = danhSachSinhVien.Max(sv => sv.Tuoi);
            int tuoiMin = danhSachSinhVien.Min(sv => sv.Tuoi);
            Console.WriteLine("1. Tuoi lon nhat: {0}, Tuoi nho nhat: {1}", tuoiMax, tuoiMin);

            // 2. Kiem tra co sinh vien thuoc khoa Cong nghe so
            bool coKhoaCNS = danhSachSinhVien.Any(sv => sv.Khoa == "Cong nghe so");
            Console.WriteLine("2. Co sinh vien khoa Cong nghe so khong? {0}", coKhoaCNS ? "Co" : "Khong");

            // 3. Lay 10 sinh vien co diem trung binh cao nhat khoa Cong nghe so
            var top10CNS = danhSachSinhVien.Where(sv => sv.Khoa == "Cong nghe so")
                                           .OrderByDescending(sv => sv.DiemTrungBinh)
                                           .Take(10);

            Console.WriteLine("\n3. Top 10 diem trung binh cao nhat khoa Cong nghe so:");
            foreach (var sv in top10CNS)
                Console.WriteLine("- {0}: {1} diem", sv.HoTen, sv.DiemTrungBinh);

            // 4. Bo qua sinh vien nam cuoi (Nam 4), lay danh sach con lai
            var sinhVienConLai = danhSachSinhVien.Where(sv => sv.NamHoc < 4);

            Console.WriteLine("\n4. Danh sach sinh vien chua ra truong (Hien thi 5 nguoi dau):");
            foreach (var sv in sinhVienConLai.Take(5))
                Console.WriteLine("- {0} (Nam {1})", sv.HoTen, sv.NamHoc);

            Console.ReadKey();
        }
        static List<SinhVien> InitRandomStudents(int soLuong)
        {
            Random ngauNhien = new Random();
            string[] cacKhoa = { "Cong nghe so", "Kinh te", "Ngoai ngu", "Co khi" };
            List<SinhVien> danhSach = new List<SinhVien>();

            for (int i = 1; i <= soLuong; i++)
            {
                danhSach.Add(new SinhVien
                {
                    MaSo = i,
                    HoTen = "Sinh vien " + i,
                    Tuoi = ngauNhien.Next(18, 25),
                    Khoa = cacKhoa[ngauNhien.Next(cacKhoa.Length)],
                    DiemTrungBinh = Math.Round(ngauNhien.NextDouble() * 10, 1),
                    NamHoc = ngauNhien.Next(1, 5)
                });
            }
            return danhSach;
        }
    }
}