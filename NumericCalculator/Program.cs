int number1;
int number2;

Console.WriteLine("Please, type the first number: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You've selected " + number1 + " as your first number.");

Console.WriteLine("Please, type the second number: ");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You've selected " + number2 + " as your second number.");

int result = number1 * number2;
Console.WriteLine("The result of the operation: " + number1 + "*" + number2 + " is " + result);