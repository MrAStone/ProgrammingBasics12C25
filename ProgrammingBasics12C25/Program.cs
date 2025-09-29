using System.Runtime.CompilerServices;

namespace ProgrammingBasics12C25
{
    internal class Program
    {
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


        }
    }
}
