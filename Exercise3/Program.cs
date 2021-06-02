using System;
using System.Text;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ReadLine();
            Console.WriteLine("Nhập vào số thứ 1: ");
            int a = int.Parse(Console.ReadLine());
            int max = a;
            String dayName;
            switch (a)
            {
                case 1:
                    dayName = "Thứ 2";
                    Console.WriteLine("Hôm nay là thứ {0}", dayName);
                    break;
                case 2:
                    dayName = "Thứ bar";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 3:
                    dayName = "Thứ tư";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 4:
                    dayName = "Thứ lăm";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 5:
                    dayName = "Thứ sáu";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 6:
                    dayName = "Thứ 7";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 7:
                    dayName = "Chủ nhật ";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                default: dayName = "Sai cú pháp vui lòng nhập từ 1-7";
                    Console.WriteLine(dayName);
                    break;
            }
        }
    }
}