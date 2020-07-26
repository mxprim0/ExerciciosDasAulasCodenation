using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public class PessoaFisica : Pessoa
    {
        private string _rg { get; set; }
        private string _cpf { get; set; }

        public string RG
        {
            set { _rg = value; }
            get { return _rg; }
        }

        public string CPF
        {
            set { _cpf = value; }
            get { return _cpf; }
        }
        
        public string Apelido
        {
            set { apelido = value; }
            get { return apelido; }
        }

        public PessoaFisica(string nome, string endereco): base(nome, endereco) { }

        public override void ExibirNome()
        {
            Console.WriteLine($"Pessoa Fisica - Exibir Nome:(Nome)");

        }

        /*
        private int _idade;

        public string RG
        {
            set { _rg = value; }
            get { return _rg; }
        }

        public string CPF
        {
            set { _cpf = value; }
            get { return _cpf; }
        }

        public int Idade
        {
            set { _idade = value; }
            get { return _idade; }
        }

        public void InserirDetalhes(Pessoa pessoa)
        {
            string apelido = pessoa.Apelido;
        }
        */
    }
}
