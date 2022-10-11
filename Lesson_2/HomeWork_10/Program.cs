Console.Write("Введите трёхзначное число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

for (int ii = 1; ii < 3 && (numberTwo <= 100 | numberTwo > 999); ii++)
{
    Console.Write(ii + " Упс, ERROR 400! Введите трёхзначное число : ");
    numberTwo = Convert.ToInt32(Console.ReadLine());
}
if (numberTwo <= 100 | numberTwo > 999)
{
    Console.WriteLine("Данные не корректны, попробуйте позже: ");
}

numberTwo = numberTwo / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {numberTwo}");
