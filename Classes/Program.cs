//Classes: Modelo para criar objetos definindo suas características
//Objeto: Representação da vida real na programação
//Métodos: Aquilo que o cliente pode fazer (verbos: andar...)
//Instância: Dado de um objeto (string nome = "Ana")
using System;
using System.Runtime.CompilerServices;

class Classes
{
    static void Main(string[] args)
    {
        Console.WriteLine();
    }

    class Pessoa
    {
        //atributos da classe: dados atribuidos a classe
        private string nome;
        private int idade;
        private string peso;
        private double altura;

        public void Andar() //métodos são funções que vão ser executadas
        {
            Console.WriteLine("Quantos minutos vc caminha em média por dia?");
            int km = int.Parse(Console.ReadLine());
        }

        public void Comer() //métodos são funções que vão ser executadas
        {
            Console.WriteLine("O que você comeu hoje?");
            string comer = Console.ReadLine();
        }

        public void Trabalhar() //métodos são funções que vão ser executadas
        {
            Console.WriteLine("Qual sua profissão?");
            string profissao = Console.ReadLine();
        }

        public void Somar()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + b);
        }

  
    }
        
 
}
