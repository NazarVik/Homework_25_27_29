// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в 
// числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DataEntry(string str)
{
    Console.Write(str);
    int number  = int.Parse(Console.ReadLine());
    return number;
}
 
int SumOfNumbers(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num = num / 10;        
    }
    return result;
}

Console.Clear();

int number = DataEntry("введите число  = ");
int res = SumOfNumbers(number);

Console.WriteLine($"{number} -> {res}");