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
            Console.WriteLine("5. Kilometres to Miles");
            Console.WriteLine("6. Miles to Kilometres");
            Console.WriteLine("7. Celsius to Fahrenheit");
            Console.WriteLine("8. Fahrenheit to Celsius");
            Console.WriteLine("9. GHS TO USD");
            Console.WriteLine("10. Exit");
            Console.WriteLine("======================================================================");

            Console.Write("Enter your choice (1-10): ");
            string choice = Console.ReadLine();

            if(choice == "10")
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
                         ReadNumber("Enter the first number: ", out double num1);
                         ReadNumber("Enter the second number: ", out double num2);
                        double result = 0;

                        if(choice == "1")
                        {
                            result = Calculator.Add(num1 ,num2);
                            Console.WriteLine($"The result of addition is {result}");
                        }
                        else if (choice == "2")
                        {
                            result = Calculator.Subtract(num1, num2);
                            Console.WriteLine($"The result of subtraction is: {result}");
                        }
                        else if(choice == "3")
                        {
                            result = Calculator.Multiply(num1,num2);
                            Console.WriteLine($"The result of multiplication is {result}");
                        }
                        else if (choice == "4")
                        {
                            if(num2 != 0)
                            {
                                double results = Calculator.Divide(num1, num2);
                                Console.WriteLine($"The result of divison is {results}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                        }
                        break;

                    }
                    case "5":
                    {
                        if(!ReadNumber("Enter value in kilometers: ", out double km))
                        {
                            isRunning = false;
                            break;
                        }
                        double miles = UnitConvertor.KilometersToMiles(km);
                        Console.WriteLine($"{km} km = {miles:F2} miles");
                        break;
                    }
                    case "6":
                    {
                        if (!ReadNumber("Enter value in miles: ", out double miles))
                        {
                            isRunning = false;
                            break;
                            
                        }
                        double kilometers = UnitConvertor.MilesToKilometers(miles);
                        Console.WriteLine($"{miles} miles = {kilometers:F2} Kilometers");
                        break;
                    }
                    case "7":
                    {
                        if (!ReadNumber("Enter a value in Celsuis: ", out double celsuis))
                        {
                             isRunning = false;
                            break;
                        }
                        double fahrenheit = UnitConvertor.CelsuisToFahrenheit(celsuis);
                        Console.WriteLine($"{celsuis} celsuis = {fahrenheit:F2} fahrenheit");
                        break;
                    }
                    case "8":
                    {
                        if(!ReadNumber("Enter a value in Fahrenheit: ", out double fahrenheit))
                        {
                            isRunning = false;
                            break;
                        }
                        double celsuis = UnitConvertor.FahrenheitToCelsuis(fahrenheit);
                        Console.WriteLine($"{fahrenheit} fahrenheit = {celsuis:F2} fahrenheit");
                        break;
                    }
                    case "9":
                    {
                        if (!ReadDecimal("Enter Amount in GHS: " , out decimal ghs))
                        {
                            isRunning =  false;
                            break;
                        }
                        if (!ReadDecimal("Enter exhange rate (GHS per 1 USD): ", out decimal rate))
                        {
                            isRunning = false;
                            break;
                        }
                        try
                        {
                            decimal usd = UnitConvertor.GhsToUsd(ghs, rate);
                            Console.WriteLine($"{ghs} GHS = {usd:F2} USD");
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        break;
                    }
                   
            }

            Console.WriteLine();

        }
    }

   
   private static bool ReadNumber(string prompt, out double value)
    {
        value = 0;
        while(true)
        {Console.Write(prompt);
        string? input = Console.ReadLine();
        if (input == null)
            {
                return false;
            } ;
        if(double.TryParse(input, out value))
            {
                return true;
            }
            
        Console.WriteLine("Invalid input. Please enter a valid number.");}
        
    }
   
   private static bool ReadDecimal(string prompt, out decimal value)
    {
        value = 0;
        while(true)
        {Console.Write(prompt);
        string? input =Console.ReadLine();
        if(input ==  null)
            {
                return false;
            }
        if(decimal.TryParse(input, out value))
            {
                return true;
            }
        Console.WriteLine("Invalid input. Please enter a valid number.");}
    }
}