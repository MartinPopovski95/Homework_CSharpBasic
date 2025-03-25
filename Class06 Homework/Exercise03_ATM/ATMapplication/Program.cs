

using ATMapplication;
using System.Runtime.CompilerServices;

Customer[] customers = new Customer[0];

while (true)
{
    Console.WriteLine("Welcome to the ATM app");
    Console.WriteLine("Please enter your card number (xxxx-xxxx-xxxx-xxxx):");
    string cardInput = Console.ReadLine();

    long cardNumber;
    if (!TryParseCardNumber(cardInput, out cardNumber))
    {
        Console.WriteLine("Invalid card number format");
        continue;
    }

    Customer customer = GetCustomerByCardNumber(cardNumber);

    if (customer == null)
    {
        Console.WriteLine("Card not found! Do you want to register? (y/n):");
        string answer = Console.ReadLine();
        if(answer.ToLower() == "y")
        {
            RegisterCustomer(cardNumber);
        }
        continue;
    }

    Console.WriteLine("Enter your PIN:");
    string pinInput = Console.ReadLine();
    int pin;

    if(!int.TryParse(pinInput, out pin))
    {
        Console.WriteLine("Invalid PIN format");
        continue;
    }

    if (!customer.Authenticate(pin))
    {
        Console.WriteLine("Incorrect PIN");
        continue;
    }

    Console.WriteLine($"Welcome {customer.FullName}");

    bool keepGoing = true;
    while (keepGoing)
    {
        Console.WriteLine("\nChoose an action:");
        Console.WriteLine("Select (1-3):");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Cash Withdraw");
        Console.WriteLine("3. Cash Deposit");

        string choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
                Console.WriteLine($"Your current balance is: {customer.GetBalance()}");
                break;
            case "2":
                Console.WriteLine("Enter amount to withdraw:");
                string withdrawInput = Console.ReadLine();
                decimal withdrawAmount;
                if (decimal.TryParse(withdrawInput, out withdrawAmount))
                {
                    if (customer.Withdraw(withdrawAmount))
                    {
                        Console.WriteLine($"You withdrew {withdrawAmount}.\nRemaining balance: {customer.GetBalance()}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount");
                }
                break;
            case "3":
                Console.WriteLine("Enter amount to deposit:");
                string depositInput = Console.ReadLine();
                decimal depositAmount;
                if(decimal.TryParse(depositInput, out depositAmount))
                {
                    customer.Deposit(depositAmount);
                    Console.WriteLine($"You deposited {depositAmount}.\nNew balance: {customer.GetBalance()}");
                }
                else
                {
                    Console.WriteLine("Invalid amount");
                }
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }

        Console.WriteLine("Do you want to perform another action (y/n):");
        string again = Console.ReadLine();
        if (again.ToLower() != "y")
        {
            keepGoing = false;
        }
    }

    Console.WriteLine("Thank you for using the ATM app!");
}

bool TryParseCardNumber(string input, out long cardNumber)
{
    cardNumber = 0;
    string numberOnly = "";

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] >= '0' && input[i] <= '9')
        {
            numberOnly += input[i];
        }
        else if (input[i] != '-')
        {
            return false;
        }
    }
    return long.TryParse(numberOnly, out cardNumber);
}

Customer GetCustomerByCardNumber(long cardNumber)
{
    for (int i = 0; i < customers.Length; i++)
    {
        if(customers[i].CardNumber == cardNumber)
        {
            return customers[i];
        }
    }
    return null;
}

void RegisterCustomer(long cardNumber)
{
    Console.WriteLine("Enter your full name:");
    string fullName = Console.ReadLine();

    Console.WriteLine("Set a 4 - digit PIN:");
    string pinInput = Console.ReadLine();
    int pin;

    if (string.IsNullOrEmpty(fullName) || !int.TryParse(pinInput, out pin) || pinInput.Length != 4)
    {
        Console.WriteLine("Invalid input. Registration failed");
        return;
    }

    Customer newCustomer = new Customer(fullName, cardNumber, pin, 0);
    AddCustomer(newCustomer);
    Console.WriteLine("Registration successful!");
}

void AddCustomer(Customer customer)
{
    int newLength = customers.Length + 1;
    Array.Resize(ref customers, newLength);
    customers[newLength - 1] = customer;
}
