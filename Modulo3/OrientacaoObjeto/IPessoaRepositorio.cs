using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    interface IPessoaRepositorio
    {
        //CRUD
        // A Interface tem as assinaturas do método
        void Create(Pessoa pessoa);
        void Read(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(Pessoa pessoa);
        string RetornaApelido(PessoaFisica pessoa);
    }
}
