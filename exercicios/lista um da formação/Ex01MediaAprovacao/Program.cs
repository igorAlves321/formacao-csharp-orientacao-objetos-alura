using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace Ex01MediaAprovacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
            Console.WriteLine("Bém vindo ao programa, Digite a nota.");
            int nota = int.Parse(Console.ReadLine());
            if (nota >= 5)
            {
                Console.WriteLine("aprovado.");
            }
            else
            {
                Console.WriteLine("reprovado.");
            }
            Console.ReadKey();
        }
    }
}
