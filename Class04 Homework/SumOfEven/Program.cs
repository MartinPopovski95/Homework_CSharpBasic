//## Task 1
//using static System.Net.Mime.MediaTypeNames;
//using System.Diagnostics.Metrics;

//Make a console application called 
//4. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:
//*Test Data:
//*Enter integer no.1:
//    *4
//  * Enter integer no.2:
//    *3
//  * Enter integer no.3:
//    *7
//  * Enter integer no.4:
//    *3
//  * Enter integer no.5:
//    *2
//  * Enter integer no.6:
//    *8
//* Expected Output:
//*The result is: 14

int[] arrayOfInts = new int[6];

int promptCounter = 1;
int result = 0;

for(int i = 0; i < arrayOfInts.Length; i++)
{
    Console.WriteLine($"Enter intiger no.{promptCounter++}:");
    bool success = int.TryParse(Console.ReadLine(), out int numberInput);

    if (success)
    {
        arrayOfInts[i] = numberInput;

        if (numberInput % 2 == 0)
        {
            result += numberInput;
        }
        else
        {
            continue;
        }
    }
    else
    {
        Console.WriteLine("Invalid input! Please enter a valid number");
        i--;
        promptCounter--;
    }

}

Console.WriteLine($"The result is: {result}");
