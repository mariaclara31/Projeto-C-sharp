using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma var e instanciando uma lista da classe PessoaFisica
            var Pessoas = new List<PessoaFisica>();

            //Criando pessoas
            PessoaFisica pessoa1 = new PessoaFisica("Joao", "BH", "99999999999");
            PessoaFisica pessoa2 = new PessoaFisica("Jose", "SP", "00000000000");

            //Adicionando as pessoas a lista
            Pessoas.Add(pessoa1);
            Pessoas.Add(pessoa2);

            //Printando os dados de cada pessoa na lista

            Console.WriteLine(Pessoas[0].Nome + "\n" + Pessoas[0].Endereco + "\n" + Pessoas[0].CPF + "\n\n");
            Console.WriteLine(Pessoas[1].Nome + "\n" + Pessoas[1].Endereco + "\n" + Pessoas[1].CPF + "\n\n");

            Console.ReadKey();//Faz o programa esperar. Caso contrário, executa e encerra
        }
    }
}
