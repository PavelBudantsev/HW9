// Пользователя просят ввести свой возраст и имя. 
// Программа должна прибавить к введенному возрасту 
// один год и корректно обработать согласование предложения (...лет, год и тд)
Console.WriteLine("Как тебя зовут?");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}");

Console.WriteLine("Сколько тебе лет?");
int age = Convert.ToInt32(Console.ReadLine());
age = age + 1;

if (age <= 0) 
{
Console.WriteLine("Возраст не может быть отрицательным, введите корректное значение");
}
// 1 год
// 2 3 4 года
// 5 - 20 лет
// 21 год
// 22 23 24 года
// 25 - 30 лет
string ageStr = $"А я думал, тебе {age}";

if (age <= 20)
{
    if (age == 1)
    {
        Console.WriteLine ($"{ageStr} один год");
    }
    if (age > 1 && age < 5)
    {
        Console.WriteLine ($"{ageStr} года");
    }
    if (age > 4 && age <= 20)
    {
        Console.WriteLine ($"{ageStr} лет");
    }
}
if (age >= 20 )
{
    if (age % 10 == 1)
    {
        Console.WriteLine ($"{ageStr} год");
    }
    if (age % 10 == 2 | age % 10 == 3 | age % 10 == 4)
    {
        Console.WriteLine ($"{ageStr} года");
    }
    if (age % 10 == 0 | age % 10 > 4 )
    {
        Console.WriteLine ($"{ageStr} лет");
    }
}