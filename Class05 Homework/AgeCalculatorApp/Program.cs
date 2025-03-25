//# Homework Class 4 📒

//## Task
//*Make a method called AgeCalculator
//* The method will have one input parameter, your birthday date
//* The method should return your age
//* Show the age of a user after he inputs a date

//> Note: take into consideration if the birthday is today, after or before today



Console.WriteLine("Enter your birthday (dd.mm.yyyy):");
string input = Console.ReadLine();

if (DateTime.TryParse(input, out DateTime birthday))
{
    int age = AgeCalculator(birthday);

    if (age >= 0)
    {
        Console.WriteLine($"You are {age} years old");
    }
    else
    {
        Console.WriteLine("Birthday cannot be in the future");
    }
}
else
{
    Console.WriteLine("Invalid date format. Please use dd.mm.yyyy");
}




int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;

    if (birthday > today)
    {
        return -1;
    }

    int age = today.Year - birthday.Year;

    if (birthday.Date > today.AddYears(-age))
    {
        age--;
    }

    return age;
}