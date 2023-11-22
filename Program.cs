using System.Globalization;
using System.Reflection;
using projeto03.Models;
using Newtonsoft.Json;

bool? desejaReceberEmail = true;

if(desejaReceberEmail!=null && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail");
}
else
{
    Console.WriteLine("O usuario não optou ou não quer receber email");
}


























/*
int numero = 05;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine ($"O número:{numero} é " + (ehPar ? "Par" : "Impar"));
*/











/*
int numero = 15;

if (numero % 2 == 0)
{
    Console.WriteLine("Número é par");
}
else{
    Console.WriteLine("Número é impar");
}
*/





/*
Pessoa p1 = new Pessoa("Well", "Silva");

(string n, string s) = p1;

Console.WriteLine($"Nome={n} e Sobrenome={s}");
*/














/*
LeituraArquivo arquivo = new LeituraArquivo();

var (Sucesso, linhasArquivo, _ )  = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (Sucesso)
{
    //Console.WriteLine( "Quantidade linhas do arquivo"+ qtdeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
} 
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

*/











/*
(int, string, string, decimal) tupla = (1, "Leonardo", "Buta", 1.80M);
(int Id, string Nome, string Sobrenome, decimal Idade) tupla2 = (1, "Leonardo2", "Buta2", 2.10M); 
//ValueTuple<int, string, string, decimal> tupla3 = (1, "Leonardo2", "Buta2", 2.10M); 
//var tupla4 = Tuple.Create(1, "Leo", "xb", 1.20M);


Console.WriteLine($"Id: {tupla4.Item1}");
Console.WriteLine($"Nome: {tupla4.Item2}");
Console.WriteLine($"Sobrenome: {tupla4.Item3}");
Console.WriteLine($"Altura: {tupla4.Item4}");
Console.WriteLine("-------------------------------------------");


*/


/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");
*/
/*
foreach(var item in estados)
{
    Console.WriteLine($"chave:{item.Key}, valor:{item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - Valor Alterado!";

Console.WriteLine("------------------------");

foreach(var item in estados)
{
    Console.WriteLine($"chave:{item.Key}, valor:{item.Value}");
}
*/
/*
string chave = "BA2";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave:{chave}");
}


*/





















/*
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha){
    Console.WriteLine(item);
}

Console.WriteLine($"removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach(int item2 in pilha)
{
    Console.WriteLine(item2);
}

*/
















/*
Queue<int>fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(5);
fila.Enqueue(7);
fila.Enqueue(20);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o 1 elemento da fila:{fila.Dequeue()}");
fila.Enqueue(45);

foreach(int x in fila)
{
    Console.WriteLine(x);
}

*/

































//new ExemploExcecao().metodo1();
























/*
try
{
 string[] linhas = File.ReadAllLines("Arquivos/arquivooLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"diretório não encontrado: {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
}

finally
{
    Console.WriteLine("chegou até aqui");
}

*/























/*
string dataString = "2022-13-17 18:00";

bool Sucesso = DateTime.TryParseExact( dataString,
         "yyyy-MM-dd HH:mm",  CultureInfo.InvariantCulture, 
         DateTimeStyles.None, out DateTime data);

if (Sucesso)
{
    Console.WriteLine($"Conversão com sucesso: {data}");
} 
else
{
    Console.WriteLine($"{data} não é válida!");
}

*/









 






















/*
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("N8"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P4"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));
*/



















/*
using System.Security.Cryptography;
using projeto03.Models;

Pessoa p1 = new Pessoa("Buta", "Oliveira");

Pessoa p2 = new Pessoa();
p2.Nome ="Jose";
p2.Sobrenome = "ira";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome ="Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/