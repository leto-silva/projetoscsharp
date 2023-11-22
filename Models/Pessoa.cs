using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto03.Models
{
    public class Pessoa
    {
        
       public Pessoa()
       { 

       } 
       public Pessoa(string nome, string sobrenome)
       {
          Nome = nome;
          Sobrenome = sobrenome;
       }

       public void Deconstruct(out string nome, out string sobrenome)
       {
            nome = Nome;
            sobrenome = Sobrenome;
       }

        private string _nome;
        public string Nome 
        { 

            get =>_nome.ToUpper();
            
            set
            {
                if (value ==""){
                    throw new ArgumentException("O nome não pode ser vazio!");
                }

                _nome = value;
            } 
            
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        private int _Idade; 
        public int Idade 
        { 
                      
            get => _Idade;            
            
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Idade não pode ser menor que 1");
                }

                _Idade = value;
            }
            
            
        }
    
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}; Idade:{Idade}");
        }
    }
}