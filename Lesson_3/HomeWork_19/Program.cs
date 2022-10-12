Console.Write("Введите пятизначное число: ");
string numStr = Console.ReadLine() ?? "";
int firstNum = 0;
int endNum = numStr.Length - 1;


if (endNum == 4)
{
    while (firstNum < endNum && Char.IsDigit(numStr[firstNum]) && Char.IsDigit(numStr[endNum]))
    {
        if (numStr[firstNum] == numStr[endNum])
        {
            firstNum++;
            endNum = endNum - 1;
        }
        else
        {
            Console.WriteLine($"число {numStr} -> не палиндром");
            firstNum = 5;
        }
    }
    if (firstNum == 2) Console.WriteLine($"число {numStr} -> палиндром");
    if (firstNum != 2 && firstNum != 5) Console.WriteLine($"{numStr} - не верный ввод");
}
else Console.WriteLine("Значение не пятизначное, попробуйте снова");


strIsNum(numStr);

void strIsNum(string Str)
{
    int Num;
    bool isNum = int.TryParse(Str, out Num);

    if (isNum)
    {
    
    }
    else
    {
        Console.WriteLine("Это НЕ число, попробуйте снова");
    }
}