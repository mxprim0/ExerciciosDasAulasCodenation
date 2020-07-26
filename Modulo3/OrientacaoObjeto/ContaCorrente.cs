using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    public class ContaCorrente: Conta
    {
        private double _saldo; //campo

        public double Saldo //propriedade
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        //metodo
        public override void Sacar(double valor)
        {
            _saldo -= (valor + 0.10);
            Console.WriteLine($"Conta Corrente - saldo: {_saldo}");
        }
    }
}
