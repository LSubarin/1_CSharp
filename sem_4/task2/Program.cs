/*
Задача 2.
Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2
*/
// Создаем метод Заполнения массива случайными числами

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Создали массив на size элементов заполненный нулями
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

// Создаем метод, выясняющий сколько элементов массива оканчиваются на 1 и кратны 7

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
            count++;
    }
    return count;
}
// Вызов метода заполнения массива CreateArray

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); // Вводим число с косоли и конвертируем строку в целое число
int[] res = CreateArray(N); // Создали массив на N элементов
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
int count = GetCount (res);
Console.WriteLine($"Результат: {GetCount(res)}");