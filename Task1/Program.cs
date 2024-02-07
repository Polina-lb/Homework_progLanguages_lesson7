//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
void OutputNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}  ");
        return;
    }
    else if (m < n)
    {
        Console.Write($"{m}  ");
        OutputNumbers(m + 1, n);
    }
    else if (m > n)
    {
        Console.Write($"{m}  ");
        OutputNumbers(m - 1, n);
    }
}
Console.WriteLine("Введите натуральное число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
OutputNumbers(m, n);