/*
Задание 2. Работа в сессионных залах
Семинар 2. Простые алгоритмы на C#
Напишите программу, которая принимает на вход трёхзначное
число и возводит вторую цифру этого числа в степень, равную
третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1
*/

int number = 956;
int secondDigits = number / 10 % 10;
int thirdDigits = number % 10;
int result = (int)Math.Pow(secondDigits, thirdDigits); // Приводим result операции Math.Pow(число, степень) к целому числу (int)
Console.WriteLine($"{secondDigits} ^ {thirdDigits} = {result}");


