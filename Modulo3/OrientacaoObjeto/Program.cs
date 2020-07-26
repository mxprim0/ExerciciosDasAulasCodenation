using System;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseBase classeBase = new ClasseBase();
            ClasseDerivada classeDerivada = new ClasseDerivada();

            classeBase.ExibirInformacao();

            classeDerivada.ExibirInformacao();

            Console.ReadKey();
        }
    }
}
