int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount]; // Создпаем 2х мерный массив из 3 строк по 5 элементов
    Random rnd = new Random(); // Задействуем генератор случайных чисел

    for (int i = 0; i < matrix.GetLength(0); i++) // Первый цикл перебирает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Второй цикл перебирает столбцы
        {

            matrix[i, j] = rnd.Next(1, 1000); // Заполняем массив случайными числами из диапазона от 1 до 1000
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

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (isInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}
bool isInteresting(int value)
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}
int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}
