using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloAPI.Dominio.Entidades
{
    class Versao
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int ModeloId { get; set; }
    }
}
