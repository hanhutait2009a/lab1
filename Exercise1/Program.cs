using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten :");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhap Dia Chi :");
            string diachi = Console.ReadLine();
            Console.WriteLine("Nhap dienthoai :");
            string dienthoai = Console.ReadLine();
            Console.WriteLine($"Ten: {ten} , DiaChi: {diachi} , DienThoai: {dienthoai}");
        }
    }
}