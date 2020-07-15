using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public class PessoaFisica : Pessoa
    {
        private string _rg;
        private string _cpf;
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
    }
}
