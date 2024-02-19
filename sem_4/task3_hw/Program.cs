/*
Задача 3: Напишите программу, которая перевернёт
одномерный массив (первый элемент станет
последним, второй – предпоследним и т.д.)

[1 3 5 6 7 8] => [8 7 6 5 3 1]

*/
// int[] array = { 1, 3, 5, 6, 7, 8 };
// Console.WriteLine(array);
// int n = (array.Length);
// int[] arrTwist = new int[n];
// for (int i = 0; i < array.Length; i++)
// {
//     arrTwist[i]=array[array.Length-i];
// }
// Console.WriteLine(array);
// Console.WriteLine(arrTwist);


int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
int temp;

// Вывод исходного массива

Console.WriteLine("Исходный массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}

// Реверсирование массива

for (int i = 0; i < numbers.Length / 2; i++)
{

// Меняем местами элементы

    temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

// Вывод измененного массива

Console.WriteLine("\nПеревернутый массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
