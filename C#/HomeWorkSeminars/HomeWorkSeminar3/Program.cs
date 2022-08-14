// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// Console.WriteLine("Введите целое число");
// int cube = Convert.ToInt32 (Console.ReadLine());

// for(int i = 1; i <= cube; i++) 
//     Console.WriteLine (Math.Pow(i, 3));

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// int dim = 3;
// int[] A = new int[dim];
// int[] B = new int[dim];
// Console.WriteLine("Введите координаты первой точки");
// for (int i = 0; i < dim; i++)  
//    A[i] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки");
// for (int i = 0; i < dim; i++)  
//    B[i] = Convert.ToInt32(Console.ReadLine());

// double distanse = Math.Sqrt(Math.Pow((B[0]-A[0]),2) + Math.Pow((B[1]-A[1]),2) + Math.Pow((B[2]-A[2]),2));
// Console.WriteLine ($"Расстояние между этими точками: {Math.Round (distanse, 2)}");


// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Console.WriteLine("Введите пятизначное число ");
// string polindromStr = Console.ReadLine();
// if (polindromStr[0] == polindromStr[4] && polindromStr[1] == polindromStr[3])
//     Console.WriteLine("Это число - полиндром");
// else Console.WriteLine("Это не полиндром");

// Бонус
// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// решаем через числа, а не через строки

// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100) Console.WriteLine("There is not third digit");
// else
// {
//     while (number > 999) number = number / 10;
//     Console.WriteLine(number % 10);
// }