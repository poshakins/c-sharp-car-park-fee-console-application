
using System;

class CarParkFeeCalculator
{
    static void Main(string[] args)
    {
        const double firstHour = 500.00;//this is the actual price of the car for the first hour
        const double eachSubsequentHour = 100.00;//this is the subsequent rate of the car per hour

        // get User input variables
        Console.Write("Enter Car Model: ");
        string carModel = Console.ReadLine();

        Console.Write("Enter Plate Number: ");
        string plateNumber = Console.ReadLine();

        Console.Write("Enter Number of Hours Parked: ");
        int hoursParked = int.Parse(Console.ReadLine());

        // Calculate parking fee for the car
        //the 500 is not part of the subsequent price its the fixed price
        //if i spent 5 hr to pack my car the first hour will be remove from the hours so am left with 4hrs
        double remaingHoursParked = hoursParked - 1
        double totalParkingFee = firstHour + (eachSubsequentHour * remaingHoursParked);

        // Display result
        Console.WriteLine($"\nCar Model: {carModel}");
        Console.WriteLine($"Plate Number: {plateNumber}");
        Console.WriteLine($"Hours Parked: {hoursParked}");
        Console.WriteLine($"Total Parking Fee:NGN{totalParkingFee:F2}");
    }
}
