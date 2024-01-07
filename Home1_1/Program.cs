Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int number2 = number;
while (number2 > 9)
{
    number2 /= 10;
    i *= 10;
}
while (number > 9)
{
    Console.Write($"{number / i},");
    number %= i;
    i /= 10;
}
Console.Write(number);