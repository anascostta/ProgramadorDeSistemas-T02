using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//get = lê/pega
//set = altera/muda
namespace classes
{
    //definição da classe carro 
    internal class Carro
    {
        //Propiedade pública: Pode ser acessada e modificada fora da classe
        public string Marca { get; set; } //Publica a propiedade Marca
        
        //Propiedade privada: Não pode ser acessada ou modificada fora da classe
        private string Modelo { get; set; } //Privada, acessível apenas dentro da classe

        //Propiedade privada com um campo privado e um método getter e setter personalizados
        private int ano; // Campo privado

        public int Ano
        {
            get { return ano; } //Getter para acessar o valor do campo privado
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) //Verificação para garantir um valor válido
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }

            }
        }
        //Método público para exibir informações do carro 
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}"); //Acesso ao modelo é restrito por ser privado
            Console.WriteLine($"Ano: {Ano}");
        }

        //Método para calcular a idade do carro
        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }

        //Método para definir o modelo do carro (com exemplo de uso de propriedade privada)
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo; //Acessando a propriedade privada dentro da classe
        }
    }

    internal class Program
    {
        static void Main(string[] args) //static=vazia
        {
            //Criando um objeto da classe carro
            Carro meuCarro = new Carro();//Criando uma nova instância/objeto dentro da classe Carro

            //Atribuindo valores às propiedades públicas e privadas 
            meuCarro.Marca = "Toyota";
            meuCarro.DefinirModelo("Corolla"); //Usando método para definir o modelo, pois é privado
            meuCarro.Ano = 2020; //A propiedade Ano é pública, mas com uma validação interna

            //Exibindo as informações do carro
            meuCarro.ExibirInformacoes();

            //Calculando e exibindo a idade do carro
            int idadeCarro = meuCarro.CalcularIdade();
            Console.WriteLine($"Idade do carro: {idadeCarro} anos.");

            //Mantendo o console aberto
            Console.ReadLine();
        }
    }
}

