Console.Write("Введите любое число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(numberThree);
int numDigit = numStr.Length;

if (numDigit > 2)
{
     Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
}

else 
{
    Console.WriteLine("Третьей цифры нет");
}




