// dotnet ./bin/Debug/net7.0/firstCode.dll

using System;
using System.Text;

namespace Project {
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
        }              
    }
}