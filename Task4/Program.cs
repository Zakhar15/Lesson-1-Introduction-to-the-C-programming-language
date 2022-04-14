int number1, number2, number3, max;
number1 = 10;
number2 = 8;
number3 = 60;
max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);