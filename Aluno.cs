using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Models
{
    internal class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;

           
        }

        public double mediaAluno()
        {
            return Math.Round((nota1 + nota2 + nota3) / 3, 1);
        }

        public void alunoAprovadoReprovado()
        {
            if(mediaAluno() >= 6)
            {
                Console.WriteLine("Aluno aprovado");
            }else
            {
                double media = 6 - mediaAluno();
                Console.WriteLine("Aluno reprovado, faltou " + media + " pontos");
            }
        }



    }
}
