
// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

static void PrintLength(int m, int n)
{
    if ( m <= n ) 
    {
        Console.WriteLine("==> " + m);
        PrintLength(++m, n);
    }
    
}

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");

PrintLength(M, N);
