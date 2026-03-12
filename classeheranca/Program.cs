using classeheranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeheranca
{
    //Classe base (superclasse)
    internal class Animal
    {
        //Propiedade da classe Animal
        public string Nome { get; set; }

        //Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom() //virtual significa que pode ter mais metodos nas classes abaixo
        {
            Console.WriteLine("O animal emite um som");
        }

    }

    //Classe derivada (subclasse)
    internal class Cachorro : Animal
    {
        public override void EmitirSom() //override meio que substitui/sobescreve o virtual
        {
             Console.WriteLine($"{Nome} late: Au Au!");
        }
    }

     //Outra classe derivada
     internal class Gato : Animal
     {
        public override void EmitirSom()
        {
             Console.WriteLine($"{Nome} mia: Miau!");
            bool vidas = false;
        }
     }
}

internal class Program
{
    //classe do programa, tudo que o usuario tem que ver deve estar aqui
    static void Main(string[] args)
    {
        //Criando instancias das classes derivadas
        Animal meuCachorro = new Cachorro { Nome = "Rex" };
        Animal meuGato = new Gato { Nome = "Felix" };

        //Chamando o metodo EmitirSom para cada animal
        meuCachorro.EmitirSom(); //Saida: Rex late: Au Au!
        meuGato.EmitirSom(); //Saida: Felix mia: Miau!

        //Utilizando polimorfismo: Array de animais
        Animal[] animais = { meuCachorro, meuGato };

        foreach (var animal in animais)
        {
            animal.EmitirSom(); //Cada objeto chama o metodo adequado de sua classe
        }
    }
}        