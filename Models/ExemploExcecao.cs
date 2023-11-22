using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto03.Models
{
    public class ExemploExcecao
    {
        public void metodo1()
        {
            metodo2();
        }

        public void metodo2()
        {

            try 
            {
               metodo3();
            } 
            catch(Exception)
            {
               Console.WriteLine("Erro tratado!");     
            }

        }

        public void metodo3()
        {
            metodo4();
        }

        public void metodo4()
        {
            throw new Exception("Ocorreu uma exceção!");
        }
    }
}