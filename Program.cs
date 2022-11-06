using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 6 || n == 7)
            {
                Console.WriteLine("да");
            }
            else
            {                
                Console.WriteLine("нет");
            }
            Console.ReadKey();
        }
    }
}
