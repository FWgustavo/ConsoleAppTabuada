using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Tabuada que deseja saber: ");
            int tabuada = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de vezes: ");
            int vezes = int.Parse(Console.ReadLine());
            int cont = 1;

            while (cont <= vezes) 
            {
                int res = tabuada * cont;
                Console.WriteLine(tabuada+ "x" +cont+ "=" +res);
                cont++;
            }
            Console.ReadKey();
        }

    }
}
