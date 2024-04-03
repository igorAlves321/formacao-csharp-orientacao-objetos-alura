using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02ListasDeLinguagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
            List<string> listaDeLinguagens = new List<string> { "C#", "JS", "Java" };
            //Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
            Console.WriteLine(listaDeLinguagens[0]);
        }
    }
}
