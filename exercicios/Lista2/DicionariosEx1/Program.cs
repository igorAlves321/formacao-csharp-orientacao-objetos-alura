using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicionariosEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> aluno = new Dictionary<string, List<double>>();
            {
                aluno["João"] = new List<double> { 8.5, 7.0, 9.2 };
            }
            // Calculando a soma das notas
            double somaDasNotas = aluno["João"].Sum();
            // Encontrando o número total de notas
            int numeroDeNotas = aluno["João"].Count;
            // Calculando a média
            double media = somaDasNotas / numeroDeNotas;
            Console.WriteLine($"A média das notas do João é: {media}");
            Console.ReadKey();
        }
    }
}
