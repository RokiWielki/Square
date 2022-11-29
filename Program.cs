//Napisz program, który wyświetla na ekranie konsoli „kwadrat” zbudowany ze znaku
//„*”. Liczbę wierszy (a tym samym kolumn) ma podać użytkownik.

using System;

namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give side length: ");
            int a=int.Parse(Console.ReadLine());
            Square(a);
        }
        static void Square(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
