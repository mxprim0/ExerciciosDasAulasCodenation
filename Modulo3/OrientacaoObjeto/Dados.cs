using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace OrientacaoObjeto
{
    public class Dados
    {
        public IEnumerable<Veiculo> RetornaIEnumerableFromCollection()
        {
            // IEnumerable pode receber dados de uma Collection
            IEnumerable<Veiculo> veiculos = CargaExemploCollection().OrderBy(x => x.Nome);
            return veiculos;
        }

        public IEnumerable<Veiculo> RetornaIEnumerable()
        {
            IEnumerable<Veiculo> veiculos = CargaExemploIEnumerable().OrderBy(x => x.Nome);
            return veiculos;
        }

        public ICollection<Veiculo> RetornaICollection()
        {
            // return CargaExemplo().OrderBy(x => x.Nome);
            return CargaExemploCollection();
        }

        public IList<Veiculo> RetornaList()
        {
            //List<Veiculo> veiculos = CargaExemploList().OrderBy(x => x.Marca)
            List<Veiculo> veiculos = CargaExemploList().OrderBy(x => x.Marca).ToList();

            return veiculos;
        }
      
        
        /*public IDictionary<int, string> RetornaDictionary()
        {
            return CargaExemploDictionary();
        }
        */
        
        public List<KeyValuePair<int, string>> RetornaDictionaryTypeList()
        {
            var dados = CargaExemploDictionary().OrderBy(x => x.Value).ToList();
            return dados;
        }


        private ICollection<Veiculo> CargaExemploCollection()
        {
            ICollection<Veiculo> veiculos = new Collection<Veiculo>();

            veiculos.Add(new Veiculo { Id = 1, Nome = "KA Sedan", Marca = "Ford", AnoFabricacao = 2018 });
            veiculos.Add(new Veiculo { Id = 2, Nome = "Ecosport", Marca = "Ford", AnoFabricacao = 2017 });
            veiculos.Add(new Veiculo { Id = 3, Nome = "Ranger", Marca = "Ford", AnoFabricacao = 2016 });
            veiculos.Add(new Veiculo { Id = 4, Nome = "Mustang", Marca = "Ford", AnoFabricacao = 2015 });

            return veiculos;
        }
        private IEnumerable<Veiculo> CargaExemploIEnumerable()
        {
            IList<Veiculo> pessoas = new List<Veiculo>();

            pessoas.Add(new Veiculo { Id = 1, Nome = "KA Sedan", Marca = "Ford", AnoFabricacao = 2018 });
            pessoas.Add(new Veiculo { Id = 2, Nome = "Ecosport", Marca = "Ford", AnoFabricacao = 2017 });
            pessoas.Add(new Veiculo { Id = 3, Nome = "Ranger", Marca = "Ford", AnoFabricacao = 2016 });
            pessoas.Add(new Veiculo { Id = 4, Nome = "Mustang", Marca = "Ford", AnoFabricacao = 2015 });

            return pessoas;
        }
        private IList<Veiculo> CargaExemploList()
        {
            IList<Veiculo> pessoas = new List<Veiculo>();
            
            pessoas.Add(new Veiculo { Id = 1, Nome = "KA Sedan", Marca = "Ford", AnoFabricacao = 2018 });
            pessoas.Add(new Veiculo { Id = 2, Nome = "Ecosport", Marca = "Ford", AnoFabricacao = 2017 });
            pessoas.Add(new Veiculo { Id = 3, Nome = "Ranger", Marca = "Ford", AnoFabricacao = 2016 });
            pessoas.Add(new Veiculo { Id = 4, Nome = "Mustang", Marca = "Ford", AnoFabricacao = 2015 });
            
            return pessoas;
        }
        private IDictionary<int, string> CargaExemploDictionary()
        {
            IDictionary<int, string> valores = new Dictionary<int, string>();
            valores.Add(1, "Maria");
            valores.Add(2, "João");
            valores.Add(3, "Carlos");
            return valores;
        }
        
        private IDictionary<int, Veiculo> CargaExemploDictionaryClasseVeiculo()
        {
            IDictionary<int, Veiculo> valores = new Dictionary<int, Veiculo>()
            {
                { 1, new Veiculo { Id = 1, Nome = "KA Sedan", Marca = "Ford", AnoFabricacao = 2018 } },
                { 2, new Veiculo { Id = 2, Nome = "Ecosport", Marca = "Ford", AnoFabricacao = 2017 } },
                { 3, new Veiculo { Id = 3, Nome = "Ranger", Marca = "Ford", AnoFabricacao = 2016 } },
                { 4, new Veiculo { Id = 4, Nome = "Mustang", Marca = "Ford", AnoFabricacao = 2015 } }
            };
            return valores;
        }

        public IDictionary<int,string> RetornaDictionary()
        {
            var dados = (Dictionary<int, string>)CargaExemploDictionary().OrderBy(x => x.Value);
            return dados;
        }
    }
}
