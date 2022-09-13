// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// Console.WriteLine("Введите первое число");
// int firstDigit = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondDigit = Convert.ToInt32(Console.ReadLine());

// if (firstDigit > secondDigit) Console.WriteLine("Первое число должно быть больше второго");
// int NaturalNumber (int fDigit, int sDigit)
// {
//     if(fDigit == sDigit+1) return 0;
//     return fDigit + NaturalNumber (fDigit+1, sDigit);
//     fDigit++;
// }
// Console.WriteLine(NaturalNumber(firstDigit,secondDigit));

// Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии.
Console.WriteLine("Введите первое число");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction (int fDigit,int sDigit)
{
    if (fDigit > 0 && sDigit == 0) return AkkermanFunction(fDigit - 1, 1);
    if (fDigit > 0 && sDigit > 0) return AkkermanFunction(fDigit-1, AkkermanFunction(fDigit, sDigit - 1));
    return sDigit + 1;
}

Console.WriteLine(AkkermanFunction(firstDigit, secondDigit));