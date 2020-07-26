using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
	public class PessoaJuridica : Pessoa
	{
		private string _cnpj { get; set; }
		private string _ie { get; set; }

		public string CNPJ
		{
			get { return _cnpj; }
			set { _cnpj = value; }
		}

		public string InscricaoEstadual
		{
			get { return _ie; }
			set { _ie = value; }
		}

		public PessoaJuridica(string nome, string endereco):base(nome, endereco) { }

        public override void ExibirNome()
        {
			Console.WriteLine($"Pessoa Juridica - Exibir Nome : { Nome}");
		}

        /*
		public string CNPJ
        {
			set { _cnpj = value; }
			get { return _cnpj; }
        }
		public string InscricaoEstadual
		{
			set { _ie = value; }
			get { return _ie; }
		}
		*/

    }
}
