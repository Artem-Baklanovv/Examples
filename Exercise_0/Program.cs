Console.Write("Введите первое целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("Первое число " + numA + " больше чем второе " + numB);
}
else
{
    Console.WriteLine("Второе число " + numB + " больше чем первое " + numA);
}