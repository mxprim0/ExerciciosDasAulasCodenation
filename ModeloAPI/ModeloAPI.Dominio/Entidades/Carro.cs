using System;

namespace ModeloAPI.Dominio.Entidades
{
    public class Carro
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public int Ano { get; set; }
        public string Quilometragem { get; set; }
        public string Observacao { get; set; }
    }
}
