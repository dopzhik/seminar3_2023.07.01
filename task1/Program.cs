// 1. Напишите программу, которая принимает на 
// вход координаты точки (X и Y), причём X ≠ 0 
// или Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.


// Функция ввода целого числа
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}

bool CheckZero(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Одна из координат равна 0");
        return false;
    }
    return true;
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = ReadInt("Введите X > ");
int y = ReadInt("Введите Y > ");
if (CheckZero(x, y))
{
    int quarter = GetQuarter(x, y);
    System.Console.WriteLine($"Номер четверти по координатам ({x}, {y}) равна {quarter}");
}
