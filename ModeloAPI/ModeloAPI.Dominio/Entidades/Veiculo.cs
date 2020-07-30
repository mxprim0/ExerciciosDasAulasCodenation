using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloAPI.Dominio.Entidades
{
    public class Veiculo
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public string Imagem { get; set; }
        public string KM { get; set; }
        public string Preco { get; set; }
        public string AnoModelo { get; set; }
        public string AnoFabricacao { get; set; }
        public string Cor { get; set; }
    }
}
