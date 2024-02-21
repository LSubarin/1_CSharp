/*
Задание 1. Совместная работа
Семинар 5. Двумерные массивы
15 мин
Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.
*/
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0);
    {
        for (int j = 0; j < columns; j++) // columns = matr.GetLength(1);
        {
            matr[i, j] = rnd.Next(0, 101);
        }
    }
    return matr;
}
void SquareElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) // проверка на четность индексов элементов
            {
                matr[i, j] *= matr[i, j];
            }
        }

    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t"); // "\t" - ставит четыре пробела после каждого элемента
        }
        Console.WriteLine();
    }
}

Console.Write($"Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, cols);
PrintMatrix(matrix);
Console.WriteLine("Результат:");
SquareElements(matrix);
PrintMatrix(matrix);

