using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class PessoaFisica : Pessoa
    {
        //DADOS ADICIONAIS
        public string CPF { get; protected set; }

        //CONSTRUTOR

        public PessoaFisica(string parametroNome, string parametroEndereco, string parametroCPF) : base(parametroNome, parametroEndereco)
        {
            CPF = parametroCPF;
        }

        //SETTERS
        public void SetCPF(string parametroCPF)
        {
            this.CPF = parametroCPF;
        }
    }
}
