using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string convLeet;
            
            Console.WriteLine("Digite seu nome para iniciar.");
            Console.WriteLine("_____________________________");
            Console.Write("Nome: ");
            Console.ForegroundColor=ConsoleColor.Magenta;
            nome = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine(""+nome+", digite uma frase: ");
            
            Console.ForegroundColor=ConsoleColor.Magenta;
            convLeet=Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine(convLeet.Replace("o","0").Replace("O","0").Replace("e","3").Replace("E","3").Replace("I","1").Replace("i","1").Replace("L","1").Replace("l","1").Replace("a","4").Replace("A","4").Replace("T","7").Replace("t","7").Replace("S","5").Replace("s","5"));
            Console.Beep();

        }
    }
}
