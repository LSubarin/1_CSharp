/*
Задание 1. Совместная работа
Семинар 2. Простые алгоритмы на C#
Напишите программу, которая принимает на вход
трёхзначное число и удаляет вторую цифру этого
числа.
Примеры
a = 256 => 26
a = 891 => 81
*/

int number = 679;
int firstDigits = number / 100;
int thirdDigits = number % 10;
int result = firstDigits * 10 + thirdDigits;
Console.WriteLine($"При удалении из числа {number} средней цифры получится число {result}");

