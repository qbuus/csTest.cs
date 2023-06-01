namespace Project
{   
    class Calculator {
            public static void Calculate()
            {
                int x;
                int y;
                int results;
                string? answer;
                
                Console.WriteLine("|| Calculator ||");
                Console.WriteLine("___________");
                Console.WriteLine("What would you like to do ?");
                Console.WriteLine("type A for addition");
                Console.WriteLine("type S for substraction");
                Console.WriteLine("type M for multiplication");
                Console.WriteLine("type D for division");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "a":
                        Console.WriteLine("|| Addition ||");
                        Console.WriteLine("___________");
                        Console.WriteLine("Type a number");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"What number would you like to add to {x}");
                        y = int.Parse(Console.ReadLine());
                        results = x + y;
                        Console.WriteLine("your results is: " + results);
                        Console.WriteLine("___________");
                        Console.WriteLine("Click escape to exit");
                        break; 
                    case "s":
                        Console.WriteLine("|| Substraction ||");
                        Console.WriteLine("___________");
                        Console.WriteLine("Type a number");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{x} substract by ?");
                        y = int.Parse(Console.ReadLine());
                        results = x - y;
                        Console.WriteLine("your results is: " + results);
                        Console.WriteLine("___________");
                        Console.WriteLine("Click escape to exit");
                        break;
                    case "m":
                        Console.WriteLine("|| Multiplication ||");
                        Console.WriteLine("___________");
                        Console.WriteLine("Type a number");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Multiply {x} with ?");
                        y = int.Parse(Console.ReadLine());
                        results = x * y;
                        Console.WriteLine("your results is: " + results);
                        Console.WriteLine("___________");
                        Console.WriteLine("Click escape to exit");
                        break;
                    case "d":
                        Console.WriteLine("|| Division ||");
                        Console.WriteLine("___________");
                        Console.WriteLine("Type a number");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Divide {x} by ?");
                        y = int.Parse(Console.ReadLine());
                        results = x / y;
                        Console.WriteLine("your results is: " + results);
                        Console.WriteLine("___________");
                        Console.WriteLine("Click escape to exit");
                        break;
                    default:
                        Console.WriteLine("Could not calculate");
                        Console.WriteLine("___________");
                        Console.WriteLine("Click escape to exit");
                        break;
                }
            }
    }        
}