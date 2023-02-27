using System;

class program

static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int correctnumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != correctnumber)
        {
            Console.Write("Guess a number between 1 and 101");
            guess = int.Parse(Console.ReadLine());

            if (correctnumber > guess)
            {
                Console.WriteLine("Number is higher");
            }
            else if (correctnumber < guess)
            {
                Console.WriteLine("Number is lower");
            }
            else
            {
                Console.WriteLine("Correct!");
            }

        }                    
    }
}
