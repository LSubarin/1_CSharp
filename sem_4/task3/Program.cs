﻿/*
Задание 3. Совместная работа
Семинар 4. Функции
20 мин
Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
*/

// Создаем метод создания массива и заполнения его элементов случайными числами 
int[] CreateArray(int size)
{
    int[] array = new int[size]; // Создали массив на size элементов заполненный нулями
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10); // Если не указан первый параметр, диапазон берется от 0 до указанного числа. В данном случае от 0 до 9
    }
    return array;
}

int ConvertArrayToInteger(int[] array)
{
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        result = result + array[i] * (int)Math.Pow(10, j);
    }
    return result;
}

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine()); // Вводим число с косоли и конвертируем строку в целое число
int[] res = CreateArray(N); // Создали массив на N элементов
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Результат: [ {ConvertArrayToInteger(res)} ]");

