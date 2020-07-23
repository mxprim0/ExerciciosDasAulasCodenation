using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        public void Create(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Read(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public string RetornaApelido(PessoaFisica pessoa)
        {
            return pessoa.Apelido;
        }

        public void Update(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
