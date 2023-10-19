namespace IterationStatements
{
    public class Program
    {
        


        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            // Task 1: Print numbers from 1000 to -1000
            PrintNumbersFrom1000ToNegative1000();

            // Task 2: Print numbers from 3 to 999 by 3 each time
            PrintNumbersFrom3To999By3();

            // Task 3: Check if two integers are equal
            CheckEquality(5, 5);

            // Task 4: Check if a number is even or odd
            CheckEvenOrOdd(6);

            // Task 5: Check if a number is positive or negative
            CheckPositiveOrNegative(-10);

            // Task 6: Check if a candidate can vote
            CheckVotingEligibility();

            // Task 7: Check if an integer is in the range -10 to 10
            CheckInRange(-5);

            // Task 8: Display the multiplication table of a given integer
            DisplayMultiplicationTable(7);
            
        }

        // Task 1: Print numbers from 1000 to -1000
        static void PrintNumbersFrom1000ToNegative1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Task 2: Print numbers from 3 to 999 by 3 each time
        static void PrintNumbersFrom3To999By3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // Task 3: Check if two integers are equal
        static void CheckEquality(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("The two integers are equal.");
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
            }
        }

        // Task 4: Check if a number is even or odd
        static void CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }

        // Task 5: Check if a number is positive or negative
        static void CheckPositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Task 6: Check if a candidate can vote
        static void CheckVotingEligibility()
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("You can vote.");
                }
                else
                {
                    Console.WriteLine("You cannot vote.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age input.");
            }
        }

        // Task 7: Check if an integer is in the range -10 to 10
        static void CheckInRange(int number)
        {
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine("The number is in the range -10 to 10.");
            }
            else
            {
                Console.WriteLine("The number is not in the range -10 to 10.");
            }
        }

        // Task 8: Display the multiplication table of a given integer
        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        
        }

    }
}
