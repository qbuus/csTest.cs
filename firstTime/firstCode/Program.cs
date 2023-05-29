using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

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
    class Program {
        static void CheckFiles() 
        {
            var doc2 = "C:/Users/jkocz/Desktop/123/123.txt";
            var doc1 = "C:/Users/jkocz/Desktop/123/321.txt";

            var content2 = System.IO.File.ReadAllLines(doc2);
            var content1 = System.IO.File.ReadAllLines(doc1);

            // used for all Idisposable classes
            // will be closed even with exception 
            // because of dispose 
            using (var ContentStream = new FileStream(doc1, FileMode.Open))
            {
                throw new Exception();
            }           
        }

        static void Basics() 
        {
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
            int biggestNum = 0;
            do {
                string userInputCheck = Console.ReadLine();
                validInputCheck = int.Parse(userInputCheck);
                
                sum += validInputCheck;
                if (biggestNum <= validInputCheck) {
                    biggestNum = validInputCheck;
                };

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
             Console.WriteLine($"Favorite day of the week is: {(dayOfTheWeekYouLike.HasValue ? dayOfTheWeekYouLike.Value: "")}");

             try {
                Console.WriteLine("done");
                cars[6] = "Lancia";
             } catch (IndexOutOfRangeException e){
                Console.WriteLine("indexoutofrangeexception");
             } catch (Exception e) {
                Console.WriteLine("handling any error");
             } // finally runs no matter what
             finally {Console.WriteLine("done no matter what");
             }   

            
            Console.WriteLine("Enter your birth date");
            Console.WriteLine("Enter your birth year");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth month. From 1 to 12");
            int monthOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your day of birth. From 1 to 31");
            int dayOfBirth = int.Parse(Console.ReadLine());   

            DateTime then = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);                            
            TimeSpan result = atm - then;
            Console.WriteLine($"Diff in days: {result.Days}");


            // regex
            string emailIsValid = "k12.k21@gmail.com";
            Regex regexEmail = new Regex(@"^([a-z0-9]+)\.?([a-z0-9]+)@([a-z]+)\.[a-z]{2,3}$");
            bool isItValid = regexEmail.IsMatch(emailIsValid);
            Console.WriteLine(isItValid);

            Car adam = new Car("toyota", 2013, 10200);
            Car Jay = new Car("Ford", 2015, 116000);
            // constructor values
        //    if (adam.CarName != null) {
        //     Console.WriteLine($"{adam.CarName}");
        //    } 
            // adam.mileage = 15200;
            // adam.yearOfProduction = 2013;
            
            Console.WriteLine($"amount of object: {Car.Count}");
            adam.CheckIfPast(adam.yearOfProduction);
            adam.checkInt();
            adam.WriteAll();
            Jay.CheckIfPast(Jay.yearOfProduction);
            Jay.checkInt();
            Jay.WriteAll();

            File testFile = new File();
            testFile.Name = "testFile";
            testFile.Size = 12;
            testFile.whenCreatedFile = DateTime.Now;  
            testFile.Info();  
            
            Anotherfile testAnoterFile = new Anotherfile(); 
            testAnoterFile.Name = "testAnoterFile";
            testAnoterFile.Size = 24;
            testAnoterFile.whenCreatedFile = DateTime.Now; 
            testAnoterFile.Info();  

            string[] arrayOfStringToTest = {"1", "2", "3"};
            int lengthOfAnStringArray = arrayOfStringToTest.Length;
            Console.WriteLine($"{lengthOfAnStringArray}");

            List<string> stringListCollection = new List<string>(){"1", "2", "3"};
            // {} after () in List means we add a starting values
            // int value = 4;
            // stringListCollection.Add("4");
            // // after adding 1 item to the array of str's
            static void ShowListElements(List<string> List){
                
                Console.WriteLine("List is as follows:");

                foreach (string item in List)
                {
                    Console.WriteLine($"{item}, ");
                }
            };
            // ShowListElements(stringListCollection);

            
            Console.WriteLine("To add new element to List type whatever you want");
            Console.WriteLine("Click escape to exit");      
          do 
          {         
            string ConsoleInput = Console.ReadLine();
            stringListCollection.Add(ConsoleInput);
            Console.WriteLine($"value {ConsoleInput} added to the List");

            if (Console.ReadKey(true).Key == ConsoleKey.Escape) {
                ShowListElements(stringListCollection);

                stringListCollection.Sort();
                ShowListElements(stringListCollection);
                
                stringListCollection.RemoveRange(0,1);
                ShowListElements(stringListCollection);
                
                stringListCollection.Clear();
                ShowListElements(stringListCollection);
                
                break;
            }
          } while (Console.ReadKey(true).Key != ConsoleKey.Escape);  

          
                do
            {
                Console.WriteLine("To exit click Escape on your keyboard");
                Console.WriteLine("type a number and check if it is negative");
                int checkIfNegativeNumber = int.Parse(Console.ReadLine());
                if (checkIfNegativeNumber < 0) 
                {
                Console.WriteLine(checkIfNegativeNumber + " is a negative number");
                } else 
                {
                Console.WriteLine(checkIfNegativeNumber + " is not a negative number");
                }

                if (Console.ReadKey(true).Key == ConsoleKey.Escape) {break;}
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        static void SubString(string input)
        {   
            if (input != null && input.Length > 10) {
            Console.WriteLine("starting input is " + input);
            string substr = input.Substring(1); // (start index, length)
            string lastt10Sub = input.Substring(input.Length - 10); // last 1 char till the end
            Console.WriteLine(substr + " starting at 1, length not specified, with whitespace");
            Console.WriteLine(lastt10Sub + " last 1 till the end with whitespace, no 2nd parameter");
            }
        }

        static void Replace(string input)
        {
            Console.WriteLine("will be replaced");
            string strToReplace = "Replaced: {replaced}";
            Console.WriteLine($"{strToReplace}");
            string outP = strToReplace.Replace("{replace}", input);
            Console.WriteLine($"{outP}");
        }

        static void Modify(string input)
        {
            string clearedStr = input.Remove(5);
            Console.WriteLine($"Removed after 5 length {clearedStr}"); // only first 5, next chars are removed
            string insertStr = input.Insert(5, "inserted");
            Console.WriteLine($"added to 5th index value:  {clearedStr}");
            string trimmerdStr = input.Trim(); // trimms white space around the string
        }

        static void AlterTextClasses(string input)
        {
            string upperCase = input.ToUpper(); // uppercase
            Console.WriteLine($"{upperCase}");
            string lowerCase = input.ToLower(); // lowercase
            Console.WriteLine($"{lowerCase}");
        }

        static void Split(string input)
        {
            string[] splitInput = input.Split(" "); // with space
            string first = splitInput[0];
            string last = splitInput[splitInput.Length - 1];
            Console.WriteLine(first + last);
        }
        static void Main(string[] args) {
            Console.WriteLine("type something");
            string TypeInput = Console.ReadLine();

            SubString(TypeInput);
            Replace(TypeInput);
            Modify(TypeInput);
            Split(TypeInput);
        } 
    }
}
// dotnet ./bin/Debug/net7.0/firstCode.dll