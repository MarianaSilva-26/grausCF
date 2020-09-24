using System;

namespace grausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit = 32;

            Console.Write("digite sua temperatura em celsius:");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("celsius para fahrenheit = {0}" , fahrenheit);
            Console.Write(" /n ");

            Console.WriteLine("pressione Enter para sair!");
            Console.ReadKey();
        }
    }
}
