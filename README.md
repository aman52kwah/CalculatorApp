# CalculatorApp

A .NET console calculator that also includes a unit converter. It handles basic arithmetic and unit conversions with input validation so wrong input won't crash the app.

## Project Structure

```
CalculatorApp/
├── Program.cs              # Main entry point with flat menu
├── Calculator.cs           # Basic arithmetic operations
├── UnitConverter.cs        # Unit conversion operations
├── CalculatorApp.csproj    # Main project file (.NET 11 console app)
├── CalculatorApp.Tests/    # xUnit test project
│   ├── CalculatorApp.Tests.csproj
│   ├── CalculatorTests.cs
│   └── UnitConverterTests.cs
├── README.md               # This file
├── .gitignore              # Standard .NET gitignore
├── bin/                    # Build output (generated, ignored)
└── obj/                    # Intermediate build files (generated, ignored)
```

## Features

### Calculator

1. Addition
2. Subtraction
3. Multiplication
4. Division (guards against division by zero)

### Unit Conversion (flat menu — no nested sub-menus)

5. Kilometres to Miles (uses `1.609344` km per mile)
6. Miles to Kilometres
7. Celsius to Fahrenheit
8. Fahrenheit to Celsius
9. GHS to USD (uses `decimal` for money; exchange rate must be greater than zero)

### Exit

10. Exit

### Safety

- Every numeric input uses `double.TryParse` (or `decimal.TryParse` for money), so letters or empty input will not crash the app — the program asks again instead.
- If the input stream ends (stdin closed), the program exits gracefully instead of looping forever.
- Division by zero is caught and reported.
- Exchange rates of zero or negative values are rejected for GHS to USD.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed (the project targets `net11.0`).

## How to Run

### Option 1: Run directly from source

Open a terminal in the project folder (`/Users/mike/Desktop/CalculatorApp`) and run:

```bash
dotnet run
```

### Option 2: Build then run

```bash
dotnet build
dotnet run
```

Or build an executable:

```bash
dotnet publish -c Release -o ./publish
./publish/CalculatorApp
```

## How to Run Tests

The project includes an xUnit test project under `CalculatorApp.Tests/`. To run all tests:

```bash
cd CalculatorApp.Tests
dotnet test
```

## How to Use

When the program starts, you will see a flat menu:

```
========== Hello, welcome to the calculator program ! ===========
Please select an operation from the following options
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Kilometres to Miles
6. Miles to Kilometres
7. Celsius to Fahrenheit
8. Fahrenheit to Celsius
9. GHS to USD
10. Exit
======================================================================
Enter your choice (1-10): 
```

### Basic Calculations (options 1–4)

Pick an option, then enter two numbers when prompted. The result is displayed immediately.

Example:
```
Enter your choice (1-10): 1
Enter the first number: 10
Enter the second number: 5
The result of addition is 15
```

Division by zero is caught:
```
Enter your choice (1-10): 4
Enter the first number: 10
Enter the second number: 0
Error: Division by zero is not allowed.
```

### Unit Conversion (options 5–9)

Pick an option, then enter the value when prompted.

**Kilometres <-> Miles** (options 5 and 6)
- Enter the value
- Result shows both units

**Celsius <-> Fahrenheit** (options 7 and 8)
- Enter the value
- Result shows both units

**GHS -> USD** (option 9)
- Enter amount in GHS
- Enter the exchange rate (GHS per 1 USD). Must be greater than zero.
- Result shows the USD equivalent

Example:
```
Enter your choice (1-10): 9
Enter amount in GHS: 600
Enter exchange rate (GHS per 1 USD): 15
600 GHS = 40.00 USD
```

### Exit (option 10)

Choosing 10 closes the program.

## Example Session

```
dotnet run
========== Hello, welcome to the calculator program ! ===========
Please select an operation from the following options
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Kilometres to Miles
6. Miles to Kilometres
7. Celsius to Fahrenheit
8. Fahrenheit to Celsius
9. GHS to USD
10. Exit
======================================================================
Enter your choice (1-10): 1
Enter the first number: 10
Enter the second number: 5
The result of addition is 15

Enter your choice (1-10): 9
Enter amount in GHS: 600
Enter exchange rate (GHS per 1 USD): 15
600 GHS = 40.00 USD

Enter your choice (1-10): 10
Goodbye!
```

## Notes

- The program loops until you select **10. Exit**, so you can perform multiple operations without restarting.
- If you enter non-numeric text where a number is expected, the program prints "Invalid input. Please enter a valid number." and prompts again instead of crashing.
- Build output (`bin/`, `obj/`, `publish/`) and macOS `.DS_Store` files are ignored by `.gitignore` and not tracked in Git.
