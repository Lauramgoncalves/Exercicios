using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStructs
{
    class Program
    {

        struct Produto
        {
            public string nome; // -> Atributo
            public float preco; // Public significa ue essas variaveis podem ser acessadas por ualuer parte do codigo.
            public float peso;
            public string marca;

            //construtor 
            public Produto(string nome, float preco, float peso, string marca) //<- Parametro
            {
                /* nome = nome;   nome dentro da função está se referindo ao parametro, para se referir a do atributo usar o
             this. Ex*/
                this.nome = nome; // Variavel do atributo =(Recebe) variavel do parametro.
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }







            static void Main(string[] args)
            {
                Produto bolacha = new Produto("Bolacha bono", 3.5f, 0.126f, "Nestle");
                Produto salgadinho = new Produto("Salgadinho", 15.90f, 0.210f, "PepsiCo Foods"); /* -> está pegando os valores passados via parametro
            e salvando dentro dos atributos da estrutura*/
                //Console.WriteLine(bolacha.nome);
               

                // chamando a função
                bolacha.Exibirinfo();
                Console.WriteLine("----------------------------");
                salgadinho.Exibirinfo(); // Pegue os campos da variavel e exiba no console
                
                
                float ValorFinal = bolacha.AdicionarCupom(50f);
                float ValorFinalS =  salgadinho.AdicionarCupom(50f);


                Console.WriteLine(ValorFinal);
                Console.WriteLine(ValorFinalS);
                Console.ReadLine();
            }


            // funçoes em structs 

            public void Exibirinfo() // Public -> é pra poder usar a função em ualuer parte do código.
            {   // o this se refere aos atributos
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Preço: R$: {this.preco}");
                Console.WriteLine($"Peso: {this.peso} KG");
                Console.WriteLine($"Marca: {this.marca} ");

            }
                /* outro exemplo de função 
                public void AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                Console.WriteLine(this.preco - desconto);
                
            }*/ 
                
                //para retornar com o valor final
            public float AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                return this.preco - desconto;

            }



            /* As structs são uma forma de colocar varias variaveis em uma.
         Ex:  Produto -> nome, preco, peso, marca;

            Produto.nome;
            Produto.preço;

           Produto bola = new Produto();
           bola.nome = "Bola do Neymar";
           bola.preco = 14f;
           bola.peso = 3f;
           bola.marca = "Adidas";
           Console.WriteLine(bola.nome);

           Produto balde = new Produto();
           bola.nome = "Balde";
           bola.preco = 2f;
           bola.peso = 0.2f;
           bola.marca = "?";

           Console.ReadLine(); 
       }*/
        }

    }
}
