using System;

namespace _230405_100
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);

            Console.WriteLine((a+b)%c);
            Console.WriteLine((a%c)+(b%c)%c);
            Console.WriteLine((a*b)%c);
            Console.WriteLine((a%c)*(b%c)%c);
        }
    }
}
