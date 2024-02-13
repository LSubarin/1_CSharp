/*
Задание 3*. Работа в сессионных залах
Семинар 1. Знакомство с языками программирования
Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17 
*/

int number = 30;
if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    Console.WriteLine ("Результат " + (firstDigit+thirdDigit));
}
else
{
    Console.WriteLine("Error!");
}