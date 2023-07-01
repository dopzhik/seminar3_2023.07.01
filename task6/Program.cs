/*Задача 6: Напишите программу, которая выводит 
первые заданные элемента следующей последовательности: 
-> 12
1 2 2 3 3 3 4 4 4 4 5 5*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int N = ReadInt("Введите число => ");
Strangeseq(N);
void Strangeseq(int N)
{
    int cnt1 = 1;
    int cnt2 = 1;
    int cnt3 = 0;
    while (cnt1 < N)
    {
        cnt2 = 1;
        while (cnt2 <= cnt1)
        {
            System.Console.WriteLine(cnt1);
            cnt3++;
            if (cnt3 == N)
            {
                return;
            }
            cnt2++;        
        }
        cnt1++;
    }
}
