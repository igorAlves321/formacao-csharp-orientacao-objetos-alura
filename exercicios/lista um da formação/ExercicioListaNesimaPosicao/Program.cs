using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaNesimaPosicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n - ésima posição de uma lista.
            List<int> listaNumeros = new List<int> { 10, 20, 30, 40, 50 };
            Console.Write("Digite um número inteiro (entre 1 e " + listaNumeros.Count + "): ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= listaNumeros.Count)
            {
                Console.WriteLine("O valor da " + n + "ª posição é: " + listaNumeros[n - 1]);
            }
            else
            {
                Console.WriteLine("Número inválido. Certifique-se de escolher um valor entre 1 e " + listaNumeros.Count + ".");
            }
        }
    }
}
