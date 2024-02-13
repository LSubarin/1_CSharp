/*
Задание 3. Работа в сессионных залах
Семинар 2. Простые алгоритмы на C#
Напишите программу, которая будет принимать на вход два
числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит
остаток от деления.
Примеры
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1
*/
int firstNumber = 16;
int secondNumber = 8;
int remainder = firstNumber % secondNumber;
if (remainder == 0)
{
    Console.WriteLine($"{firstNumber}, {secondNumber} => да");
}
else
{
    Console.WriteLine($"{firstNumber}, {secondNumber} => нет, {remainder}");
}