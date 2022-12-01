int number1 = 999, number2 = 999;

int largestPalindrom = 0, largestPalindromNum1 = 0, largestPalindromNum2 = 0;

for (int i = 0; i <= number1; i++)
{
    for (int j = 0; j <= number2; j++)
    {
        int number = i * j;
        int originalNumber = number;

        int numberLength = 1;
        while (number % 10 != number) { numberLength++; number /= 10; }

        int numberReversed = 0;
        number = originalNumber;
        for (int k = 1; k <= numberLength; k++)
        {
            numberReversed += (number % 10) * (int)Math.Pow(10, numberLength - k);
            number /= 10;
        }

        if (originalNumber == numberReversed && originalNumber > largestPalindrom) { largestPalindrom = originalNumber; largestPalindromNum1 = i; largestPalindromNum2 = j; }
    }
}

Console.WriteLine($"The largest palindrom is {largestPalindrom} ({largestPalindromNum1} * {largestPalindromNum2})");