using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft;
using Newtonsoft.Json;
using Flurl.Http;

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

        static void DateTimePlay()
        {
            DateTime now = DateTime.Now;
            DateTime birthdayDate = new DateTime(1999, 5, 8);
            TimeSpan difference = now - birthdayDate;
            Console.WriteLine(difference);

            DateTime adds = now.AddDays(7);
            Console.WriteLine("added 7 day to now " + adds);

            DateTime addsWithTimeSpan = now.Add(new TimeSpan(7,0,0,0));
            Console.WriteLine("added 7 day to now " + addsWithTimeSpan);

            bool isDateEqual = adds.Date == addsWithTimeSpan.Date;
            Console.WriteLine(isDateEqual);

            Console.WriteLine("Format Date To Long" + now.ToLongDateString());
            Console.WriteLine("Format Date To Short" + now.ToShortDateString());

            TimeSpan HowLong = addsWithTimeSpan - now;
            Console.WriteLine("time measuremenet" + HowLong);

           // ||

           Stopwatch stopwatch = Stopwatch.StartNew();
           stopwatch.Stop(); 
           Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

           // helpers
            int DaysInFeb = DateTime.DaysInMonth(2022, 2);
            Console.WriteLine("February days in 2022: " + DaysInFeb);

            bool isLeapYear = DateTime.IsLeapYear(2022);
            Console.WriteLine("Was 2022 a leap year?: " + isLeapYear);
        }

        static List<GoogleApp> LoadApp(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }

        }

        static void GetData(IEnumerable<GoogleApp> googleApps)
        {   

            var above46 = googleApps.Where((GoogleApp c) => c.Rating > 4.6 && c.Category == Category.BEAUTY);
            Display(above46);

            var reviews = above46.FirstOrDefault(c => c.Reviews < 300);
            
            var reviewsSingle = above46.Single(c => c.Reviews < 300);
            // when singleordefault is used instead of single we get
            // null if no match is found

            var reviewsSingleLast = above46.Last(c => c.Reviews < 300);
            // when lastordefault is used instead of last we get
            // null if no match is found
        }

        static void Project(IEnumerable<GoogleApp> googleApps)
        {
            var above46 = googleApps.Where((GoogleApp c) => c.Rating > 4.6 && c.Category == Category.BEAUTY);
                      
            // list of names of apps where rating is above46
            // List<string> NamesOfAbove46 = new List<string>();
            // foreach (var item in above46)
            // {
            //     NamesOfAbove46.Add(item.Name);
            // }

            // does the same but with the select method
            var above46Names = above46.Select(c => c.Name);

            // dto to communicate with end user
            var dtoNames = above46.Select(c => new dto()
            {
                Reviews = c.Reviews,
                Name = c.Name
            });

            foreach (var item in dtoNames)
            {
                Console.WriteLine(item.Name, item.Reviews);
            }

            var gen = above46.SelectMany(c => c.Genres);
            Console.WriteLine(string.Join(", ", gen));

            var anonymouseType = above46.Select(c => new
            {
                Reviews = c.Reviews,
                Name = c.Name,
                Category = c.Category
            });

             foreach (var item in anonymouseType)
            {
                Console.WriteLine(item.Name, item.Reviews);
            }
        }

        static void Divide(IEnumerable<GoogleApp> googleApps)
        {
                var above46 = googleApps.Where((GoogleApp c) => c.Rating > 4.6 && c.Category == Category.BEAUTY);

                // only 5 results
                var only5Results = above46.Take(5);
                // only last 5 results
                var onlyLast5Results = above46.TakeLast(5);

                // takes results that are true in lambda
                var takeWhileResults = above46.TakeWhile(c => c.Reviews < 1000);

                // skips first 5 results then shows the rest
                var skippFirst5AndShowWhatsAfter = above46.Skip(5);

                // skipWhile takes lamba and returs whats true 
                var skipWhileResults = above46.SkipWhile(c => c.Reviews < 1000);
        }

        static void Sorts(IEnumerable<GoogleApp> googleApps)
        {
            var baseData = googleApps.Where((GoogleApp c) => c.Rating > 4.4 && c.Category == Category.BEAUTY);

            // default sorting (ascending) by reviews
            var sortedData = baseData.OrderBy(c => c.Reviews);

            var descendingData = baseData.OrderByDescending(c => c.Reviews);         
        }

        static void CollectionData(IEnumerable<GoogleApp> googleApps)
        {
            var baseData = googleApps.Where((GoogleApp c) => c.Type == Type.Paid).Select(a => a.Category)
            .Distinct();
            // Disting means no duplicates

            var set1 = googleApps.Where(c => c.Rating > 4.7 && c.Type == Type.Paid && c.Reviews > 1000);
            var set2 = googleApps.Where(c => c.Name.Contains("Pro") && c.Rating > 4.6 && c.Reviews > 10000);

            // both covers the same data            
            set1.Union(set2);

            // first set except it does not cover what 1 does in a second one 
            set1.Except(set2);
        }

        static void VerifyData(IEnumerable<GoogleApp> googleApps)
        {
            var baseData = googleApps.Where(a => a.Category == Category.WEATHER)
            .All(a => a.Reviews > 10);
            // all weather categories with more reviews than 10 

            var baseAnyData = googleApps.Where(a => a.Category == Category.WEATHER)
            .Any(c => c.Reviews > 10);
            // if any match the condition given to lambda
        }

        static void Groups(IEnumerable<GoogleApp> googleApps)
        {
            // var baseData = googleApps.GroupBy(c => c.Category)
            // .First(c => c.Key == Category.ART_AND_DESIGN)
            // .Select(e=>e).ToList();
            // Display(baseData);

            var baseGroup = googleApps.GroupBy(c => c.Category);

            foreach (var group in baseGroup)
            {
               var avgReviews = group.Average(c => c.Reviews);
               var least = group.Min(c => c.Reviews);
               var max = group.Max(c => c.Reviews);
               var sumUp = group.Sum(c => c.Reviews);
            }
        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var item in googleApps)
            {
                
            }
        }

        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static void LinqCs()
        {
            string csvPath = @"C:\Users\jkocz\Desktop\googleplaystore1.csv";
            var App = LoadApp(csvPath);

            Display(App);
        }

        static void genericTypes()
        {   
            string stringInput = Console.ReadLine();
            int number;
            List<int> intList = new List<int>();
            bool success = int.TryParse(stringInput, out number);
            if (success)
            {
                intList.Add(number);
            }

            var rests = new List<Restau>();
            var results = new PaginatedResults<Restau>();
            results.ListResults = rests;

            var users = new List<User>();

            var stringStorage = new Storage<IStorage>();
            stringStorage.rtSpecificElement(1);

            var firstEl = stringStorage.rtSpecificElement(0);

            var userDic = new Storage<string, User>();
            userDic.add("first", new User() {Name = "Bill"});
            userDic.rtSpecificElement("Bill");
        }

        public delegate void DisplayDelegate(string value);
        static void DspDlg(string input)
        {
            DisplayDelegate Display = Console.WriteLine;
            Display(input);
        }

        static async Task AsyncTest()
        {
            Console.WriteLine("1");
            await Task.Delay(3000);   
            throw new Exception();      
            Console.WriteLine("2");
        }

        static async Task httpApi()
        {   
            // IDisposable so using should be used
            using   (var httpClient = new HttpClient())
            {
                var apiResult = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
                var jsonResponse = await apiResult.Content.ReadAsStringAsync();
                var postsJson = JsonConvert.DeserializeObject<List<ApiResponseBody>>(jsonResponse);
                var selected = postsJson.First(p => p.Id == 30);
                Console.WriteLine(selected.Title);

                selected.Title = "title";
                selected.Body = "body";
                var postBody = new StringContent(JsonConvert.SerializeObject(selected));
                var postResults = await httpClient.PostAsync("https://jsonplaceholder.typicode.com/posts", postBody);

                using (var msg = new HttpRequestMessage(HttpMethod.Post, "https://jsonplaceholder.typicode.com/posts"))
                {
                    msg.Headers.Add("content-type", "application/json");
                    msg.Content = postBody;
                    var postResultss = await httpClient.SendAsync(msg);
                };
                
                // var params = HttpUtility.ParseQueryString(string.Empty);
                // params["postId"] = "1";
            };
        }

        static void ReflDisplay(Object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties();

            foreach (var item in properties)
            {
                var objValue = item.GetValue(obj);
                
                var typeOfEachItem = objValue.GetType();

                if (typeOfEachItem.IsPrimitive || typeOfEachItem == typeof(string))
                {
                    Console.WriteLine($"{item.Name}: {objValue}");
                }
            }
        }

        static void Refl()
        {
            Address  address = new Address ()
            {
                City = "Cracow",
                Name = "Adam",
                Id = 1
            };

            Person person = new Person()
            {
                Name = "Jacek",
                Id = 2
            };

            ReflDisplay(person);
            ReflDisplay(address);
        }
        static void Main(string[] args) {
            do
            {
                Console.WriteLine("Choose what game you would like to play");
                Console.WriteLine("|| ______ ||");
                Console.WriteLine("1 __ Calculator");
                Console.WriteLine("2 __ Dice game against ai");
                Console.WriteLine("To exit click key Escape");
                int UserInput = int.Parse(Console.ReadLine());

                switch (UserInput)
                {
                    case 1:
                    Calculator.Calculate();                      
                        break;
                    case 2:
                    DiceGame.Game();                     
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }  
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                    
        } 
    }
}
// dotnet ./bin/Debug/net7.0/firstCode.dll