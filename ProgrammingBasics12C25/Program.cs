using System.Runtime.CompilerServices;

namespace ProgrammingBasics12C25
{
    internal class Program
    {
        struct Town
        {
            public string TownName;
            public int Population;
            public double Area;
            public string County;

            public Town(string name,int pop,double tArea,string tCounty)
            {
                this.TownName = name;
                this.Population = pop;
                this.Area = tArea;
                this.County = tCounty;
            }
        }
        static void Main(string[] args)
        {
            // This is a comment
            // Integer - Whole number
            // (-2,147,483,648 to 2,147,483,647)
            int myIntValue;
            myIntValue = 42;

            int anotherIntValue = 64;
            Console.WriteLine(myIntValue);

            // real 
            float myFloat = 0.3F;
            decimal myDecimal = 1.23456m;
            double myDouble = 1.9876543;

            // Boolean
            bool myBoolean = false;
            myBoolean = true;
            myBoolean = !myBoolean; //flips the boolean value

            // Character
            char myChar = 'A';
            char anotherChar;
            anotherChar = '*';

            // String
            string myString = "This is a string";
            string myString2;
            myString2 = "";

            // Date/Time
            DateTime myDateTime = DateTime.Now;
            Console.WriteLine(myDateTime);
            Console.WriteLine(myDateTime.Year);
            Console.WriteLine(myDateTime.Month);
            Console.WriteLine(myDateTime.Day);
            Console.WriteLine(myDateTime.Hour);
            Console.WriteLine(myDateTime.Minute);
            Console.WriteLine(myDateTime.Second);
            Console.WriteLine(myDateTime.Millisecond);

            //pointer/reference
            // not safe in C#
            // int* ptr = &x;

            // records
            // structure are defined outside the main program
            Town myTown = new Town();
            myTown.TownName = "Heckmondwike";
            myTown.Area = 35.4;
            myTown.Population = 12;
            myTown.County = "West Yorkshire";
            Console.WriteLine(myTown.TownName);
            Town anotherTown = new Town("Batley", 50, 12, "West Yorkshire");

            // array
            string[] words = { "this", "is", "an", "array", "of", "strings" };

            int[] nums = new int[10];
            nums[0] = 5;
            nums[9] = 24;
            // nums[10] = 30; index 10 does not exist

            // variable declaration
            // datatype identifier (= value)
            int aNum = 42;
            string aString;
            // constant declaration
            // const datatype identifier = value
            const int theAnswer = 42;

            // Assignment
            // variable = value
            aString = "I am assigning this value to a variable";



        }
    }
}
