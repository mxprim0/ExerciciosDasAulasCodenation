using System;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta(); 
            //nao é possivel criar uma instancia da classe abstract ou interface "Conta"

            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaCorrente.Saldo = 500.34;
            contaCorrente.Sacar(40.5);

            contaPoupanca.Saldo = 345.23;
            contaPoupanca.Sacar(10.34);

            Console.ReadKey();

            /*
            ClasseBase classeBase = new ClasseBase();
            ClasseDerivada classeDerivada = new ClasseDerivada();

            classeBase.ExibirInformacao();
            classeDerivada.ExibirInformacao();
            */
        }
    }
}
