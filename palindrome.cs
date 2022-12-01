Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
int originalNumber = number;

int numberLength = 1;
while (number % 10 != number) { numberLength++; number /= 10; }

int numberReversed = 0;
number = originalNumber;
for (int i = 1; i <= numberLength; i++)
{
    numberReversed += (number % 10) * (int)Math.Pow(10, numberLength - i);
    number /= 10;
}

Console.Write("The number is");
Console.Write(originalNumber == numberReversed ? "" : " not");
Console.Write(" a palindrome");