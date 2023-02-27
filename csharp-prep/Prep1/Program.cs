using System;

class Program
{
      Console.WriteLine("What is your first given name?");
        string first = Console.ReadLine();

        Console.WriteLine("what is your surname?");
        string last = Console.ReadLine();

        Console.Write($"your full name is {last}, {first} {last}.");
    }
}
