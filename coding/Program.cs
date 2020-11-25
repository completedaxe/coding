using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, обозначающее код символа по таблице ASCII");
            int number = Convert.ToInt32(Console.ReadLine());
            Numbers numbers = new Numbers();
            numbers.Number = number;
            string Result = numbers.Decode();
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
