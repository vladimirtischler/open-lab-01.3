using System;

namespace open_lab_01._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int c = ++b;
            Console.WriteLine(c);
        }
    }
}
