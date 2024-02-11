// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintRewerseArr(int[] arr, int i = 1)
{

    if (i == arr.Length)
    {
        Console.Write(arr[arr.Length - i]);
        return;
    }
    Console.Write($"{arr[arr.Length - i]}  ");
    PrintRewerseArr(arr, i + 1);

}

int[] array = { 1, 6, 9, 60, 35, 45, 7 };
PrintRewerseArr(array);