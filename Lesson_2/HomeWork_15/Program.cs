Console.Write("Введите число от 1 до 7: ");
int numberDayWeek = Convert.ToInt32(Console.ReadLine());

if (numberDayWeek >= 1 && numberDayWeek <= 7)
{
    if (numberDayWeek == 6 | numberDayWeek == 7) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Сегодня рабочий день");
}
else Console.WriteLine("Не верное число");