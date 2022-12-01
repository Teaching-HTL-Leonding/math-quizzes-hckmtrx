const string ENTER_OPERAND = "Enter the {0} operand: ";

Console.Write(ENTER_OPERAND, "first");
double firstOperand = double.Parse(Console.ReadLine()!);

Console.Write(ENTER_OPERAND, "second");
double secondOperand = double.Parse(Console.ReadLine()!);

Console.Write("Enter the result: ");
double result = double.Parse(Console.ReadLine()!);

string operand = "+";
string firstSecond = firstOperand + " {0} " + secondOperand + " = " + result;
string secondFirst = secondOperand + " {0} " + firstOperand + " = " + result;

if (firstOperand + secondOperand == result) { Console.WriteLine(firstSecond, operand); }

operand = "-";
if (firstOperand - secondOperand == result) { Console.WriteLine(firstSecond, operand); }
if (secondOperand - firstOperand == result) { Console.WriteLine(secondFirst, operand); }

operand = "*";
if (firstOperand * secondOperand == result) { Console.WriteLine(firstSecond, operand); }

operand = "/";
if (Math.Round(firstOperand / secondOperand, 2) == result) { Console.WriteLine(firstSecond, operand); }
if (Math.Round(secondOperand / firstOperand, 2) == result) { Console.WriteLine(secondFirst, operand); }

operand = "^";
if (Math.Pow(firstOperand, secondOperand) == result) { Console.WriteLine(firstSecond, operand); }
if (Math.Pow(secondOperand, firstOperand) == result && firstOperand != secondOperand) { Console.WriteLine(secondFirst, operand); }

operand = "%";
if (firstOperand % secondOperand == result) { Console.WriteLine(firstSecond, operand); }
if (secondOperand % firstOperand == result) { Console.WriteLine(secondFirst, operand); }