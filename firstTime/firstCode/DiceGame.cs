namespace Project
{
    class DiceGame 
    {
        public static void Game()
        {   
            int userPoints = 0;
            int aiPoints = 0;
            
            Random number = new Random();

           

         for (int i = 0; i < 10; i++)
           {
            Console.WriteLine("Enter to roll a dice");

            int userInput = number.Next(1,7);
            int aiInput = number.Next(1,7);

            Console.ReadKey();

            Console.WriteLine("The result of the game is");

            Console.WriteLine(userInput);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(aiInput);

            if (userInput > aiInput)
            {
                Console.WriteLine("You win");
                userPoints += 3;
                System.Threading.Thread.Sleep(1000);
            } else if (userInput < aiInput)
            {
                Console.WriteLine("You lose");
                aiPoints += 3;
                System.Threading.Thread.Sleep(1000);
            } else 
            {
                Console.WriteLine("Draw");
                aiPoints++;
                aiPoints++;
                System.Threading.Thread.Sleep(1000);
            }
           }

            if (userPoints > aiPoints)
            {   
                Console.WriteLine(userPoints);
                Console.WriteLine(aiPoints);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You win");
            } else if (userPoints < aiPoints)
            {
                Console.WriteLine(userPoints);
                Console.WriteLine(aiPoints);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You lose");
            } else {
                Console.WriteLine(userPoints);
                Console.WriteLine(aiPoints);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Its a draw");
            }
        }
    }
}