//## Task 1
//using System.Diagnostics.Metrics;

//Create new console application called“RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
//* Test Data:
//  *Enter the First number: 10
//  * Enter the Second number: 15
//  * Enter the Operation: +
//*Expected Output:
//*The result is: 25

int result = 0;

Console.WriteLine("Please enter the first number:");
bool successFirstNumber = int.TryParse(Console.ReadLine(), out int firstNumber);

if (!successFirstNumber)
{
    Console.WriteLine("Please enter a valid number");
    return;
}

Console.WriteLine("Please enter the second number:");
bool successSecondNumber = int.TryParse(Console.ReadLine(), out int secondNumber);

if (!successSecondNumber)
{
    Console.WriteLine("Please enter a valid number");
    return;
}

Console.WriteLine("Please enter the operation ( +, - , * , / )");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        if (secondNumber == 0)
        {
            Console.WriteLine("Division by zero is not allowed");
            return;
        }
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("Please enter a valid operator ( +, - , * , / )");
        return;
}

Console.WriteLine($"\nThe result is: {result}");