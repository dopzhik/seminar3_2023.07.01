/*Задача 4: Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int N = ReadInt("Введите число => ");
int count = 1;
while (count <= N)
{
    System.Console.WriteLine(count*count);
    count++;
}