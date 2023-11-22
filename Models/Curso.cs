using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto03.Models
{
    public class Curso
    {
        public String Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
       
        public bool RemoverAluno(Pessoa Aluno)
        {
            return Alunos.Remove(Aluno);
        }
        
        public void AdicionarAluno(Pessoa Aluno)
        {
            Alunos.Add(Aluno);
        }         

        public int ObterQuantidadeAlunosMatriculados()
        {
            int Quantidade = Alunos.Count();
            return Quantidade;
        }
        
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for(int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"Nº {count + 1} {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }

        }

    }
}