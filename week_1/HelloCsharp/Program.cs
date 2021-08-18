using System;

namespace HelloCsharp
{
  class Program
  {

    //Build a simple calculatorusing 5 methods: Add, Multiply, Subtract, Divide, Print
    static void Main(string[] args)
    {

      makeProblem();

    }

    static void makeProblem()
    {
      Console.WriteLine("Enter first number value: ");
      int value = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Type One!\nInvalid values will be considered 0.\nadd, subtract, multiply, divide, or print: ");
      String operation = Console.ReadLine();

      Console.WriteLine("Enter second number value: ");
      int value2 = Int32.Parse(Console.ReadLine());


      switch (operation)
      {
        case "add":
          Console.WriteLine("Answer: " + Add(value, value2));
          break;

        case "subtract":
          Console.WriteLine("Answer: " + Subtract(value, value2));
          break;

        case "multiply":
          Console.WriteLine("Answer: " + Multiply(value, value2));
          break;

        case "divide":
          Console.WriteLine("Answer: " + Divide(value, value2));
          break;

        case "print":
          Print(value, value2);
          break;

        default:
          Console.WriteLine("Invalid: Try Again!");
          makeProblem();
          break;


      }
    }

    static int Add(int a, int b)
    {
      return a + b;
    }

    static int Subtract(int a, int b)
    {
      return a / b;
    }

    static int Multiply(int a, int b)
    {
      return a * b;
    }

    static int Divide(int a, int b)
    {
      return a / b;
    }

    static void Print(int a, int b)
    {
      Console.WriteLine("Your selections were: " + a + b);
    }
  }
}