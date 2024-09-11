
int numOne;
int numTwo;
bool playAgain = true;
string breakLine = "------------------------------------------------------------------------";

Console.Clear();

while (playAgain)
{
    Console.WriteLine(breakLine);
    Console.WriteLine("Today we are going to be checking numbers against each other to see if they are:");
    Console.WriteLine("GREATER THAN OR LESS THAN!!!!!!!!!!!!!!!");
    Console.WriteLine(breakLine);

    Console.WriteLine("Please enter your first number.");
    bool isNum1 = Int32.TryParse(Console.ReadLine(), out numOne);
    Console.WriteLine("Please enter your second number.");
    bool isNum2 = Int32.TryParse(Console.ReadLine(), out numTwo);

    while (true)
    {
        if (!isNum1 || !isNum2)
        {
            Console.Clear();
            Console.WriteLine("One or both of those are not numbers. Try again.");
            Console.WriteLine("Please enter your first number.");
            isNum1 = Int32.TryParse(Console.ReadLine(), out numOne);
            Console.WriteLine("Please enter your second number.");
            isNum2 = Int32.TryParse(Console.ReadLine(), out numTwo);


        }
        else if (numOne < numTwo)
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine($"{numOne} is less than {numTwo}");
            Console.WriteLine($"{numTwo} is greater than {numOne}");
            Console.WriteLine(breakLine);
            break;
        }
        else if (numOne > numTwo)
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine($"{numOne} is greater than {numTwo}");
            Console.WriteLine($"{numTwo} is less than {numOne}");
            Console.WriteLine(breakLine);
            break;
        }
        else if (numOne == numTwo)
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine($"{numOne} is equal to {numTwo}");
            Console.WriteLine(breakLine);
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("not sure how you got here");
            Console.WriteLine(breakLine);
        }
    }
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("Type 'yes' to play again or 'no' to exit the program.");

    bool yesNO = true;
    while (yesNO == true)
    {
        string? userInput = Console.ReadLine();
        if (userInput?.ToLower() == "yes")
        {
            Console.Clear();
            Console.WriteLine("Awesome, let's go again!");
            yesNO = false;
        }
        else if (userInput?.ToLower() == "no")
        {
            Console.Clear();
            Console.WriteLine("Alright, see ya later!");
            yesNO = false;
            playAgain = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("That was not a 'yes' or 'no'. Try again.");

        }

    }

}