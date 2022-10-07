Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: нечётным");
}
else
{
    Console.WriteLine("Число " + num + " является: чётным");
}