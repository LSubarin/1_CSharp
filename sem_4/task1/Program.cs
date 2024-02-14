// Тип метода ИмяМетода (параметр1,параметр2, ... ,параметр n)
// a, b - 2 числа, sing - знак арифм. операции
int Calculate(int a, int b, string sing)
{
    if (sing == "+")
    {
        return a + b; // сумма чисел
    }
    else if (sing == "-")
    {
        return a - b; // Разность чисел
    }
    else if (sing == "*")
    {
        return a * b; // Произведение чисел
    }
    else
    {
        Console.WriteLine("Введен неизвестный знак арифм. операции");
        return 0;
    }

}

// Вызов метода
Console.WriteLine(Calculate(2, 3, "+"));
Console.WriteLine(Calculate(2, 3, "-"));
Console.WriteLine(Calculate(20, 3, "*"));
Console.WriteLine(Calculate(2, 3, "."));