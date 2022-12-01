﻿int firstNumber = LetUserEnterNumber("first");
int secondNumber = LetUserEnterNumber("second");
int thirdNumber = LetUserEnterNumber("third");

for (int i = 1; i <= firstNumber; i++)
{
    Console.Write(i % secondNumber == 0 && i % thirdNumber == 0 ? "FizzBuzz" : i % secondNumber == 0 ? "Fizz" : i % thirdNumber == 0 ? "Buzz" : i.ToString());
    Console.Write(" ");
}

int LetUserEnterNumber(string nthNumber)
{
    Console.Write($"Enter the {nthNumber} number: ");
    return int.Parse(Console.ReadLine()!);
}