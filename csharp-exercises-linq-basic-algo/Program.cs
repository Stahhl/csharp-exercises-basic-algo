using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_exercices_basic_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Choose module: ");
            bool value = Int32.TryParse(Console.ReadLine(), out int number);
            if (value == true)
            {
                ChooseModule(number);
            }
            if (value == false)
            {
                Console.WriteLine("Error: Enter a whole number");
                Main(null);
            }
        }
        static void RestartModule(int number)
        {
            Console.WriteLine("Något gick fel! Press any key to restart!");
            Console.ReadKey();
            ChooseModule(number);

        }
        static void Restart()
        {
            Console.WriteLine("\n\n------------------------------");
            Console.WriteLine("Press 'Enter' to restart: ");
            Console.Read();
            Main(null);
        }
        static void Template()
        {
            //
            Console.Clear();
            Console.WriteLine("Module - Zero: ");
            int myNumber = 0;

            try
            {

            }
            catch
            {
                RestartModule(myNumber);
            }

            Restart();
        }
        static void ChooseModule(int number)
        {
            switch (number)
            {
                case 1:
                    One();
                    break;
                case 2:
                    Two();
                    break;
                case 3:
                    Three();
                    break;
                case 4:
                    Four();
                    break;
                case 5:
                    Five();
                    break;
                case 6:
                    Six();
                    break;
                case 7:
                    Seven();
                    break;
                case 8:
                    Eight();
                    break;
                case 9:
                    Nine();
                    break;
                case 10:
                    Ten();
                    break;
                case 11:
                    Eleven();
                    break;
                case 12:
                    Twelve();
                    break;
                case 13:
                    Thirteen();
                    break;
                case 14:
                    Fourteen();
                    break;
                case 15:
                    Fifteen();
                    break;
                case 16:
                    Sixteen();
                    break;
                case 17:
                    Seventeen();
                    break;
                case 18:
                    Eightteen();
                    break;
                case 19:
                    Nineteen();
                    break;
                case 20:
                    Twenty();
                    break;
                case 21:
                    TwentyOne();
                    break;
                case 22:
                    Module_22();
                    break;
                case 23:
                    Module_23();
                    break;
                case 24:
                    Module_24();
                    break;
                case 25:
                    Module_25();
                    break;
                case 26:
                    Module_26();
                    break;
                case 27:
                    Module_27();
                    break;
                case 28:
                    Module_28();
                    break;
                case 29:
                    Module_29();
                    break;
                case 30:
                    Module_30();
                    break;
                case 31:
                    Module_31();
                    break;
                case 32:
                    Module_32();
                    break;
                case 33:
                    Module_33();
                    break;
                case 34:
                    Module_34();
                    break;
                case 35:
                    Module_35();
                    break;
                case 36:
                    Module_36();
                    break;
                case 37:
                    Module_37();
                    break;
                case 38:
                    Module_38();
                    break;
                case 39:
                    Module_39();
                    break;
                case 40:
                    Module_40();
                    break;
                case 41:
                    Module_41();
                    break;
                case 42:
                    Module_42();
                    break;
                case 43:
                    Module_43();
                    break;
                case 44:
                    Module_44();
                    break;
                case 45:
                    Module_45();
                    break;
                case 46:
                    Module_46();
                    break;
                case 47:
                    Module_47();
                    break;
                case 48:
                    Module_48();
                    break;
                case 49:
                    Module_49();
                    break;
                case 50:
                    Module_50();
                    break;
                default:
                    Console.WriteLine("No module: " + number);
                    Main(null);
                    break;
            }
        }
        static void Module_50()
        {
            //Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int c = Int32.Parse(Console.ReadLine());
            bool result = false;

            if (a % 10 == b % 10 || a % 10 == c % 10 || b % 10 == c % 10)
                result = true;

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_49()
        {
            //Write a C# Sharp program to check if three given numbers are in strict increasing order, 
            //such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.
            //However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int c = Int32.Parse(Console.ReadLine());

            bool result = false;
            bool equality = false;

            Console.WriteLine("Is equality allowed (y/n) ?: ");
            if (Console.ReadLine().ToUpper() == "Y")
                equality = true;

            if(equality == false && (a < b && b < c))
            {
                result = true;
            }
            if (equality == true && (a <= b && b <= c))
            {
                result = true;
            }

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_48()
        {
            //Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z. 
            Console.WriteLine("Enter an integer X: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer Y: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer Z: ");
            int z = Int32.Parse(Console.ReadLine());
            bool result = false;

            if (y > x && z > y)
                result = true;

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_47()
        {
            //Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int c = Int32.Parse(Console.ReadLine());
            bool result = false;

            if(a + b == c ||
               a + c == b ||
               b + c == a
               )
            {
                result = true;
            }

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_46()
        {
            //Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". 
            //If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the 
            //string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string.
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine().ToUpper();
            StringBuilder sb = new StringBuilder();

            if (input.StartsWith("F"))
                sb.Append("Fizz");
            if (input.EndsWith("B"))
                sb.Append("Buzz");
            if (sb.Length > 0)
                input = sb.ToString();

            Console.WriteLine("Result: " + input);
            Restart();
        }
        static void Module_45()
        {
            //Write a C# Sharp program to compute the sum of the two given integers. 
            //If one of the given integer value is in the range 10..20 inclusive return 18.
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int b = Int32.Parse(Console.ReadLine());
            int sum = a + b;

            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
                sum = 18;

            Console.WriteLine("Result: " + sum);
            Restart();
        }
        static void Module_44()
        {
            //Write a C# Sharp program to check if a given number is within 2 of a multiple of 10
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            bool result = false;

            if (a % 10 <= 2 || a % 10 >= 8)
                result = true;

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_43()
        {
            //Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            bool result = false;

            if (a % 3 == 0 || a % 7 == 0)
                result = true;
            if (a % 3 == 0 && a % 7 == 0)
                result = false;

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_42()
        {
            //Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            bool result = false;

            if (a % 13 == 0 || a % 13 == 1)
                result = true;

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_41()
        {
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int b = Int32.Parse(Console.ReadLine());
            bool result = false;

            if (a == 5 || b == 5 || a + b == 5 || Math.Abs(a - b) == 5)
                result = true;

            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_40()
        {
            //Write a C# Sharp program to compute the sum of the two given integers. 
            //If the sum is in the range 10..20 inclusive return 30.
            Console.WriteLine("Enter an integer: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int b = Int32.Parse(Console.ReadLine());
            int sum = a + b;

            if (sum >= 10 && sum <= 20)
                sum = 30;

            Console.WriteLine("Result: " + sum);
            Restart();
        }
        static void Module_39()
        {
            //Write a C# Sharp program to check if a triple is presents in an array of integers or not. 4
            //If a value appears three times in a row in an array it is called a triple.
            Console.WriteLine("Enter a string of integers: ");
            string input = Console.ReadLine();
            List<int> intList = new List<int>();
            int[] intArray;
            bool result = false;

            foreach (char c in input)
            {
                intList.Add(Int32.Parse(c.ToString()));
            }
            intArray = intList.ToArray();

            for (int i = 0; i < intArray.Length - 2; i++)
            {
                int value = intArray[i];
                if (intArray[i + 1] == value && intArray[i + 2] == value)
                    result = true;
            }
            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_38()
        {
            //Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. 
            //Also count the situation where the second 5 is actually a 6.
            Console.WriteLine("Enter a string on integers: ");
            string input = Console.ReadLine();
            List<int> intList = new List<int>();
            int[] intArray;
            int count = 0;

            foreach (char c in input)
            {
                intList.Add(Int32.Parse(c.ToString()));
            }
            intArray = intList.ToArray();

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i].Equals(5) && (intArray[i + 1].Equals(5) || intArray[i + 1].Equals(6)))
                    count++;
            }
            Console.WriteLine("Result: " + count);
            Restart();
        }
        static void Module_37()
        {
            //Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string result = string.Empty;
            //0 < x -> 1 loop
            //5 <= x -> 2 loop
            //9 <= x -> 3 loop
            for (int i = 0; i < input.Length; i += 4)
            {
                int c = i + 2;
                int n = 0;

                //n = 1 if c > input.Length
                //n = 2 if c < input.Length
                n += c > input.Length ? 1 : 2;
                //Console.WriteLine($"input.Length = {input.Length} c = {c} n = {n}");
                result += input.Substring(i, n);
            }
            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_36()
        {
            //Write a C# Sharp program to create a new string from a give string 
            //where a specified character have been removed 
            //except starting and ending position of the given string.
            Console.WriteLine("Enter a string of letters: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a char: ");
            string c = Console.ReadLine();

            for (int i = input.Length - 2; i > 0; i--)
            {
                //Console.WriteLine(i + " " + input[i]);
                if(input[i] == c[0])
                {
                    input = input.Remove(i, 1);
                }
            }

            Console.WriteLine(input);
            Restart();
        }
        static void Module_35()
        {
            //Write a C# Sharp program to compare two given strings 
            //and return the number of the positions where they contain the same length 2 substring.
            Console.WriteLine("Mata in en string: ");
            string stringA = Console.ReadLine();
            Console.WriteLine("Mata in en string: ");
            string stringB = Console.ReadLine();

            for (int a = 0; a < stringA.Length; a++)
            {
                if(a + 2 > stringA.Length)
                {
                    Console.WriteLine("Continue A");
                    continue;
                }
                string sa = stringA.Substring(a, 2);
                for (int b = 0; b < stringB.Length; b++)
                {
                    if (a + 2 > stringA.Length)
                    {
                        Console.WriteLine("Continue B");
                        continue;
                    }

                    string sb = stringB.Substring(b, 2);
                    Console.WriteLine(sa + "_" + sb);
                }
                Console.WriteLine();
            }

            Restart();
        }
        static void Module_34()
        {
            //Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
            Console.WriteLine("Enter a string of integers: ");
            string input = Console.ReadLine();
            bool value = false;
            int[] intArray = new int[input.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Int32.Parse(input[i].ToString());
            }

            for (int i = 0; i < intArray.Length - 2; i++)
            {
                if (intArray[i] == 1 && intArray[i + 1] == 2 && intArray[i + 2] == 3)
                    value = true;
            }
            Console.WriteLine("Result: " + value);
            Restart();
        }
        static void Module_33()
        {
            //Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.
            Console.WriteLine("Enter a string of integers: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a integer: ");
            int choice = Int32.Parse(Console.ReadLine());
            bool value = false;

            int[] intArray = new int[4];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Int32.Parse(input[i].ToString());
            }
            if (intArray.Contains(choice) == true)
                value = true;

            Console.WriteLine("Result: " + value);
            Restart();
        }
        static void Module_32()
        {
            //Write a C# Sharp program to check a specified number is present in a given array of integers.
            Console.WriteLine("Enter a string of integers: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a integer: ");
            int choice = Int32.Parse(Console.ReadLine());
            bool value = false;

            int[] intArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intArray[i] = Int32.Parse(input[i].ToString());
            }
            if (intArray.Contains(choice) == true)
                value = true;

            Console.WriteLine("Result: " + value);
            Restart();
        }
        static void Module_31()
        {
            //Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. 
            //Do not count the end substring.
            //abcdeab -> ab---ab -> true
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            bool result = false;
            var last_two_char = input.Substring(input.Length - 2);

            for (int i = 0; i < input.Length - 2; i++)
            {
                if (input.Substring(i, 2).Equals(last_two_char))
                    result = true;
            }
            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_30()
        {
            //Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.
            //Input: abcd
            //Output: a + ab + abc + abcd = aababcabcd
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string result = string.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                result += input.Substring(0, i + 1);
            }
            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_29()
        {
            //Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.
            //Lägg till varannan bokstav i input till en ny string
            Console.WriteLine("Mata in en string: ");
            string input = Console.ReadLine();
            string result = string.Empty;
            for (var i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0) result += input[i];
            }
            Console.WriteLine("Result: " + result);
            Restart();
        }
        static void Module_28()
        {
            //Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
            Console.WriteLine("Mata in en string: ");
            string input = Console.ReadLine();
            //int counter = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                //if (input[i].Equals('a'))
                //    counter++;
                if (input.Substring(i, 2).Equals("aa")/* && counter < 2*/)
                    Console.WriteLine($"aa at {i} and {i + 1}");
            }


            Restart();
        }
        static void Module_27()
        {
            //Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            int nbAA = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Substring(i, 2).ToLower() == "aa")
                    nbAA++;
            }

            Console.WriteLine("Number of 'aa' in string: " + nbAA);

            Restart();
        }
        static void Module_26()
        {
            //Write a C# Sharp program to create a new string which is n (non-negative integer) 
            //copies of the the first 3 characters of a given string. 
            //If the length of the given string is less than 3 then return n copies of the string.

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter number of repeats: ");
            int repeats = Int32.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            if(input.Length < 3)
            {
                for (int i = 0; i < repeats; i++)
                {
                    sb.Append(input);
                }
            }
            if(input.Length >= 3)
            {
                for (int i = 0; i < repeats; i++)
                {
                    sb.Append(input.Substring(0, 3));
                }
            }


            Console.WriteLine("Result: " + sb.ToString());
            Restart();
        }
        static void Module_25()
        {
            //Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string.

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter repates: ");
            int repeat = Int32.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < repeat; i++)
            {
                sb.Append(input);
            }

            Console.WriteLine("Result: " + sb.ToString());

            Restart();
        }
        static void Module_24()
        {
            //Write a C# Sharp program to convert the last 3 characters of a given string in upper case. 
            //If the length of the string has less than 3 then uppercase all the characters.

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string output = "";

            if (input.Length < 3)
            {
                output = input.ToUpper();
            }
            if (input.Length >= 3)
            {
                output = input.Remove(input.Length - 3) + input.Substring(input.Length - 3).ToUpper();

            }
            Console.WriteLine("Result: " + output);
            Restart();
        }
        static void Module_23()
        {
            //Write a C# Sharp program to check if two given non-negative integers have the same last digit.
            Console.WriteLine("Enter an int: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an int: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nResult: " + (Math.Abs(a % 10) == Math.Abs(b % 10)));
            //If true a and b has the same last digit

            Restart();
        }
        static void Module_22()
        {
            //Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            int nbZ = 0;

            foreach (char c in input)
            {
                if (char.ToUpper(c) == 'Z')
                    nbZ++;
            }
            Console.WriteLine("Result: " + (nbZ > 1 && nbZ < 4));
            Restart();
        }
        static void TwentyOne()
        {
            //Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, 
            //or return 0 if neither is in that range.
            Console.Clear();
            Console.WriteLine("Module - Zero: ");
            int myNumber = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            try
            {
                Console.WriteLine("Mata in ett heltal: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mata in ett heltal: ");
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if ((a >= 20 && a <= 30) && (b >= 20 && b <= 30))
            {
                c = Math.Max(a, b);
            }

            Console.WriteLine("Result: " + c);

            Restart();
        }
        static void Twenty()
        {
            //Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, 
            //or they are both in the range 50..60 inclusive.
            Console.Clear();
            Console.WriteLine("Module - Twenty: ");
            int myNumber = 20;
            int a = 0;
            int b = 0;
            string result = "neither";

            try
            {
                Console.WriteLine("Mata in et heltal: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mata in et heltal: ");
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if ((a >= 40 && a <= 50) && (b >= 40 && b <= 50))
            {
                result = "40 to 50";
            }
            if ((a >= 50 && a <= 60) && (b >= 50 && b <= 60))
            {
                result = "50 to 60";
            }

            Console.WriteLine("Result: " + result);

            Restart();
        }
        static void Nineteen()
        {
            //Write a C# Sharp program to check which number nearest to the value 100 among two given integers. 
            //Return 0 if the two numbers are equal.
            Console.Clear();
            Console.WriteLine("Module - Nineteen: ");
            int myNumber = 19;
            int a = 0;
            int b = 0;
            int c = 0;

            try
            {
                Console.WriteLine("Mata in ett heltal: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mata in ett heltal: ");
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            int abs1 = Math.Abs(100 - a);
            int abs2 = Math.Abs(100 - b);

            if (abs1 > abs2)
            {
                //b is closer
                c = b;
            }
            if (abs1 < abs2)
            {
                //a is closer
                c = a;
            }

            Console.WriteLine("Result: {0} is closest to 100", c);

            Restart();
        }
        static void Eightteen()
        {
            //Write a C# Sharp program to check the largest number among three given integers. 
            Console.Clear();
            Console.WriteLine("Module - Zero: ");
            int myNumber = 0;
            List<int> numbers = new List<int>();

            try
            {
                Console.WriteLine("Mata in ett heltal: ");
                numbers.Add(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("Mata in ett heltal: ");
                numbers.Add(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("Mata in ett heltal: ");
                numbers.Add(Int32.Parse(Console.ReadLine()));
            }
            catch
            {
                RestartModule(myNumber);
            }

            numbers.Sort();

            Console.WriteLine("Largest number is: " + numbers[numbers.Count - 1]);

            Restart();
        }
        static void Seventeen()
        {
            // Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
            // If it appears return a string without 'yt' otherwise return the original string.
            Console.Clear();
            Console.WriteLine("Module - Seventeen: ");
            int myNumber = 17;
            string word = "";

            try
            {
                Console.WriteLine("Mata in en string: ");
                word = Console.ReadLine().ToLower();
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (word.Length > 2 && word[1] == 'y' && word[2] == 't')
            {
                word = word.Remove(1, 2);
            }

            Console.WriteLine("Result: " + word);

            Restart();
        }
        static void Sixteen()
        {
            //Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. 
            //Return true if 1 or other is in the said range otherwise false.
            Console.Clear();
            Console.WriteLine("Module - Sixteen: ");
            int myNumber = 16;
            bool value = false;
            int a = 0;
            int b = 0;

            try
            {
                Console.WriteLine("Mata in ett heltal: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mata in ett heltal: ");
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if ((a >= 20 && a <= 50) || (b >= 20 && b <= 50))
                value = true;

            Console.WriteLine("Result: " + value);

            Restart();
        }
        static void Fifteen()
        {
            //Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. 
            //Return true if 1 or more of them are in the said range otherwise false.
            Console.Clear();
            Console.WriteLine("Module - Zero: ");
            int myNumber = 0;
            bool value = false;
            int a = 0;
            int b = 0;
            int c = 0;

            try
            {
                Console.WriteLine("Mata in ett heltal: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mata in ett heltal: ");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mata in ett heltal: ");
                c = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if ((a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50))
                value = true;

            Console.WriteLine("Result: " + value);

            Restart();
        }
        static void Fourteen()
        {
            //Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
            Console.Clear();
            Console.WriteLine("Module - Fourteen: ");
            int myNumber = 14;
            int a = 0;
            int b = 0;
            bool value = false;

            try
            {
                Console.WriteLine("Mata in ett heltal: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mata in ett heltal: ");
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if ((a >= 100 && a <= 200) || (b >= 100 && b <= 200))
                value = true;

            Console.WriteLine("Result: " + value);

            Restart();
        }
        static void Thirteen()
        {
            //Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
            Console.Clear();
            Console.WriteLine("Module - Thirteen: ");
            int myNumber = 13;
            double temp1 = 0;
            double temp2 = 0;
            bool value = false;

            try
            {
                Console.WriteLine("Mata in en temperatur: ");
                temp1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Mata in en temperatur: ");
                temp2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (temp1 < 0 && temp2 > 100)
                value = true;
            if (temp1 > 100 && temp2 < 0)
                value = true;

            Console.WriteLine("Result: " + value);

            Restart();
        }
        static void Twelve()
        {
            //Write a C# Sharp program to check if a given string starts with 'C#' or not.
            Console.Clear();
            Console.WriteLine("Module - Twelve: ");
            int myNumber = 12;
            string word = "";
            bool value = false;

            try
            {
                Console.WriteLine("Mata in en string: ");
                word = Console.ReadLine().ToUpper();
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (word.Length >= 2 && word[0] == 'C' && word[1] == '#')
            {
                value = true;
            }

            Console.WriteLine("Result: " + value);

            Restart();
        }
        static void Eleven()
        {
            //Write a C# Sharp program to create a new string taking the first 3 characters of a given string 
            //and return the string with the 3 characters added at both the front and back. 
            //If the given string length is less than 3, use whatever characters are there.
            Console.Clear();
            Console.WriteLine("Module - Eleven: ");
            int myNumber = 11;
            string word = "";

            try
            {
                Console.WriteLine("Mata in en string: ");
                word = Console.ReadLine();
            }
            catch
            {
                RestartModule(myNumber);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                if (i >= word.Length)
                    break;

                sb.Append(word[i]);
            }

            string three = sb.ToString();

            sb = new StringBuilder();

            sb.Append(three);
            sb.Append(word);
            sb.Append(three);

            word = sb.ToString();
            Console.WriteLine("Result: " + word);
            Restart();
        }
        static void Ten()
        {
            //Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
            Console.Clear();
            Console.WriteLine("Module - Ten: ");
            int myNumber = 10;
            int number = 0;

            try
            {
                Console.WriteLine("Mata in en positiv siffra: ");
                number = Int32.Parse(Console.ReadLine());
                if (number <= 0)
                    RestartModule(myNumber);
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (number % 3 == 0)
            {
                Console.WriteLine("Result: multiple of 3");
            }
            if (number % 7 == 0)
            {
                Console.WriteLine("Result: multiple of 7");
            }
            if (number % 3 != 0 && number % 7 != 0)
            {
                Console.WriteLine("Result: not multiple of 3 or 7");
            }

            Restart();
        }
        static void Nine()
        {
            //Write a C# Sharp program to create a new string with the last char 
            //added at the front and back of a given string of length 1 or more.
            Console.Clear();
            Console.WriteLine("Module - Nine: ");
            int myNumber = 9;
            string word = "";

            try
            {
                Console.WriteLine("Mata in en string: ");
                word = Console.ReadLine();
                if (word.Length < 1)
                    RestartModule(myNumber);
            }
            catch
            {
                RestartModule(myNumber);
            }

            StringBuilder sb = new StringBuilder();
            char c = word[word.Length - 1];
            sb.Append(c);
            sb.Append(word);
            sb.Append(c);

            word = sb.ToString();
            Console.WriteLine("Result: " + word);

            Restart();
        }
        static void Eight()
        {
            // Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. 
            //If the given string length is less than 2 return the original string.
            Console.Clear();
            Console.WriteLine("Module - Eight: ");
            int myNumber = 8;
            string word = "";

            try
            {
                Console.WriteLine("Mata in ett ord: ");
                word = Console.ReadLine();
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (word.Length > 2)
            {
                char a = word[0];
                char b = word[1];
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 4; i++)
                {
                    sb.Append(a);
                    sb.Append(b);
                }
                word = sb.ToString();
            }
            Console.WriteLine("Result: " + word);
            Restart();
        }
        static void Seven()
        {
            //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
            Console.Clear();
            Console.WriteLine("Module - Seven: ");
            int myNumber = 7;
            string word = "";

            try
            {
                Console.WriteLine("Mata in ett ord: ");
                word = Console.ReadLine();
                if (word.Length < 2)
                    RestartModule(myNumber);
            }
            catch
            {
                RestartModule(myNumber);
            }

            char a = word[0];
            char b = word[word.Length - 1];

            StringBuilder sb = new StringBuilder(word);
            sb[0] = b;
            sb[sb.Length - 1] = a;

            word = sb.ToString();

            Console.WriteLine("Result: " + word);

            Restart();
        }
        static void Six()
        {
            //Write a C# Sharp program to remove the character in a given position of a given string. 
            //The given position will be in the range 0.. string length -1 inclusive.
            Console.Clear();
            Console.WriteLine("Module - Six: ");
            int myNumber = 6;
            string word = "";
            int pos = 0;

            try
            {
                Console.WriteLine("Mata in en string: ");
                word = Console.ReadLine();
                Console.WriteLine("Mata in en siffra motsvarande en bokstav i order: ");
                pos = Int32.Parse(Console.ReadLine());
                if (pos > word.Length)
                    RestartModule(myNumber);
            }
            catch
            {
                RestartModule(myNumber);
            }

            word = word.Remove(pos, 1);

            Console.WriteLine("Result: " + word);

            Restart();
        }
        static void Five()
        {
            //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
            //If the string already begins with 'if', return the string unchanged.
            Console.Clear();
            Console.WriteLine("Module - Five: ");
            int myNumber = 5;
            string s = "";

            try
            {
                Console.WriteLine("Slå in en string (minst två tecken): ");
                s = Console.ReadLine().ToLower();
                if (s.Length < 2)
                    RestartModule(myNumber);
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (s[0] == 'i' && s[1] == 'f')
            {
                Console.WriteLine($"Result: {s}");
            }
            else
            {
                s = string.Format("if " + s);
                Console.WriteLine($"Result: {s}");
            }

            Restart();
        }
        static void Four()
        {
            //Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
            Console.Clear();
            Console.WriteLine("Module - Four: ");
            int myNumber = 4;
            bool value = false;
            int a = 0;

            try
            {
                Console.WriteLine("Slå in en siffra: ");
                a = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (a > 90 && a < 110)
                value = true;
            if (a > 190 && a < 210)
                value = true;

            Console.WriteLine("Result: " + value);
            Restart();
        }
        static void Three()
        {
            //Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
            Console.Clear();
            Console.WriteLine("Module - Three: ");
            int myNumber = 3;
            int a = 0;
            int b = 0;
            bool value = false;
            int max = 30;

            try
            {
                Console.WriteLine("Slå in en siffra: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Slå in en siffra: ");
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (a == max || b == max || (a + b) == max)
                value = true;

            Console.WriteLine("Result: " + value);
            Restart();
        }
        static void Two()
        {
            //Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
            Console.Clear();
            Console.WriteLine("Module - Two: ");
            int myNumber = 2;
            int x = 51;
            int n = 0;

            try
            {
                Console.WriteLine("Slå in en siffra: ");
                n = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }
            if (n > x)
            {
                Console.WriteLine($"({x} - {n}) * 3 = {(x - n) * 3}");
            }
            else
            {
                Console.WriteLine($"({x} - {n}) * 3 = {x - n}");
            }
            Restart();
        }
        static void One()
        {
            //Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
            Console.Clear();
            Console.WriteLine("Module - One: ");
            int myNumber = 1;
            int a = 0;
            int b = 0;
            try
            {
                Console.WriteLine("Slå in en siffra: ");
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                RestartModule(myNumber);
            }

            if (a != b)
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            if (a == b)
            {
                Console.WriteLine($"({a} + {b}) * 3 = {(a + b) * 3}");
            }
            Restart();
        }
    }
}
