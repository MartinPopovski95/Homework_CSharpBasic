//## Task 3:

//Create new console application called “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:
//*Test Data:
//*Input the First Number: 5
//* Input the Second Number: 8
//* Expected Output:
//*After Swapping:
//*First Number: 8
//* Second Number: 5

Console.WriteLine("Please enter the first number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Please enter the second number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

if (firstSuccess && secondSuccess)
{
    firstNumber = firstNumber + secondNumber;
    secondNumber = firstNumber - secondNumber;
    firstNumber = firstNumber - secondNumber;

    Console.WriteLine("\nAfter swapping:");
    Console.WriteLine("First number: " + firstNumber);
    Console.WriteLine("Second number: " + secondNumber);
}

