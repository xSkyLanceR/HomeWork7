// Задача № 1

// int lines = 4;
// int columns = 5;

// double[,] GetArray(int m, int n)
// {
//     var result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble();
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write($"{arr[i, j]}");
//         }
//         System.Console.WriteLine();
//     }
// }

// PrintArray(GetArray(lines, columns));

// Задача № 2

// int lines = 4;
// int columns = 5;

// int[,] GetArray(int m, int n)
// {
//     var result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(100);
//         }
//     }
//     return result;
// }

// bool Contais(int[,] arr, int element)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(arr[i, j] == element)
//             {
//                 return true;
//             }
//         }
      
//     }
//     return false;
// }


// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write($"{arr[i, j]}");
//         }
//         System.Console.WriteLine();
//     }
// }
// var arr= GetArray(lines, columns);
// foreach (var item in arr)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine(Contais(arr, 23));

// Задача № 3

int lines = 4;
int columns = 5;

int[,] GetArray(int m, int n)
{
    var result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(100);
        }
    }
    return result;
}

bool Contais(int[,] arr, int element)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] == element)
            {
                return true;
            }
        }
      
    }
    return false;
}

double[] GetAverage(int[,] arr)
{
    var result = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        result[i] = Math.Round(sum / arr.GetLength(0), 2);
    }
    return result;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}");
        }
        System.Console.WriteLine();
    }
}

foreach (var item in GetAverage(GetArray(lines, columns)))
{
    System.Console.WriteLine(item);
}