/*Задача 2: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
X > 0, Y > 0
2 => X < 0, Y > 0*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
bool Check(int quarter)
{
    if (quarter > 4 || quarter < 1)
    {
        System.Console.WriteLine("Такой четверти нет");
        return false;
    }
    return true;
}
string Getrange(int quarter)
{
    if (quarter == 1)
    {
        return "x > 0 && y > 0";
    }
    if (quarter == 2)
    {
        return "x < 0 && y > 0";
    }
     if (quarter == 3)
    {
        return "x < 0 && y < 0";
    }
    return "x > 0 && y < 0";
}
int quarter = ReadInt("Введите четверть => ");
if (Check(quarter))
{
    System.Console.WriteLine(Getrange(quarter));
}