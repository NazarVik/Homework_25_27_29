// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DataEntry(string str)
{
    Console.Write(str);
    int number  = int.Parse(Console.ReadLine());
    return number;
}

double Exponentiate(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.Clear();
int number = DataEntry("введите число  = ");
int level = DataEntry("введите степень  = ");
double result = Exponentiate(number, level);

Console.WriteLine($"{number}, {level} -> {result}");