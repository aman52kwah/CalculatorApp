internal class Program
{
    private static void Main(string [] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("========== Hello, welcome to the calculator program ! ===========");
            Console.WriteLine("Please select an operation from the following options");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Unit Conversion");
            Console.WriteLine("6. Exit");
            Console.WriteLine("======================================================================");

            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();

            if(choice == "6")
            {
                isRunning = false;
                Console.WriteLine("Goodbye!");
                break;
            }
            switch (choice)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    {
                        double num1 = ReadNumber("Enter the first number: ");
                        double num2 = ReadNumber("Enter the second number: ");
                        double result = 0;

                        if(choice == "1")
                        {
                            result = num1 + num2;
                            Console.WriteLine($"The result of addition is {result}");
                        }
                        else if (choice == "2")
                        {
                            result = num1 - num2;
                            Console.WriteLine($"The result of subtraction is: {result}");
                        }
                        else if(choice == "3")
                        {
                            result = num1 * num2;
                            Console.WriteLine($"The result of multiplication is {result}");
                        }
                        else if (choice == " 4")
                        {
                            if(num2!= 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine($"The result of divison is {result}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                        }
                        break;

                    }
                    case "5":
                    RunUnitConversion();
                    break;
                    default:
                    Console.WriteLine("Invalid choice. Please select a valid operation (1-6).");
            }

            Console.WriteLine();

        }
    }

    private static void RunUnitConversion()
    {
        Console.WriteLine("\n-- Unit Conversion --");
        Console.WriteLine("1. Kilometres to Miles");
        Console.WriteLine("2. Celsius <-> Miles ");
        Console.WriteLine("3. GHS -> USD ");
        Console.WriteLine("Choose a conversion (1-3): " );
        string subChoice = Console.ReadLine();
        //double value = ReadNumber("Enter value: ");

        if(subChoice == "1")
        {
            
            Console.WriteLine("1. Kilometres to Miles");
            Console.WriteLine("2. Miles to Kilometres");
            string dir = Console.ReadLine();

            double value = ReadNumber("Enter value: ");

            if(dir == "1")
            {
                double result = value / 1.60934;
                Console.WriteLine($"{value} km = {result:F2} miles");
            }
            else if(dir == "2")
            {
                double result = value * 1.60934;
                Console.WriteLine($"{value} miles = {result:F2} km");
            }
            else
            {
                Console.WriteLine("Invalid direcrion.");
            }
        }
        else if (subChoice == "2")
        {
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit  to Celsius ");
            Console.Write("Choose direction: ");
            string dir = Console.ReadLine();

            double value = ReadNumber("Enter value: ");

            if (dir == "1")
            {
                double result = value * 9 / 5 + 32;
                Console.WriteLine($"{value}°C = {result:F2}°F ");
            }
            else if (dir == "2")
            {
                double result = (value - 32) * 5 / 9;
                Console.WriteLine($"{value}°F = {result:F2}°C");
            }
            else
            {
                Console.WriteLine("Invalid direction. ");
            }

        }
         
        {
            double result = value * 1.60934;
            Console.WriteLine($"{value} miles = {result:F2} km");
        }
        else
        {
            Console.WriteLine("Invalid direction.");
        }
    }
   
}