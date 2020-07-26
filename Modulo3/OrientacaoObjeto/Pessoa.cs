using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public class Pessoa //classe base
    {
        //se eu estou falando de "campo" é sempre privado
        //aqui os campos estão sendo encapsulados
        // o modificador de acesso que estão neles é do tipo private

        /*campos privados
        private string _nome { get; set; }
        private string _endereco { get; set; }
        */

        private string _nome;
        protected string apelido;

        //propriedades publicas
        public string Nome 
        { 
            get { return _nome; } 
        }
        public string Endereco { get; protected set; }

        //metodo construtor da Classe Pessoa
        public Pessoa(string nome, string endereco) // nome e endereco
        {
            _nome = nome; // campos privados da Classe
            Endereco = endereco;
        }

        // public void Inserir(Pessoa pessoa) { }
        public virtual void ExibirNome() 
        //permite que a classe que herda da classe pessoa possa sobrescrever este metodo utilizando a palavra reservada "override" 
        {
            Console.WriteLine($"Pessoa - Exibir Nome: {_nome}");
        }




        /*
        //este campo tambem esta encapsulado mas usando o tipo publico
        protected string Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }
        internal string Endereco
        {
            set { _endereco = value; }
            get { return _endereco; }
        }

        public string Apelido { get; protected set; }


        public void Criar(Pessoa pessoa) { }
        public void Atualizar(Pessoa pessoa) { }
        public void Pesquisar(Pessoa pessoa) { }
        public void Deletar(Pessoa pessoa) { }
        */
    }
}
