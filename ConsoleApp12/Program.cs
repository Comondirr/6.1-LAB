using System;
namespace Csh_console_tasks
{
    class thread2141726
    {
        static void Main(string[] args)
        {
            UInt32 count;
            Console.Write("Введите число: ");
            count = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Число комбинаций: ");
            Console.WriteLine(Math.Pow(2, count));
        }
    }
}
