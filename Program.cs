using System;
class Program
{
    static void Main(string[] arg)
    {
        int Numero = 9;
        while(Numero != 0)
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
                    Console.WriteLine("Vamos criar a sua ficha, digite seu nome: ");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Vamos Remover um perfil, porfavor digite o numero do perfil que quer deletar: ");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Aqui esta a lista dos perfis registrdos: ");
                    Console.ReadLine();
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