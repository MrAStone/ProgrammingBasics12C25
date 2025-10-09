namespace ProgrammingBasics12C25
{
    internal class Program
    {
        // A "struct" (short for structure) is a way to group several related variables into one place.
        // It's like creating your own custom data type. Here, we're making one to hold information about a town.
        struct Town
        {
            // These are the variables, or "fields," that every Town will have.
            public string TownName; // A variable to store the town's name as text.
            public int Population;   // A variable to store the population as a whole number.
            public double Area;       // A variable to store the area, which can be a decimal number.
            public string County;     // A variable to store the county name as text.

            // This is a special method called a "constructor". It makes it easy to create a new Town
            // and set all its values at once.
            public Town(string name, int pop, double tArea, string tCounty)
            {
                // The "this" keyword refers to the current object being created.
                // These lines assign the values passed into the constructor to the fields of the struct.
                this.TownName = name;
                this.Population = pop;
                this.Area = tArea;
                this.County = tCounty;
            }
        }

        // This is the Main method. It's the starting point of every C# console application.
        // When you run your program, the code inside these curly braces {} is the first to execute.
        static void Main(string[] args)
        {
            // A comment starts with //. The computer ignores these lines. They are for humans to read.

            /*
             * VARIABLES AND DATA TYPES
             * A variable is like a named box in the computer's memory where you can store data.
             */

            // ## Integer ## (for whole numbers)
            int myIntValue;    // This "declares" a variable named myIntValue that will hold an integer.
            myIntValue = 42;   // This "assigns" the value 42 to the myIntValue variable.

            // You can also declare and assign a value in a single line.
            int anotherIntValue = 64;

            // Console.WriteLine() prints whatever is in the parentheses to the screen.
            Console.WriteLine(myIntValue); // This will print the number 42.

            // ## Real Numbers ## (for numbers with decimal points)
            float myFloat = 0.3F;       // A 'float' is for decimal numbers. The 'F' is required.
            decimal myDecimal = 1.23456m; // A 'decimal' is for high-precision numbers, like money. The 'm' is required.
            double myDouble = 1.9876543;   // A 'double' is the most common type for decimal numbers.

            // ## Boolean ## (for true or false values)
            bool myBoolean = false; // A 'bool' can only be 'true' or 'false'.
            myBoolean = true;       // You can change its value later.
            myBoolean = !myBoolean; // The '!' symbol means NOT. It flips the value. 'true' becomes 'false'.

            // ## Character ## (for a single letter, number, or symbol)
            char myChar = 'A';      // A 'char' holds a single character. Note the single quotes ''.
            char anotherChar;
            anotherChar = '*';

            // ## String ## (for text)
            string myString = "This is a string"; // A 'string' holds a sequence of characters. Note the double quotes "".
            string myString2;
            myString2 = ""; // An empty string.

            // ## Date/Time ##
            DateTime myDateTime = DateTime.Now; // Gets the current date and time from your computer.
            Console.WriteLine(myDateTime);      // Prints the full date and time.
            Console.WriteLine(myDateTime.Year); // You can get specific parts of the date/time.
            Console.WriteLine(myDateTime.Month);
            Console.WriteLine(myDateTime.Day);
            Console.WriteLine(myDateTime.Hour);
            Console.WriteLine(myDateTime.Minute);
            Console.WriteLine(myDateTime.Second);
            Console.WriteLine(myDateTime.Millisecond);

            // ## Pointer/Reference ##
            // A pointer stores a memory address instead of a value.
            // This is an advanced topic and is generally not used in safe C# code, which is why it's commented out.
            // int* ptr = &x;

            // ## Records (Using our Struct) ##
            // Now we'll use the 'Town' struct we defined earlier.
            Town myTown = new Town(); // Creates a new 'Town' object in memory.
            // We assign values to the fields of our new town one by one.
            myTown.TownName = "Heckmondwike";
            myTown.Area = 35.4;
            myTown.Population = 12;
            myTown.County = "West Yorkshire";
            Console.WriteLine(myTown.TownName); // Prints the name of the town.

            // Here, we create another town using the constructor we made. It's a faster way to set all the values.
            Town anotherTown = new Town("Batley", 50, 12, "West Yorkshire");

            // ## Array ## (A list of items of the same type)
            // This creates an array of strings and fills it with values immediately.
            string[] words = { "this", "is", "an", "array", "of", "strings" };

            // This creates an array that can hold 10 integers, but it's currently empty.
            int[] nums = new int[10];
            // Array positions (called "indexes") start at 0. So the first item is at index 0.
            nums[0] = 5;  // Puts the number 5 in the first position.
            // The last item in a 10-item array is at index 9.
            nums[9] = 24; // Puts 24 in the last position.
            // nums[10] = 30; // This line would cause an error because index 10 doesn't exist (0-9 are the 10 spots).


            /*
             * BASIC PROGRAMMING CONSTRUCTS
             */

            // ## Variable Declaration Recap ##
            // Syntax: datatype identifier (= optional initial value);
            int aNum = 42;
            string aString; // Declared but not yet assigned a value.

            // ## Constant Declaration ##
            // A constant is a variable whose value cannot be changed after it's set.
            const int theAnswer = 42;
            // theAnswer = 43; // This would cause an error.

            // ## Assignment ##
            // This is the process of putting a value into a variable using the = sign.
            aString = "I am assigning this value to a variable";


            // ## Selection ## (Making decisions in code)
            // An 'if' statement runs code only if a certain condition is true.
            // '!=' means "not equal to".
            if (aNum != 42) // Is aNum not equal to 42? (This is false, since aNum is 42).
            {
                // This code will be skipped because the condition was false.
                Console.WriteLine("not 42");
            }

            // An 'if-else' statement provides an alternative path if the 'if' condition is false.
            if (aNum < 40) // Is aNum less than 40? (False).
            {
                Console.WriteLine("less than 40");
            }
            else // Since the 'if' was false, the 'else' block runs.
            {
                Console.WriteLine("Not less than 40");
            }

            // You can chain them together with 'else if' to check multiple conditions.
            if (aNum >= 50) // Is aNum greater than or equal to 50? (False).
            {
                Console.WriteLine("Greater than or equal to 50");
            }
            else if (aNum < 30) // Is aNum less than 30? (False).
            {
                Console.WriteLine("less than 30");
            }
            else // Since all the above were false, this final 'else' runs.
            {
                Console.WriteLine("Between 30 and 50");
            }

            // A 'switch' statement is a clean way to check a variable against a list of possible values.
            switch (aNum)
            {
                case 42: // If aNum is 42...
                    Console.WriteLine("42");
                    break; // The 'break' keyword exits the switch statement. It's required.
                case 43: // If aNum is 43...
                    Console.WriteLine("43");
                    break;
                case > 50: // You can also check for conditions (if aNum is greater than 50...).
                    Console.WriteLine("Over 50");
                    break;
                default: // If none of the above cases match...
                    Console.WriteLine("None of the above");
                    break;
            }

            bool isItTrue = true;
            // The '!' (NOT) operator is useful in conditions.
            if (!isItTrue) // This reads as "if NOT isItTrue" or "if isItTrue is false".
            {
                Console.WriteLine("no");
            }

            // ## Iteration ## (Repeating code using loops)

            // A 'for' loop is used when you want to repeat code a specific number of times.
            // It has three parts:
            // 1. int i = 0;   (Initializer: Runs once at the very beginning)
            // 2. i < 10;       (Condition: Checked before each repetition. The loop continues as long as this is true)
            // 3. i++          (Iterator: Runs at the end of each repetition. i++ means "add 1 to i")
            for (int i = 0; i < 10; i++)
            {
                // This will print the numbers 0 through 9.
                Console.WriteLine(i);
            }

            // A for loop that counts up in steps of 3.
            for (int i = 0; i < 10; i += 3) // i += 3 is shorthand for i = i + 3
            {
                // This will print 0, 3, 6, 9
                Console.WriteLine(i);
            }

            // A for loop that counts down.
            for (int i = 10; i > 0; i--) // i-- is shorthand for i = i - 1
            {
                // This will print 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
                Console.WriteLine(i);
            }

            string test = "HELLO WORLD";
            // You can use a loop to go through each character of a string.
            // test.Length gives you the number of characters in the string.
            for (int i = 0; i < test.Length; i++)
            {
                // test[i] gets the character at the current index 'i'.
                Console.WriteLine(test[i]);
            }
            // This is another 'for' loop, but it's set up to go through the 'test' string backwards.
            // 1. Initializer: int i = test.Length - 1;
            //    Starts the counter 'i' at the index of the LAST character.
            //    (If "HELLO" has length 5, its indexes are 0,1,2,3,4. The last index is Length - 1).
            // 2. Condition: i >= 0;
            //    The loop continues as long as 'i' is a valid index (greater than or equal to 0).
            // 3. Iterator: i--
            //    Decrements 'i' by 1 after each loop, moving backwards through the string.
            for (int i = test.Length - 1; i >= 0; i--)
            {
                // Console.Write() is like Console.WriteLine(), but it DOESN'T add a new line at the end.
                // This will print each character right next to the previous one, reversing the string.
                Console.Write(test[i]);
            }
            // This prints an empty line to the console, just to move the cursor to the next line
            // for any future output.
            Console.WriteLine();

            // The 'foreach' loop is a simpler way to go through every item in a collection (like an array or string).
            // It reads as "for each character 'c' in the string 'test'...".
            // The loop handles getting each item for you.
            foreach (char c in test)
            {
                // This will print each character of the string on its own line.
                Console.WriteLine(c);
            }

            // Here we declare an array of integers.
            int[] arrayOfNums = { 36, 5, 4, 9, 11, 55, 88, 44, 32, 1 };
            // A variable to store a running total, starting at 0.
            int sum = 0;
            // We use a 'foreach' loop to go through each number in our array.
            foreach (int i in arrayOfNums)
            {
                // sum += i; is shorthand for sum = sum + i;
                // It adds the current number ('i') to our running total ('sum').
                sum += i;
            }
            // Here, we calculate the average.
            // Dividing an integer by an integer in C# will discard the decimal part (e.g., 10 / 4 = 2).
            // By multiplying arrayOfNums.Length by 1.0, we temporarily convert it to a 'double' (a decimal number).
            // This forces the entire calculation to be done with decimals, giving a precise average.
            Console.WriteLine(sum / (arrayOfNums.Length * 1.0));

            // ## Nested Loops ##
            // This is a 'for' loop inside another 'for' loop.
            // The outer loop (with 'i') will run 10 times (for i = 0 to 9).
            for (int i = 0; i < 10; i++)
            {
                // This line will print the current value of 'i' (0, then 1, then 2, etc.).
                Console.WriteLine("Outer loop i: " + i);

                // For EACH SINGLE RUN of the outer loop, this inner loop (with 'j') will run completely.
                // It will run 10 times (for j = 0 to 9) before the outer loop moves to its next 'i' value.
                for (int j = 0; j < 10; j++)
                {
                    // This will print the numbers 0-9, ten separate times.
                    Console.WriteLine("  Inner loop j: " + j);
                }
            }

            // ## Condition-Controlled Loops ## (Indefinite Iteration)
            // These loops run as long as a condition is true, not for a fixed number of times.

            // A 'while' loop checks its condition BEFORE running the code inside.
            int x = 1;
            while (x < 10) // "While x is less than 10..."
            {
                // If the condition is true, run this code.
                x++; // Add 1 to x.
            } // Then it goes back to the 'while' line to check the condition again.
              // It stops when x becomes 10, because 10 is not less than 10.
            Console.WriteLine(x); // Will print 10.

            x = 1; // Reset x back to 1 for the next example.

            // A 'do-while' loop runs the code inside ONCE, and then checks the condition.
            // This guarantees the code inside the loop will run at least one time.
            do
            {
                // This code runs first.
                x++; // Add 1 to x.
            } while (x < 10); // Then it checks the condition: "Continue as long as x is less than 10".
            Console.WriteLine(x); // Will also print 10.
        } 
    } 
} 