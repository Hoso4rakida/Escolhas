using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.common.Models//aqui e´ aonde esta o nome do seu projeto, então deixe ele aqui pfv
{
    public class Sistema//deixa isso aqui meu mano, isso aqui e tipo o main do c++
    {
        public static int[] idade = new int[]{0,0,0,0,0};
        public static string[] nomes = {"","","","",""};
        public static byte valor = 0; 
        public static void Adicionar(int rodada)//aqui voce criou um objeto, parabens kkk
        {//aqui tera o sistema que sera executado no projetinho.
            Console.WriteLine("Vamos criar a sua ficha, digite seu nome: ");
            nomes[rodada] = Console.ReadLine();
            Console.WriteLine("Sua idade?");
            idade[rodada] = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("{Nome}, Voce foi adicionado no sistema");
            valor++;
        }
        public static void Deletar(int rodada)
        {
            Console.WriteLine("Qual sera o valor?");
            Console.ReadLine();
        
        }
        public static void ler(int rodada)
        {
            Console.WriteLine($"possuimos {valor} de 5 pessoas registradas");

            int leitura = 0;

            while(idade[leitura] != 0)
            {
                Console.WriteLine($"Nome: {nomes[leitura]}, idade: {idade[leitura]}");
                leitura++;
            }
            Console.ReadLine();

        }
    }

}

//não esqueça de adicionar a referencia no csproject do projetinho.
/*
  <ItemGroup>
    <ProjectReference Include="..\Fundamentos.common\Fundamentos.common.csproj" />
  </ItemGroup>
*/