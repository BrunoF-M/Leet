using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string texto;

            Console.Write("Tradutor para"); 
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" \"leet\" ");
            Console.ResetColor();
            Console.Write("digite oque deseja traduzir: ");
            texto = Console.ReadLine();

            string texto2 = texto.Replace("A","4").Replace("a","4").Replace("E","3").Replace("e","3").Replace("I","1").Replace("i","1").Replace("L","1").Replace("l","1").Replace("O","0").Replace("o","0").Replace("T","7").Replace("t","7").Replace("S","5").Replace("s","5");

            Console.Write($"Texto a ser traduzido...: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{texto2}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Aperte qualque tecla para Finalizar... ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
