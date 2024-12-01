# Lab4 Project

## Overview
This solution consists of two projects:
1. **Library Project (VivekK_301311622_COMP367_Lab4)**: Provides utility extensions, including the `StringExtensions` class with a method to check if a string starts with an uppercase letter.
2. **Console Application (Lab4Console)**: A basic console application demonstrating the usage of the library's `StartsWithUppercase` method.

## Projects in the Solution

### 1. Library Project: `VivekK_301311622_COMP367_Lab4`
The library contains reusable utility methods, currently including:
- **`StartsWithUppercase(string str): bool`**  
  Checks if the given string starts with an uppercase letter.

#### Example Usage:
```csharp
using VivekK_301311622_COMP367_Lab4;

class Program
{
    static void Main(string[] args)
    {
        string input = "Hello World";
        bool startsWithUppercase = input.StartsWithUppercase();
        Console.WriteLine(startsWithUppercase ? "Yes, starts with uppercase." : "No, doesn't start with uppercase.");
    }
}
