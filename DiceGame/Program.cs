using System.Runtime.CompilerServices;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int playerAIScore = 0;
            Console.WriteLine("Hello, Welcome to the dice game.");
            Console.WriteLine("Here you will be playing 10 rounds of the game with AI. Whoever scores highest at the end wins.");
            Console.WriteLine("Good luck!");
            Console.WriteLine("Press any key to start.");
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------------------------------------");
            for (int i = 0; i < 10; i++)
            {
                int playerDice = 0;
                int playerAiDice = 0;
                Random random = new Random();
                playerDice = random.Next(1,7);
                if (i != 0)
                {
                    Console.WriteLine("---------------------------NEXT ROUND------------------------------------");
                }
                Console.WriteLine("You rolled the dice for a number: {0}", playerDice);
                Thread.Sleep(1500);
                playerAiDice = random.Next(1,7);
                Console.WriteLine("AI player rolled the dice for a number: {0}", playerAiDice);

                if(playerDice > playerAiDice)
                {
                    playerScore++;
                    Console.WriteLine("This round is won by you! \nScore after this round: You - {0}, AI Player - {1}", playerScore, playerAIScore);
                }
                else if(playerDice < playerAiDice) 
                {
                    playerAIScore++;
                    Console.WriteLine("This round is won by AI player! \nScore after this round: You - {0}, AI Player - {1}", playerScore, playerAIScore);
                }
                else
                {
                    Console.WriteLine("This round is a draw!");
                }
                
            }
            Console.WriteLine("----------------------------FINAL SCORE------------------------------");
            Console.WriteLine("Final score: You - {0}, AI Player - {1}", playerScore, playerAIScore);
            if (playerScore > playerAIScore)
            {
                Console.WriteLine("You have won the game!");
            }
            else if(playerScore < playerAIScore)
            {
                Console.WriteLine("Player AI has won the game!");
            }
            else
            {
                Console.WriteLine("Its a draw!");
            }
            Console.WriteLine("----------------------------GAME OVER------------------------------");
            Console.ReadKey();
        }
    }
}
