
// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

static int Akkerman(int M, int N)
{
    
    int result = 0;
    
    if ( M == 0 ) 
    {
        result = N+1;
    }
    else if ( M > 0 && N == 0 )
    {
        result = Akkerman(M-1, 1);
    } 
    else if ( M > 0 && N > 0 )
    {
        result = Akkerman(M-1, Akkerman(M, N-1));
    }

    return result;
    
}

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int A = Akkerman(M, N);

Console.WriteLine("\n> A({0}, {1}) = {2}", M, N, A);
