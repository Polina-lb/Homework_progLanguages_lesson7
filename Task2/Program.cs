// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int CalcAckermann(int n, int m)
{
    if (n==0)
    {
        return m+1;
    }
    else if (m==0)
    {
        return CalcAckermann(n-1, 1);
    }
    else{
        int result = CalcAckermann(n-1, CalcAckermann(n, m-1));
        return result;
    }
}
int resultCalcAckermann = CalcAckermann(3,2);
Console.WriteLine(resultCalcAckermann);