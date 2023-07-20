
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number (optional):");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            double square = powerMethod(number1);
            Console.WriteLine($"The square of {number1} is: {square}");
        }
        else
        {
            double number2 = double.Parse(input);
            double power = powerMethod(number1, number2);
            Console.WriteLine($"{number1} raised to the power of {number2} is: {power}");
        }
    }

    static double powerMethod(double number1, double counter = 2)
    {
        return Math.Pow(number1, counter);
    }
}
