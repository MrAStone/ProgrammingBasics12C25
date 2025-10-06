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

            public Town(string name, int pop, double tArea, string tCounty)
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

            // selection
            // Uses if
            // if(criteria){code}
            if (aNum != 42)
            {
                Console.WriteLine("not 42");
            }

            if(aNum < 40)
            {
                Console.WriteLine("less than 40");
            }
            else
            {
                Console.WriteLine("Not less than 40");
            }

            if (aNum >= 50)
            {
                Console.WriteLine("Greater than or equal to 50");
            }
            else if(aNum < 30)
            {
                Console.WriteLine("less than 30");
            }
            else
            {
                Console.WriteLine("Between 30 and 50");
            }

            switch (aNum)
            {
                case 42:
                    Console.WriteLine("42");
                    break;
                case 43:
                    Console.WriteLine("43");
                    break;
                case > 50:
                    Console.WriteLine("Over 50");
                    break;
                default:
                    Console.WriteLine("None of the above");
                    break;
            }

            bool isItTrue = true;
            if (!isItTrue)
            {
                Console.WriteLine("no");
            }


            // iteration
            // definite iteration

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for(int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            string test = "HELLO WORLD";
            for(int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
        }
    }
}
