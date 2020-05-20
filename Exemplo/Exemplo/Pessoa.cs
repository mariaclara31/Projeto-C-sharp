namespace Exemplo
{
    abstract class Pessoa
    { //classe abstrata que servirá de base para outra classe
        //Dados da pessoa
        public string Nome { get; protected set; }
        public string Endereco { get; protected set; }

        //Construtor
        public Pessoa(string parametroNome, string parametroEndereco)
        {
            Nome = parametroNome;
            Endereco = parametroEndereco;
        }

        //SETTERS
        public void SetNome(string parametroNome)
        {
            this.Nome = parametroNome;
        }

        public void SetEndereco(string parametroEndereco)
        {
            this.Endereco = parametroEndereco;
        }
    }
}
