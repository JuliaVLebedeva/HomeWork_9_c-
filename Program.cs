void Zadacha64()
{
    // Задача 64: Задайте значения M и N. 
    //Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
    // M = 1; N = 5. -> "1, 2, 3, 4, 5"
    // M = 4; N = 8. -> "4, 6, 7, 8"

    Console.WriteLine("Введите начальное число");
    int minNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последнее число");
    int maxNumber = Convert.ToInt32(Console.ReadLine());

    string NaturalNumbers(int m, int n)
    {
        if(m==n) return n.ToString();
        return ($"{m}, {NaturalNumbers(m+1,n)}");
    }
    Console.WriteLine($"Все числа в промежутке от {minNumber} до {maxNumber} ");
    Console.WriteLine(NaturalNumbers(minNumber,maxNumber));
}

void Zadacha66()
{
    // Задача 66: Задайте значения M и N. 
    //Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30

    Console.WriteLine("Введите начальное число");
    int minElement = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последнее число");
    int maxElement = Convert.ToInt32(Console.ReadLine());

    int SummNatural(int m, int n)
    {
        if(m==n) return m;
        return (m+SummNatural(m+1,n));
    }

    Console.WriteLine($"Сумма чисел от {minElement} до {maxElement} равна: ");
    Console.WriteLine(SummNatural(minElement,maxElement));
}

void Zadacha68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    //Даны два неотрицательных числа m и n. 
    // m = 2, n = 3 -> A(m,n) = 29

    int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        if (m > 0 && n > 0) return Akkerman(m - 1,Akkerman(m,n-1));

        return Akkerman(m,n); 
    }
    Console.WriteLine(Akkerman(3,5));
}

//Zadacha64();
//Zadacha66();
//Zadacha68();