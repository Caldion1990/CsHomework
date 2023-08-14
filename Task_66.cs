// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8  -> 30

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Sum(int m, int n)
{
    if (m == n) return 0;
    return n += Sum(m, n - 1);
}
int sum = Sum(m - 1, n);
Console.WriteLine($"Сумма элементов в промежутке от {M} до {N} = {sum}");
