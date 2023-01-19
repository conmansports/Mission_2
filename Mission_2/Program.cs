using System;

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            //Get the amount of rolls from the user
            Console.Write("How many times do you want to role the dice? ");
            string strRoles = Console.ReadLine();
            //Convert roll input to interger
            int numRoles = Int32.Parse(strRoles);

            //Define random generator and define roll total variable
            int[] rollTotals = new int[13];
            Random rnd = new Random();

            //simulates rolling of the dice
            for (int i = 0; i < numRoles; i++)
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);

                int roll_tot = roll1 + roll2;

                rollTotals[roll_tot]++;
            }

            //Print results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = { numRoles }.");

            //Prints the histogram after determining the percentage
            for (int i = 2; i < 13; i++)
            {
                double percentage = (double)rollTotals[i] / numRoles * 100;
                Console.WriteLine($"{ i}: " + new string('*', (int)percentage) );

            }

            //print thank you message
            Console.WriteLine("Thanks for playing!");
        }


    }
}
