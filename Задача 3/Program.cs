
// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

static int[] MakeArray(int x, int leftRange, int rightRange) 
{
    int[] tempArray = new int[x];

    Random rand = new();

    rightRange++;

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange);
    }

    return tempArray;
}

static void PrintArray(int[] arrayForPrint)
{
    int afpLength = arrayForPrint.Length;

    Console.Write("==> ");

    for (int i = 0; i < afpLength; i++)
    {
        
        Console.Write(arrayForPrint[i]);
        if ( i < afpLength - 1 ) { Console.Write(" "); }

    }

}

static void PrintArrayRevers(int[] arrayForPrint, int cnt = 0)
{
    int afpLength = arrayForPrint.Length - 1;

    if ( cnt == 0 ) { Console.Write("\n==> "); }

    if ( cnt < afpLength )
    {   
        Console.Write(arrayForPrint[afpLength - cnt] + " ");
        PrintArrayRevers(arrayForPrint, cnt + 1);   
    }
    else
    {
        Console.Write(arrayForPrint[afpLength - cnt]);
    }

}

int[] array = MakeArray(10, 1, 100);

PrintArray(array);

PrintArrayRevers(array);


