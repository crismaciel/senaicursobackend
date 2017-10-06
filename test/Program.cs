using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            FazerCafe(" caramelo");
            FazerCafe(" chocolate");
        }
        static void FazerCafe(string capsula)
        {
            Console.WriteLine("Esquentar agua");
            Console.WriteLine("Colocar po de magia (Cafe)");
            Console.WriteLine("Colocar" + capsula);
        }
    }
}
