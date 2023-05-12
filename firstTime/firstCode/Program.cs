// dotnet ./bin/Debug/net7.0/firstCode.dll

using System;
using System.Text;
using System.Threading.Channels;

namespace Project {
    enum DayOf: byte
            {
                Monday = 1,
                Tuesday = 2,
                Wednesday = 3,
                Thursday = 4,
                Friday = 5,
                Saturday = 5,
                Sunday = 6,
            }
    internal class ConsoleTest {
        private static void Main(string[] args) {
            Console.WriteLine("Hello World");
            Console.WriteLine("Welcome World");

            // .Write w jednej linii bez końca
            Console.Write("Hello");
            Console.Write("Hello23");

            Console.WriteLine("Please, fill with your name in");
            // communicates with user
            string name = Console.ReadLine();
            Console.WriteLine(name);

            // first type of variable then name = value 
            string testText = "Text";
            
            // represents one thing or unicode 
            char testChar = '\u006A';

            // has only 2 value = true || false
            bool isItTrue = true;
            
            // dates 
            DateTime atm = DateTime.Now; 
            Console.WriteLine(atm);
            DateTime myBirtDay = new DateTime(year: 1999, month: 5, day: 8);

            // float. Need to have F after the value. Less accurate
            // than double and decimal which is the most accurate
            float fNumber = 1.5f;

            // double value. No need to specify bcs compiler knows
            // it is a double type. Mid when it comes to accuracy;
            // Real value but not recommended with high acc demands 
            double dValue = 1.5;

            // decimal. Needs M after all. Gives exact number for ex
            // when it comes to finances
            decimal decNumber = 1.5m;
            Console.WriteLine(fNumber);
            Console.WriteLine(dValue);
            Console.WriteLine(decNumber);

            string someMessage;
            someMessage = "someMessage";
            Console.WriteLine(someMessage);

            // string messageInt = null;
            // Console.WriteLine(messageInt);

            string messageEmpt;
            messageEmpt = string.Empty;
            
            string testLocation = "c:\\windows\\fonts";
            // verbatim text, @ in front of text
            // for example use it instead of double bslash
            string someFolder = @"c:\windows\fonts";

            // concatenate 2 or more string
            string textToConcat = "hi";
            // string fillInWithName = Console.ReadLine();
            // string concatString = string.Concat(textToConcat, fillInWithName);

            string conc = textToConcat + "Pepe" + "wasd";

            // slows performance 
            string conc3 = $"{textToConcat} Pepe dsaw";

            // string builder that dynamically incrases memory

            // StringBuiler(value, memorySpace);
            // appends with no spaces in between diff values
            StringBuilder sb = new StringBuilder("Appended", 5);
            sb.Append("1");
            sb.Append("2");
            sb.Append("3");
            sb.Append("4");

            Console.WriteLine(testLocation);
            Console.WriteLine(someFolder);
            Console.WriteLine(conc);
            Console.WriteLine(conc3);
            Console.WriteLine(sb);


            // integers
            int resultOfMaths;
            int a = 12;
            int b = 6;
            bool bResults;

            resultOfMaths = (a + b);
            Console.WriteLine($"{resultOfMaths}");
            resultOfMaths = (a - b);
            Console.WriteLine(resultOfMaths);
            resultOfMaths = (a * b);
            Console.WriteLine(resultOfMaths);
            resultOfMaths = (a / b);
            Console.WriteLine(resultOfMaths);
            resultOfMaths = (a % b);
            Console.WriteLine(resultOfMaths);

            bResults = (a >= 10);
            Console.WriteLine(bResults);
            bResults = (b != a);
            Console.WriteLine(bResults);

            bResults = (a >= 10 && b <= 7);
            Console.WriteLine(bResults);

            // => || this or that,
            // => != is not true,s
            // => ? checks if true ==> : if not the this

            Console.WriteLine("enter your birth year");
            string input = Console.ReadLine();
            // int parsedInput = int.Parse(input);
            // float parsedFloat = float.Parse(input);
           
            // int age = DateTime.Now.Year - userInput;
            // Console.WriteLine(age);

            // if you want it to be 100% correct 
            // use TryParse => checks 
            int tryParseInput;
            if (int.TryParse(input, out tryParseInput)) {
                int ageOf = DateTime.Now.Year - tryParseInput;
                Console.WriteLine(ageOf);
            } else {
                Console.WriteLine("value must be correct");
            }

            byte val = 125;
            // byte needs no additional method to be converted to 
            // int. Because it can store all the values its got
            int valIn = val;
            // how to convert int to byte
            byte valReversed = (byte)valIn;


            string[] cars = {"Audi", "Skoda", "Volvo", "Peugeot"};
            Console.WriteLine("Please, enter the index number in cars array");
            string intOfCar = Console.ReadLine();
            int convertedIntOfCar = int.Parse(intOfCar);

            if (convertedIntOfCar <= cars.Length - 1) {
                Console.WriteLine(cars[convertedIntOfCar]);
            } else {
                Console.WriteLine("This number is not a valid index of cars array");
            }

            // iteration 
            int w = 0;

            // while
            while (w <= cars.Length - 1) {
                Console.WriteLine(w);
                w++;
            }
            
            // do while
            Console.WriteLine("to exit type x");          
            string userInput;
            do {
                userInput = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput}");
            } while (userInput != "x"); 

            // for
            for (int i = 0; i <= cars.Length -1; i++)
            {
                Console.WriteLine($"car: {i}");
            }

            // for each 
            foreach (string item in cars)
            {
                Console.WriteLine($"name: {item}");
            }


            Console.WriteLine("Please Enter a number");
            Console.WriteLine("It adds each entry to one another");
            Console.WriteLine("Enter value == 0 to exit and see the results");

            int validInputCheck; 
            int sum = 0;
            int? biggestNum = null;
            do {
                string userInputCheck = Console.ReadLine();
                validInputCheck = int.Parse(userInputCheck);
                
                if (biggestNum <= validInputCheck) {
                    biggestNum = validInputCheck;
                };
                
                sum += validInputCheck;

                if (validInputCheck == 0) {
                    Console.WriteLine($"Your sum is: {sum}");
                    Console.WriteLine($"Your biggest entry was: {biggestNum}");
                };
            } while (validInputCheck != 0);          


            // switch statement
             switch (DateTime.Now.DayOfWeek)
             {
                case DayOfWeek.Saturday: 
                    Console.WriteLine("It's Saturday!");
                    break;
                case DayOfWeek.Sunday: 
                    Console.WriteLine("It's Sunday!");
                    break;
                default: 
                Console.WriteLine("Go to work !");
                break;
             }

             int? dayOfTheWeekYouLike = default;
             Console.WriteLine("Choose your favorite day of the week");
             Console.ReadLine();
             Console.WriteLine($"Favorite day of the week is: {(dayOfTheWeekYouLike.HasValue ? dayOfTheWeekYouLike.Value: "")}")           
        }              
    }
}
// dotnet ./bin/Debug/net7.0/firstCode.dll