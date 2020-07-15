using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
	public class PessoaJuridica : Pessoa
	{
		private string _cnpj;
		private string _ie;

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


	}
}
