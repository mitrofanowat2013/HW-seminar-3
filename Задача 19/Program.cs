// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int t = Convert.ToInt32(Console.ReadLine());
string r = Convert.ToString(t);
while (r.Length!=5)
{
    Console.Write($"??? {r.Length}\nВведите пятизначное число: ");
    t = Convert.ToInt32(Console.ReadLine());
    r = Convert.ToString(t);
}

if ((r[0] == r[4]) & (r[1] == r[3]))
    Console.WriteLine($"Число {t} -> да");
else
    Console.WriteLine($"Число {t} -> нет");