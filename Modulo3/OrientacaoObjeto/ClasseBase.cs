using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public class ClasseBase
    {
        //Método Construtor
        public ClasseBase() { }
        public virtual void ExibirInformacao()
        {
            string mensagem = "Mensagem da CLasse Base";
            Console.WriteLine(mensagem);
        }
    }
}
