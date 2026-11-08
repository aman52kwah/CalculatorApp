# CalculatorApp

A .NET console calculator that also includes a unit converter. It handles basic arithmetic and unit conversions with input validation so wrong input won't crash the program.

## Features

**Calculator**
1. Addition
2. Subtraction
3. Multiplication
4. Division (guards against division by zero)

**Unit Conversion**
1. Kilometres <-> Miles
2. Celsius <-> Fahrenheit
3. GHS -> USD (you supply the exchange rate)

**Safety**
- Every numeric input uses `double.TryParse`, so letters or empty input will not crash the app — the program asks again instead.

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

## How to Use

When the program starts, you will see a menu:

```
========== Hello, welcome to the calculator program ! ===========
Please select an operation from the following options
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Unit Conversion
6. Exit
======================================================================
Enter your choice (1-6): 
```

### Basic Calculations (options 1–4)

Pick an option, then enter two numbers when prompted. The result is displayed immediately.

Example:
```
Enter your choice (1-6): 1
Enter the first number: 10
Enter the second number: 5
The result of addition is 15
```

Division by zero is caught:
```
Enter your choice (1-6): 4
Enter the first number: 10
Enter the second number: 0
Error: Division by zero is not allowed.
```

### Unit Conversion (option 5)

Pick option 5, then choose a conversion type:

```
--- Unit Conversion ---
1. Kilometres to Miles
2. Celsius <-> Fahrenheit
3. GHS -> USD
Choose a conversion (1-3): 
```

**Kilometres <-> Miles**
- Choose direction (1 = km to miles, 2 = miles to km)
- Enter the value
- Result shows both units

**Celsius <-> Fahrenheit**
- Choose direction (1 = °C to °F, 2 = °F to °C)
- Enter the value
- Result shows both units

**GHS -> USD**
- Enter amount in GHS
- Enter the exchange rate (GHS per 1 USD)
- Result shows the USD equivalent

### Exit (option 6)

Choosing 6 closes the program.

## Example Session

```
dotnet run
========== Hello, welcome to the calculator program ! ===========
Please select an operation from the following options
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Unit Conversion
6. Exit
======================================================================
Enter your choice (1-6): 5

--- Unit Conversion ---
1. Kilometres to Miles
2. Celsius <-> Fahrenheit
3. GHS -> USD
Choose a conversion (1-3): 3
Enter amount in GHS: 600
enter exchange rate (GHS per 1 USD): 15
600 GHS = 40.00 USD
```

## File Structure

```
CalculatorApp/
├── Program.cs        # Main source code
├── CalculatorApp.csproj # Project file (.NET 11 console app)
├── README.md         # This file
├── bin/              # Build output (generated)
└── obj/              # Intermediate build files (generated)
```

## Notes

- The program loops until you select **6. Exit**, so you can perform multiple operations without restarting.
- If you enter non-numeric text where a number is expected, the program prints "Invalid input. Please enter a valid number." and prompts again instead of crashing.