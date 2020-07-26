using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public sealed class ClasseDerivada : ClasseBase
    //classe selada não permite herança - bloqueia o conceito de herença - tipo a kiuubi do naturo rs
    {
        //Método Construtor
        public ClasseDerivada() { }
        public override void ExibirInformacao()
        {
            string mensagem = "Mensagem da Classe Derivada";
            Console.WriteLine(mensagem);
        }
    }
}
