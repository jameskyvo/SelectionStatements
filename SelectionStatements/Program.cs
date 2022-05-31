var r = new Random();
var favNumber = r.Next(1, 1000);
Console.WriteLine("Hello there! Can you guess my favorite number? It's between 1 and 1,000!");
int userInput;

do
{
    userInput = int.Parse(Console.ReadLine());
    if (userInput > favNumber)
    {
        Console.WriteLine("too high");
    }
    else if (userInput < favNumber)
    {
        Console.WriteLine("too low");
    }
    else if (userInput == favNumber)
    {
        Console.WriteLine("Good job!");
    }
    else
    {
        Console.WriteLine("Nevermind."); // word supplied through assignment, should never execute
    }
} while (userInput != favNumber);