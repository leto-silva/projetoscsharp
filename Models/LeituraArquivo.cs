using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Threading.Tasks;

namespace projeto03.Models
{
    public class LeituraArquivo
    {
       public (bool Sucesso, string[] Linhas, int QtdeLinhas) LerArquivo(string caminho)
       {
            try 
             {  
                string[] linhas = File.ReadAllLines(caminho);
                return(true, linhas, linhas.Count());
             }catch(Exception)
             {
                return (false, new string[0], 0);
             }
       }
    }
}