using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira nota: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            int n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a terceira nota: ");
            int n3 = int.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            Console.WriteLine("Média {0}  ",media);


            Console.ReadKey();
        }
    }
}
