using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int random_number = random.Next(1, 100);
             //  int guess ;
            int guesses_number = 0;
            int max_guess = 8;

            Console.WriteLine("welcome to guessing number\n");
            Console.WriteLine("try to guess the right number it's between 1 and 100 ");

            do
            {
                Console.Write("enter your guess:");
                int guess=Convert.ToInt32(Console.ReadLine());
                guesses_number++;

                if (guess < random_number)
                {
                    Console.WriteLine("too low ,try again!");
                }
                else if (guess > random_number)
                {
                    Console.WriteLine("too High, try again");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in { guesses_number}");
                }

            }
            while (max_guess > guesses_number);
            
                if (guesses_number == max_guess) {
                Console.WriteLine($"your gusses is over ,the right guess is {random_number}");
                }

            
           
        }
    }
   
}