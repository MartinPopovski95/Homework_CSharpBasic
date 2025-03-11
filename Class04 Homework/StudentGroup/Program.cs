//## Task 2
//using static System.Net.Mime.MediaTypeNames;
//using System.Diagnostics.Metrics;

//*Make a new console application called StudentGroup
//* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
//* Get a number from the console between 1 and 2 and print the students from that group in the console.
//* Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//* Test Data:
//*Enter student group: (there are 1 and 2 )
//    * 1
//* Expected Output:
//  *The Students in G1 are: 
//  *Zdravko
//  * Petko
//  * Stanko
//  * Branko
//  * Trajko


string[] studentsG1 = new string[] {"Dona", "Martin", "Aston", "Badi", "Nero" };
string[] studentsG2 = new string[] { "Eva", "Zoran", "Oliver", "Beti", "Gordana" };

Console.WriteLine("Enter student group (1 or 2):");
bool success = int.TryParse(Console.ReadLine(), out int userInput);

if (success)
{
    switch (userInput)
    {
        case 1:
            Console.WriteLine("The Students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
                break;
        case 2:
            Console.WriteLine("The Students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
                break;
        default:
            Console.WriteLine("Invalid input!");
            break;
    }
}
else
{
    Console.WriteLine("Invalid input! Please try again");
}