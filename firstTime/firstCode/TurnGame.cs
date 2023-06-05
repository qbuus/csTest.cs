namespace Project
{
   public  class TurnBasedGame 
    {
        public static void Game()
        {
            int aiHp = 25;
            int playerHp = 35;

            int healPoint = 4;

            int aiAttack = 8;
            int playerAttack = 6;

            Random randomNumber = new Random();

            while(aiHp > 0 && playerHp > 0)
            {
                Console.WriteLine($"playerHP: {playerHp}");
                Console.WriteLine($"aiHP: {aiHp}");
                Console.WriteLine("_______________");
                Console.WriteLine("|| Player Turn ||");
                Console.WriteLine("Type A => attack");
                Console.WriteLine("Type H => Heal");

                string userInput = Console.ReadLine();

                if (userInput == "a")
                {
                    aiHp -= playerAttack;
                    Console.WriteLine($"Player attacks and deals {playerAttack} damage");
                } else if (userInput == "h")
                {
                    playerHp += healPoint;
                    Console.WriteLine($"Player restores {healPoint} HP");
                } else {
                    Console.WriteLine("No actions is available under this input");
                }

                if (aiHp > 0)
                {
                    Console.WriteLine("|| Enemy Turn ||");
                    int AiInput = randomNumber.Next(0,2);

                    if(AiInput == 0)
                    {
                        Console.WriteLine($"Enemy attacks and deals {aiAttack} damage");
                        playerHp -= aiAttack;
                    } else 
                    {
                        aiAttack += healPoint;
                        Console.WriteLine($"Ai restores {healPoint} HP");
                    }
                }
            }

            if(playerHp > 0)
            {
                Console.WriteLine("You have won");
            } else 
            {
                Console.WriteLine("You lose");
            }
        }
    }
}