using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter another number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int sum = Convert.ToInt32(num1 + num2);
    int diff = Convert.ToInt32(num1 - num2);
    int product = Convert.ToInt32(num2 * num1);
    int quotient = Convert.ToInt32(num1 / num2);
    int remainder = Convert.ToInt32(num1 % num2);


    Console.WriteLine("Sum = " + sum);
    Console.WriteLine("Diff = " + diff);
    Console.WriteLine("Product = " + product);
    Console.WriteLine("Quotient = " + quotient);
    Console.WriteLine("Remainder = " + remainder);
  }
}