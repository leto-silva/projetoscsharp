using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto03.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        public int Id {get; set;}
        public string Produto {get; set;}
        public decimal Preco {get;set;}

    }
}