/*Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine ());

int square = number * number;

Console.WriteLine (square);
*/

// Console.Write("Введите первое число ");
// int firstNumber = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Введите второе число ");
// int secondNumber = Convert.ToInt32(Console.ReadLine ());

// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine(firstNumber + " Это квадрат числа " + secondNumber);
// }
// else 
// {
//     Console.WriteLine("Это не квадрат числа");
// }

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
// Console.Write("Введите число N ");
// int number = Convert.ToInt32(Console.ReadLine());
// int negativeNumber = number * (-1);

// while (negativeNumber <= number)
// {
//     Console.Write(negativeNumber);
//     Console.Write(" ");
//     negativeNumber++;
// }

// int number = new Random().Next(10, 100);

// Console.WriteLine($"Случайное число {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// int max = firstDigit;
// if (secondDigit > firstDigit)
// {
//     max = secondDigit;
// }
// Console.WriteLine($"Максимальное число это {max}");


// int number = new Random().Next(100, 999);

// int firstDigit = number / 100;
// int theirdDigit = number % 100;

// int super = theirdDigit % 10;

// Console.WriteLine($"Случайное число {number}");
// Console.WriteLine($"Первое число {firstDigit}");

// Console.WriteLine($"Третье число {super}");

// Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1,
//  то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 4 -> 16 -> кратно

// int firstNumber = Convert.ToInt32 (Console.ReadLine());
// int secondNumber = Convert.ToInt32 (Console.ReadLine());

// int div = secondNumber % firstNumber;

// if (secondNumber % firstNumber == 0)
// {
//     Console.WriteLine("Число кратное");
// }
// else
// {
// Console.WriteLine("Остаток от деления " + div);
// }

// Кратное 7 и 23

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32 (Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine ("Это число кратное 7 и 23");
// }
// else
// {
//     Console.WriteLine ("Это число не является кратным 7 и 23");
// }

// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
int number = Convert.ToInt32(Console.ReadLine());
int SumNumber (int digit)
{
    if (digit == 0) return 0;
    return digit%10 + SumNumber(digit/10);
}
Console.WriteLine(SumNumber(number));