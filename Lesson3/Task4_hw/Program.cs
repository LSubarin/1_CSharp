/* Изменить код - использовать функции

int n = 10;
int[] arr = new int[n];
int i = 0;
while (i < n)
{
    arr[i] = i + 1;
}
i = 0;
while (i < n)
{
    Console.WriteLine($"{arr[i]} ");
}
i = 0;
sum = 0;
while (i < n)
{
    sum = sum + arr[i];
}
i = 0;
int product = 0;
while (i < n)
{
    product = product * arr[i];
}
Console.WriteLine(sum);
Console.WriteLine(product);
*/

// Создаем функцию заполнения массива

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
    return arr;
}

// Создаем функцию вывода массива

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

// Создаем метод вычисления суммы элементов массива

int GetSumOfElements(int[] arr)
{
    int sumOf = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sumOf = sumOf + arr[i];
    }
    return sumOf;
}

// Создаем метод вычисления произведения всех элементов массива

int GetProductOfElements(int[] arr)
{
    int productOf = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        productOf = productOf * arr[i];
    }
    return productOf;
}
int n = 10;
int[] res = FillArray(n); // Создали массив на 10 элементов
PrintArray(res);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива равна: {GetSumOfElements(res)}"); // должно быть 55
Console.WriteLine($"Произведение элементов массива равна: {GetProductOfElements(res)}"); // Должно быть 3628800





/* 
Заполнение массива случайными числами из диапазона от 1 до 10 
*/
// Random rnd = new Random();
// int size = 1000;
// int[] arr_int = new int[size];
// int i = 0;
// while (i < size)
// {
//     arr_int[i] = rnd.Next(1, 10);
//     i = i + 1;
// }
// i = 0;
// while (i < size)
// {
//     Console.Write($"{arr_int[i]} ");
//     i = i + 1;
// }





/* заполняем массив с клавиатуры
int [] CreateArray (int size) 
{
int [] array = new int[size]; // массив на size элементов все элементы равны 0 
 for (int i = 0; i < array.Length; i++)
 {
         array[i] = new Random().Next(100,1000);
}
return array; 
}
*/