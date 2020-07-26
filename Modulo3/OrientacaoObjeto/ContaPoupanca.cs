using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public class ContaPoupanca: Conta
    {
        private double _saldo; //campo

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        //método
        public override void Sacar(double valor)
        {
            _saldo -= valor;
            Console.WriteLine($"Conta Poupança - saldo: {_saldo}");
        }
    }
}
