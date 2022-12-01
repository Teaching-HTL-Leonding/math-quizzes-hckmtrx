const string ENTER_NUMBER = "Enter the {0} number: ";

Console.Write(ENTER_NUMBER, "first");
int n = int.Parse(Console.ReadLine()!);
int firstNumber = n;

Console.Write(ENTER_NUMBER, "second");
int o = int.Parse(Console.ReadLine()!);
int secondNumber = o;

int lengthFirstNumber = 1;
int lengthSecondNumber = 1;
while (n > 1 || o > 1)
{
    if (n > 1) { lengthFirstNumber++; n = n % 2 == 0 ? n / 2 : 3 * n + 1; }
    if (o > 1) { lengthSecondNumber++; o = o % 2 == 0 ? o / 2 : 3 * o + 1; }
}

if (lengthFirstNumber == lengthSecondNumber) { Console.WriteLine("The length of the Hailstone sequence of these two numbers is the same"); }
else { Console.WriteLine("The number {0} has the longer Hailstone sequence", lengthFirstNumber > lengthSecondNumber ? firstNumber : secondNumber); }