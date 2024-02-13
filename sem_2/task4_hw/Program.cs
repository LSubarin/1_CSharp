/*
Задача 4: Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.
*/

int number = 923879874;
while (number / 10 > 0)
{
    int nextDigit = number % 10;
    number = number / 10;
    Console.Write(nextDigit + ",");
}
