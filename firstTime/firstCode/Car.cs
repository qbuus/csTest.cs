using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Car
    {
        public string CarName;
        public int yearOfProduction;
        public int mileage;

        public static int Count = 0;

    public Car (string carName, int YearOfProduction, int Mileage) 
    {
        CarName = carName;
        yearOfProduction = YearOfProduction;
        mileage= Mileage;
        Count++;
    } // constructor
        public void CheckIfPast(int integer) {
            if (integer > yearOfProduction) {
                Console.WriteLine("Past");
            } else {
                yearOfProduction = integer;
            }
        }
        public int checkInt() => yearOfProduction; 

        public void WriteAll() 
        {
            Console.WriteLine($"{CarName}, {yearOfProduction}, {mileage}");
        }
    }
}