# Object-Oriented Programming Concepts in C#

This project demonstrates the core OOP concepts: **Inheritance, Polymorphism, and Abstraction** using C#.

## 1. Inheritance

### Description
- The `Sponsor` class contains a protected variable `owner` initialized to `"Rakuteen"`.
- The `Team` class extends `Sponsor` and uses the inherited `owner` variable in `PrintInfo()`.

### Code Implementation
```csharp
class Sponsor
{
    protected string owner = "Rakuteen";
}

class Team : Sponsor
{
    public string PrintInfo()
    {
        return owner + " Sponsor";
    }
}
```

### Expected Output
```
Rakuteen Sponsor
```

## 2. Polymorphism

### Description
- The `Bird` class has a `Voice()` method that prints `"Turr Turr"`.
- The `Duck` class extends `Bird` and overrides `Voice()` to print `"Quack Quack"`.
- A `Bird` reference is used to store a `Duck` object, demonstrating **method overriding**.

### Code Implementation
```csharp
class Bird
{
    public virtual void Voice()
    {
        Console.WriteLine("Turr Turr");
    }
}

class Duck : Bird
{
    public override void Voice()
    {
        Console.WriteLine("Quack Quack");
    }
}
```

### Expected Output
```
Turr Turr
Quack Quack
```

## 3. Abstraction

### Description
- The `Laptop` class has private variables `brand` and `model`.
- Public properties `Brand` and `Model` allow access to these private members.
- The `LaptopDetails()` method prints brand and model details.
- The private method `MotherBoardInfo()` cannot be accessed outside the class.

### Code Implementation
```csharp
class Laptop
{
    private string brand;
    private string model;

    public string Brand { get; set; }
    public string Model { get; set; }

    public void LaptopDetails()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
    }

    private void MotherBoardInfo()
    {
        Console.WriteLine("MotherBoard Information");
    }
}
```

### Expected Output
```
Brand: Dell
Model: XPS 15
```

> **Note:** Attempting to call `MotherBoardInfo()` from `Main()` will result in a compilation error because it is a private method.

## How to Run the Program
1. Copy and paste the code into a C# Console Application.
2. Run the `Main()` method.
3. Observe the output for each OOP concept.

## Conclusion
This practical demonstrates how **inheritance**, **polymorphism**, and **abstraction** are implemented in C#. By following these concepts, you can build scalable and maintainable object-oriented applications.
