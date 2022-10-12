int aX, aY, aZ, bX, bY, bZ;

aX = Koords("Введите координату Х первого числа: ");
aY = Koords("Введите координату Y первого числа: ");
aZ = Koords("Введите координату Z первого числа: ");
bX = Koords("Введите координату Х второго числа: ");
bY = Koords("Введите координату Y второго числа: ");
bZ = Koords("Введите координату Z второго числа: ");

double distanse = Distanse(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine(distanse);

static int Koords(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int aX, int aY, int aZ, int bX, int bY, int bZ)
{
    double result = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2));
    return result;
}