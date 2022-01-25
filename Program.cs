using Exercicio3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("digite a nota da primeira unidade: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota da segunda unidade: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota da terceira unidade: ");
            double nota3 = double.Parse(Console.ReadLine());


            if (nota1 < 0 || nota2 < 0 || nota3 < 0)
            {
                Console.WriteLine("Digite notas validas");
                return;
            }

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine(aluno.mediaAluno());
            aluno.alunoAprovadoReprovado();
        }
    }
}
