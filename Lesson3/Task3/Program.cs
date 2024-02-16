void ZeroEvenElements(int[] arr) // Создаем функцию, обнуляющую четные элементы массива
{
    for (int i = 0; i < arr.Length; i++) // Проходим циклом по элементам массива
    {
        if (arr[i] % 2 == 0)    // Проверяем очередной эллемент массива на четность
        {
            arr[i] = 0;         // Если очередной элемент четный присваиваем ему значение 0
        }
    }
}

void PrintArray(int[] arr) // Создаем функцию вывода массива 
{
    foreach (int e in arr) 
    {
        Console.WriteLine($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);

int[] array2 = {12,11,3,6,79,9,23,54,23,877};
ZeroEvenElements(array2);
PrintArray(array2);