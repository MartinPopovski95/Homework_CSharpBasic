//## Task 2

//Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.
//* Test Data:
//  *Enter the First number: 10
//  * Enter the Second number: 15
//  * Enter the third number: 20
//  * Enter the four number: 30
//* Expected Output:
//*The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Please enter the first number");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Please enter the second number");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Please enter the third number");
bool thirdSuccess = int.TryParse(Console.ReadLine(), out int thirdNumber);

Console.WriteLine("Please enter the fourth number");
bool fourthSuccess = int.TryParse(Console.ReadLine(), out int fourthNumber);

int result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
Console.WriteLine($"The average is: {result}");