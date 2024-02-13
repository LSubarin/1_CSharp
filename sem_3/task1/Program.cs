﻿/*
Задание 1. Совместная работа
Семинар 3. Массивы
15 мин
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да 
*/
int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 }; // Заданный массив элементов
int numberForSearch = 44; // Искомое число из массива
bool isFound = false; // Переменная указывает что изначально число не найдено
//точка старта; условие; увеличение счетчика
for (int i = 0; i < array.Length; i++) // array.Lenght ищет количество элементов массива (если счетчик меньше количества элементов, увеличиваем счетчик)
{
    if (numberForSearch == array[i])
    {
        isFound = true;
        break; // Останавливает цикл при достижении условия
    }
}    
if (isFound) // Если isFound = true 
{
    Console.WriteLine("Да"); // выводим Да
}
else    // Иначе
{
    Console.WriteLine("Нет"); // выводим нет
}