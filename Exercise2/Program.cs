using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tim so lon nhat trong 3 so");
            Console.WriteLine("Nhap so thu nhat");
            int so1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai");
            int so2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu ba");
            int so3 = Int32.Parse(Console.ReadLine());
            if (so1 > so2 && so1 > so3)
            {
                Console.WriteLine($"So lon nhat la {so1}");
            }
            else if (so2 >so1 && so2 > so3)
            {
                Console.WriteLine($"So lon nhat la {so2}");
            }
            else
            {
                Console.WriteLine($"So lon nhat la {so3}");
            }
        }
    }
}