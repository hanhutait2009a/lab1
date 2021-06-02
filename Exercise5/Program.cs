using System;
using System.Text;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int b = 1;
            for (int i = 1; i <= 20; i++)
            {
                b = b * i;
                Console.WriteLine(b);
            }
        }
    }
}