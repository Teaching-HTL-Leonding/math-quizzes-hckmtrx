const string ENTER_NUMBER = "Enter the {0} number: ";

Console.Write(ENTER_NUMBER, "first");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write(ENTER_NUMBER, "second");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.Write(ENTER_NUMBER, "third");
int thirdNumber = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= firstNumber; i++)
{
    Console.Write(i % secondNumber == 0 && i % thirdNumber == 0 ? "FizzBuzz" : i % secondNumber == 0 ? "Fizz" : i % thirdNumber == 0 ? "Buzz" : i.ToString());
    Console.Write(" ");
}