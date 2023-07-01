/*Задача 3: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int x1 = ReadInt("Введите x1 =>");
int y1 = ReadInt("Введите y1 =>");
int x2 = ReadInt("Введите x2 =>");
int y2 = ReadInt("Введите y2 =>");
int rangex = x1 - x2;
int rangey = y1 - y2;
double range = Math.Sqrt(rangex*rangex + rangey*rangey);
System.Console.WriteLine($"Расстояние между координатами равно {range}");
