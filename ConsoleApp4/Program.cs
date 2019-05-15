using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string personStatus = "robot";
            
            switch (personStatus)
            {
                case "human":
                    Console.WriteLine("You're a human, go ahead.");
                    break;
                case "robot":
                    Console.WriteLine("No robots allowed, buddy!");
                    break;
                default:
                    Console.WriteLine("Uhhh, I'm not sure about cyborgs. Let me grab my manager..");
                    break;

            }

            Console.WriteLine("How many moons does Earth have?");
            String response = Console.ReadLine();

            if(response.ToLower().Equals("1"))
            {
                Console.WriteLine("Good work.");
            }

            string roboCop = "Your move, creep.";
            int roboCopLength = roboCop.Length;
            Console.WriteLine($"{roboCop} has {roboCop.Length} characters");
            



        }
    }
}
