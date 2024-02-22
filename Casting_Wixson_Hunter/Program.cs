using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to input a whole number
        Console.WriteLine("Please enter a whole number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Print out the user's favorite number
        Console.WriteLine("Your favorite number is " + userNumber + "!");

        // Ask the user a yes or no question
        Console.WriteLine("Do you like video games? (Enter 'true' or 'false'):");
        bool isTrue = Convert.ToBoolean(Console.ReadLine());

        // Print out the message based on the user's response
        Console.WriteLine("It is " + isTrue + " that I like video games!");
    }
}
