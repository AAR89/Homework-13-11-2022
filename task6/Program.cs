// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли
// число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double x = 2;

double res = a % x;

if (res > 0)
{
    Console.Write("-> Нет");
}
else
{
    Console.Write("-> Да");
}
