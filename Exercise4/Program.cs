using System;
using System.Text;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số thứ 1: ");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine($"Số bạn đã nhập là{a}");
            for (int i = 0; i < 10 ; i++) 
            {
                Console.WriteLine($"{a}*{i}={a*i}");
            }
        }
    }
}