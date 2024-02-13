/*
Задача 4: Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.
*/

// int number = 923879874;
// while (number / 10 > 0)
// {
//     int nextDigit = number % 10;
//     number = number / 10;
//     Console.Write(nextDigit + ",");
// }
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N < 10)
        {
            Console.WriteLine(N);
        }
        else
        {
            while (N > 0)
            {
                int currentDigit = N % 10;
                N /= 10;
                if (N > 0)
                {
                    Console.Write(currentDigit + ",");
                }
                else
                {
                    Console.WriteLine(currentDigit);
                }
            }
        }
    }
}