using System;

namespace jokenpo
{
    class Program
    {
        
        
        
        
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            
            Console.Title = "JoKenPô";

            Console.WriteLine("Bem vindo Jogador! Escolha entre: 0(Pedra), 1(Papel) ou 2(Tesoura) e então pressione Enter!");
            string escolha = Console.ReadLine();
            Console.WriteLine("Pressione Enter para o computador escolher um número!");

                int escolha2 =numberGen.Next(0, 2);

                for (int i = 0; i <= escolha2; i++)
                {
                    Console.ReadKey();
                    Console.WriteLine("O computador escolheu: " + escolha2);
                }
                
           
                
                if(escolha == Convert.ToString(escolha2) )
                {
                    Console.WriteLine("Empate!");

                }
                if(escolha != Convert.ToString(escolha2) && escolha == "0" && Convert.ToString(escolha2) == "2")
                {
                    Console.WriteLine("Jogador Venceu! Parabéns!");
                }
                if(escolha != Convert.ToString(escolha2) && escolha == "0" && Convert.ToString(escolha2) == "1")
                {
                    Console.WriteLine("Computador Venceu! Parabéns!");
                }
                if(escolha != Convert.ToString(escolha2) && escolha == "1" && Convert.ToString(escolha2) == "0")
                {
                    Console.WriteLine("Jogador Venceu! Parabéns!");
                }
                if(escolha != Convert.ToString(escolha2) && escolha == "1" && Convert.ToString(escolha2) == "2")
                {
                    Console.WriteLine("Computador Venceu! Parabéns!");
                }
                if(escolha != Convert.ToString(escolha2) && escolha == "2" && Convert.ToString(escolha2) == "1")
                {
                    Console.WriteLine("Jogador Venceu! Parabéns!");
                }
                if(escolha != Convert.ToString(escolha2) && escolha == "2" && Convert.ToString(escolha2) == "0")
                {
                    Console.WriteLine("Computador Venceu! Parabéns!");
                }


                
            Console.ReadKey();
        }
    }
}
