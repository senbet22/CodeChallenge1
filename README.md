# CodeChallenge1

A C# / .NET console solution with three tasks completed as part of a backend programming course (Kodehode). Each task is structured as its own project within a shared `.slnx` solution.

---

## Tasks

### Task 1 – Variables
Declares and prints variables of the following types to the console:
- `string`
- `int`
- `double`
- `char`
- `bool`

### Task 2 – Calculator
A simple calculator implemented as a `Calculator` class with the following methods:
- `Add(double a, double b)`
- `Subtract(double a, double b)`
- `Multiply(double a, double b)`
- `Divide(double a, double b)`

User input is handled via the console with `if-else` / `switch` logic to select the desired operation.

### Task 3 – Collections
Demonstrates the use of C# collection types:
- **Array** – stores values of mixed types (`string`, `int`, `double`)
- **List** – e.g. `List<string>`
- **Dictionary** – e.g. `Dictionary<string, string>`

All collections are printed to the console using `for` and `foreach` loops.

---

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (version 10 or later recommended)

---

## How to run

Clone the repository:
```bash
git clone https://github.com/senbet22/CodeChallenge1.git
cd CodeChallenge1
```

Run a specific task:
```bash
cd Task1
dotnet run
```
```bash
cd Task2
dotnet run
```
```bash
cd Task3
dotnet run
```
