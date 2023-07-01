/*Напишите программу, которая генерирует последовательность случайных чисел из 10 
элементов в диапазоне от 1 до 10, и подсчитывает, 
сколько сгенерировалось чисел больше 5.*/
Random rnd = new Random();
int cnt = 0;
int cnt5 = 0;
while (cnt < 10)
{
    int num = rnd.Next(1, 11);
    System.Console.WriteLine(num);
    if (num > 5)
    {
        cnt5++;
    }
    cnt++;
}
System.Console.WriteLine($"Чисел больше 5 сгенерировалось {cnt5} раз");