using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "   fly me   to   the moon  ";
            string[] b = a.Split(" ");
            foreach(var item in b)
            {
                Console.WriteLine(item);
            }
        }
    }
}
