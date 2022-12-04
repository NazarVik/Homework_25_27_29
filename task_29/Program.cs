// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] EnterArr(int num)
{
    int[] arr = new int[num];
    for(int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(100);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
int[] randomArr = EnterArr(8);
PrintArr(randomArr);