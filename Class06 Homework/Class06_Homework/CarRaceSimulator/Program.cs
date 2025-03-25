
using CarRaceSimulator;

Car[] cars = new Car[]
{
    new Car("Hyundai", 120),
    new Car("Mazda", 130),
    new Car("Ferrari", 200),
    new Car("Porsche", 220),
};

Driver[] drivers = new Driver[]
{
    new Driver("Bob", 3),
    new Driver("Greg", 4),
    new Driver("Jill", 2),
    new Driver("Anne", 5)
};

bool raceAgain = true;

while (raceAgain)
{
    Console.WriteLine("Choose a car no.1:");
    Car car1 = SelectCar(cars);

    Console.WriteLine("Choose a driver for car no.1:");
    car1.Driver = SelectDriver(drivers);

    Car[] remainingCars = new Car[cars.Length - 1];
    int index = 0;

    foreach (Car car in cars)
    {
        if (car != car1)
        {
            remainingCars[index++] = car;
        }
    }

    Console.WriteLine("Choose a car no.2:");
    Car car2 = SelectCar(remainingCars);

    Driver[] remainingDrivers = new Driver[drivers.Length - 1];
    int driverIndex = 0;

    foreach (Driver driver in drivers)
    {
        if (driver != car1.Driver)
        {
            remainingDrivers[driverIndex++] = driver;
        }
    }

    Console.WriteLine("Choose a driver for car no.2:");
    car2.Driver = SelectDriver(remainingDrivers);

    RaceCars(car1, car2);

    Console.WriteLine("\nDo you want to race again? (Y/N)");
    raceAgain = Console.ReadLine().Trim().ToLower() == "y";
}

Car SelectCar(Car[] carArray)
{
    for (int i = 0; i < carArray.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {carArray[i].Model}");
    }

    int choice = ReadChoice(carArray.Length);
    return carArray[choice - 1];
}

Driver SelectDriver(Driver[] driverArray)
{
    for (int i = 0; i < driverArray.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {driverArray[i].Name}");
    }

    int choice = ReadChoice(driverArray.Length);
    return driverArray[choice - 1];
}

int ReadChoice(int maxOption)
{
    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > maxOption)
    {
        Console.WriteLine($"Invalid choice. Enter a number between 1 and {maxOption}:");
    }
    return choice;
}

void RaceCars(Car car1, Car car2)
{   
    int speed1 = car1.CalculateSpeed();
    int speed2 = car2.CalculateSpeed();

    Console.WriteLine($"\n{car1.Model} driven by {car1.Driver.Name} speed: {car1.Speed}");
    Console.WriteLine($"\n{car2.Model} driven by {car2.Driver.Name} speed: {car2.Speed}");

    if (speed1 > speed2)
    {
        Console.WriteLine($"\nThe winner is {car1.Model} driven {car1.Driver.Name} with a result of {speed1} points");
    }
    else if (speed1 < speed2)
    {
        Console.WriteLine($"\nThe winner is {car2.Model} driven {car2.Driver.Name} with a result of {speed2} points");
    }
    else
    {
        Console.WriteLine("\nIt's a tie!");
    }
}
