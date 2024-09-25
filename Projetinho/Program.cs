using System;
using Fundamentos.common.Models;

class Program
{
    static void Main(string[] arg)
    {
        int Numero = 9;
        int rodada = 0;
        while(Numero != 0 && rodada < 5)
        {
            Console.WriteLine("Bem vindo ao nosso sistema de atendimento, como posso ajudar?");
            Console.WriteLine("[1] Criar um cadastro");
            Console.WriteLine("[2] Remover um perfil");
            Console.WriteLine("[3] Ver perfils");
            Console.WriteLine("[0] Sair do programa");
            Console.WriteLine("Caso não digite um numero o programa se encerrara tambem");

            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out Numero))
            {
                switch(Numero)
                {
                case 1:
                    Sistema.Adicionar(rodada);
                    rodada = rodada + 1;
                    break;
                case 2:
                    Sistema.Deletar(rodada);

                    break;
                case 3:
                    Sistema.ler(rodada);
                    break;
                default:
                    Console.WriteLine("Descupa, mais não temos essa função");
                    break;
                }
            }
           else
            {
                Console.WriteLine("Entrada invalida, o programa se encerrara.");
                Environment.Exit(0);
            }
            Console.Clear();
        }
        
    }
}