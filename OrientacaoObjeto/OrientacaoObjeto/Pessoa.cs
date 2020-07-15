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
        private string _nome;
        private string _endereco;

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

        protected string Estado { get; set; }



        public void Criar(Pessoa pessoa) { }
        public void Atualizar(Pessoa pessoa) { }
        public void Pesquisar(Pessoa pessoa) { }
        public void Deletar(Pessoa pessoa) { }
    }
}
