using System;

namespace CauTrucLap
{
    class Program
{
    static void Main(string[] args)
        {

         // Bước 1: Khai báo các biến
            double TienGui = 1.0;
            int ThangGui = 1;
            double LaiSuat = 1.0;

            // Bước 2: Nhận dữ liệu đầu vào từ người dùng
            Console.WriteLine("Nhap So Tien Gui: ");
            TienGui = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap So Thang Gui: ");
            ThangGui = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so Lai Suat: ");
            LaiSuat = Double.Parse(Console.ReadLine());

            // Bước 3: Tính toán tổng số tiền lãi
            double TongLai = 0;
            for (int i = 0; i < ThangGui; i++)
            {
                TongLai += TienGui * (LaiSuat / 100) / 12;
            }

            // Bước 4: Hiển thị kết quả
            Console.WriteLine("Tong lai nhan duoc: " + TongLai);

            // Bước 5: Kết thúc chương trình
            Console.WriteLine("Hoan thanh.");
            Console.ReadKey();
    }
}}
