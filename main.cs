using System;

class MainClass {
  public static void Main (string[] args) {
    int firstNumber, secondNumber, thirdNumber;

    Console.Write("Choose a number: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Choose a second number: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Choose a third number: ");
    thirdNumber = Convert.ToInt32(Console.ReadLine());

    if (thirdNumber < firstNumber && thirdNumber < secondNumber)
    {
      Console.WriteLine("You have entered " + thirdNumber + " which is lower than " + firstNumber + " and " + secondNumber);
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
    {
      Console.WriteLine("You have entered " + thirdNumber + " which is greater than " + firstNumber + " and " + secondNumber);
    }
    else
    {
      Console.WriteLine("You have entered " + thirdNumber + " which is between " + firstNumber + " and " + secondNumber);
    }
  }
}