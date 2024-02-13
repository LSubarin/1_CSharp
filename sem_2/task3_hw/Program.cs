/*
Задача 3: Напишите программу, которая принимает
на вход целое число из отрезка [10, 99] и показывает
наибольшую цифру числа.
*/

int number = 73;
int firstDigit = number / 10;
int secondDigit = number % 10;
if(firstDigit > secondDigit)
{
    Console.WriteLine($"Первая цифра числа {number} - {firstDigit} больше второй");
}
else
{   
    Console.WriteLine($"Вторая цифра числа {number} - {secondDigit} больше первой");
}