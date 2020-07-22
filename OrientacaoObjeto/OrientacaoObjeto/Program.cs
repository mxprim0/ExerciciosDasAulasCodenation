using System;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Dan";
            string endereco = "Rua dos bobos Nº 0";

            Pessoa pessoa = new Pessoa(nome, endereco);

            PessoaFisica pessoaFisica = new PessoaFisica(nome, endereco);
            pessoaFisica.ExibirNome();

            PessoaJuridica pessoaJuridica = new PessoaJuridica("Empresa XPTO", "Rua 13 de maio");

            pessoaJuridica.ExibirNome();

            Console.ReadKey();

            /*
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaJuridica pessoaJuridica = new PessoaJuridica(); 
            
            pessoaFisica.CPF = "123.456.789.12";
            pessoaFisica.RG = "123456-7";
            pessoaFisica.Nome = "Dan";

            pessoaJuridica.Nome = "Empresa XPTO Ltda";
            pessoaJuridica.CNPJ = "123.456/789-00";
            pessoaJuridica.InscricaoEstadual = "1456987";

            pessoaFisica.Criar(pessoaFisica);
            pessoaJuridica.Criar(pessoaJuridica);
            */


            // a variavel "pessoa" está recebendo a classe "Pessoa"
            //ou seja, se ela está rebendo uma classe logo, ela se torna um Objeto
            //o que eu tenho dentro do objeto? os métodos e as propriedades

            // string nome = "Rita";  variavel ==> 1(variavel) para 1(valor)
            /*
            Pessoa pessoa = new Pessoa(); //objeto ==> propriedades(atributos) e metodos

            // atribuindo valores para propriedades Nome, CPF, RG, Idade, Endereco do objeto Pessoa
            // aqui abaixo é o set, voce está "setando"
            pessoa.Nome = "Dan";
            pessoa.CPF = "123.456.789.12";
            pessoa.RG = "123456-7";
            pessoa.Idade = 200;
            pessoa.Endereco = "Rua dos Bobos, 0";
            */

            //Console.WriteLine("Hello World!");
        }
    }
}
