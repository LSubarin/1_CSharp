// int[,] matrix = new int[3, 5]; // Создпаем 2х мерный массив из 3 строк по 5 элементов
// Random rnd = new Random(); // Задействуем генератор случайных чисел

// for (int i = 0; i < matrix.GetLength(0); i++) // Первый цикл перебирает строки
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // Второй цикл перебирает столбцы
//     {

//         matrix[i, j] = rnd.Next(1, 11); // Заполняем массив случайными числами из диапазона от 1 до 10
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {

//         Console.Write($" {matrix[i, j]} "); // Выводим строку массива
//     }
//     Console.WriteLine(); // Перехолим на следующую строку
// }

int[,] CreateMatrix (int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount]; // Создпаем 2х мерный массив из 3 строк по 5 элементов
    Random rnd = new Random(); // Задействуем генератор случайных чисел

    for (int i = 0; i < matrix.GetLength(0); i++) // Первый цикл перебирает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Второй цикл перебирает столбцы
        {

            matrix[i, j] = rnd.Next(1, 11); // Заполняем массив случайными числами из диапазона от 1 до 10
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($" {matrix[i, j]} "); // Выводим строку массива
        }
        Console.WriteLine(); // Перехолим на следующую строку
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
