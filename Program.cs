using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: First the users name
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is your favorite hobby? ");
            string hobby = Console.ReadLine();

            // Step 2: A decorative border will appear
            string border = new string('*', 40);
            Console.WriteLine(border);

            // Step 3: You'll get a personalized greeting
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"It's awesome that you enjoy {hobby}, {name}. {hobby} sounds like a very cool hobby to have indeed.");

            // Step 4: Fun fact about the name you've entered
            Console.WriteLine($"Did you know the name you entered before, contains {name.Length} letters?");

            // Step 5: Creative Twist – ASCII Art Pattern
            Console.WriteLine("\nHere’s a unqiue growing pattern that's inspired by your most favorite of hobbies:");
            for (int i = 1; i <= hobby.Length; i++)
            {
                Console.WriteLine(new string(hobby[0], i)); // Prints the first letter of the hobby you typed in a growing pattern that based on how many letters your hobby has
            }

            // Step 6: Another twist – A silly calculation the programs will tell you
            int score = (name.Length * hobby.Length) % 100;
            Console.WriteLine($"\nYour secret compatibility score with {hobby} is: {score}%!");

            // A edit by Bailey May. Asks you your favorite food.
            Console.Write("What is your favorite food?");
            string food = Console.ReadLine(); 
            Console.WriteLine("{food}? Sounds delicious! {food} is my favorite food too!");

            

            // Closing border
            Console.WriteLine(border);
        }
    }
}


